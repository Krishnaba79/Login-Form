using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_Form
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // Sample hardcoded user credentials
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // You can replace this with actual DB logic
            if (username == "admin" && password == "password123")
            {
                // Redirect to another page upon successful login
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                lblMessage.Text = "Invalid Username or Password!";
            }
        }
    }
}