using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Net;
using System.Net.Mail;

namespace LoginPage.asp
{
    public partial class ForgetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void email_button_Click(object sender, EventArgs e)
        {
            // establishing connection with the database
            string con = ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
            SqlConnection sqlcon = new SqlConnection(con);
            // get the password for the registered user with the entered e-mail address on the text box for further use in the application
            string sqlQuery = "SELECT Email, Password FROM Registrations WHERE Email=@Email";
            SqlCommand sqlcom = new SqlCommand(sqlQuery, sqlcon);
            // parameters (string, object)
            sqlcom.Parameters.AddWithValue("@Email", email_textbox.Text);
            sqlcon.Open();
            SqlDataReader sdr = sqlcom.ExecuteReader();

            // if the e-mail address entered on the text box is registered
            if (sdr.Read())
            {
                // declaring strings for Email and Password columns in the database (0, 1)
                string userName = sdr["Email"].ToString();
                string password = sdr["Password"].ToString();

                // send an e-mail from the admin account to the registered e-mail so he can recover his password
                MailMessage message = new MailMessage("admin's e-mail", email_textbox.Text);
                message.Subject = "Confidential e-mail";
                message.Body = string.Format("<h4>Hello, <strong>{0}</strong> is your registered e-mail address. <br /> Your password is <strong>{1}.</strong></h4> <p>This e-mail was intended for {0}, if you are receiving this e-mail and it is not intended for you, please contact us at +38970707707, <strong>thank you!</strong></p>", userName, password);
                message.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential nc = new NetworkCredential();
                // signing in to g-mail (access for third-party applications must be enabled first!)
                nc.UserName = "admin's e-mail";
                nc.Password = "admin's password";
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = nc;
                // custom g-mail port
                smtp.Port = 587;
                smtp.Send(message);
                // displaying the label depending if the process was successful or not
                email_label.Text = "Your forgotten password has been sent to " + email_textbox.Text;
                email_label.ForeColor = Color.Green;
            }

            else
            {
                email_label.Text = email_textbox.Text + " is not registered!";
                email_label.ForeColor = Color.DarkRed;
            }
        }
    }
}