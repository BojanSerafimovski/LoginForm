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
    public partial class LoginPage : System.Web.UI.Page
    {
        // establishing connection with the database
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            // displaying the values that the cookies remembered
            if (!IsPostBack)
            {
                if (Request.Cookies["Email"] != null && Request.Cookies["Password"] != null)
                {
                    txt_username.Text = Request.Cookies["Email"].Value;
                    txt_password.Attributes["value"] = Request.Cookies["Password"].Value;
                }
            }
        }

        protected void Btn_login_Click(object sender, EventArgs e)
        {
            // comparing the username and the password entered on the text boxes with the ones that are registered in the database
            string checkRegistration = "select count(*) from [Registrations] where Email = '" + txt_username.Text + "' and Password = '" + txt_password.Text + "' ";
            SqlCommand cmd = new SqlCommand(checkRegistration, con);
            con.Open();
            // if the entered data is valid redirect the user to the home page and if not display the Label and block his entrance
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            con.Close();
            if (temp == 1)
            {
                // enabling the cookies to remember the username and the password for 1 minute if the checkbox is checked
                if (checkbox.Checked)
                {
                    Response.Cookies["Email"].Value = txt_username.Text;
                    Response.Cookies["Password"].Value = txt_password.Text;

                    Response.Cookies["Email"].Expires = DateTime.Now.AddMinutes(1);
                    Response.Cookies["Password"].Expires = DateTime.Now.AddMinutes(1);
                }
                else
                {
                    Response.Cookies["Email"].Expires = DateTime.Now.AddMinutes(-1);
                    Response.Cookies["Password"].Expires = DateTime.Now.AddMinutes(-1);
                }

                Response.Redirect("HomePage.aspx");
            }
            else
            {
                Label1.Text = "Your E-mail or Password is invalid!";
            }

        }
    }
}