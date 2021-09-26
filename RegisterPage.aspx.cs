using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


namespace LoginPage
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        // establishing connection with the database
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_register_Click(object sender, EventArgs e)
        {
            // inserting the username and the password from the text boxes into the database
            try
            {
                string insert = "Insert into [Registrations](Email, Password) values('" + txt_textboxemail.Text + "', '" + txt_password.Text + "')";
                SqlCommand cmd = new SqlCommand(insert, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                Label_registration.Text = "Registration Successful!";
            }
            catch (Exception)
            {
                Label_registration.Text = "You can't registrate at the moment, please try again later.";
            }
        }
    }
}