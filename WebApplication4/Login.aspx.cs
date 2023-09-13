using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ERROR.Visible = false;
        }
        protected void Button1_Click (object sender, EventArgs e) 
        {
            string username = ConfigurationManager.AppSettings["user"];
            string password = ConfigurationManager.AppSettings["password"];


            if (username == Username.Text && password == Password.Text) 
            {
                FormsAuthentication.SetAuthCookie(Username.Text, false);
                Response.Redirect(FormsAuthentication.DefaultUrl);
            }
            else 
            {
                ERROR.Visible = true;
            }


        }
    }
}