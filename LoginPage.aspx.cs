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
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                Label1.Text = "Your E-mail or Password is invalid!";
            }

        }
    }
}