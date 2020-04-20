using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test1.ServiceReference1;

namespace test1
{
    public partial class login : System.Web.UI.Page
    {
        ServiceReference1.Service1Client se = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            click.ServerClick += new EventHandler(submit_click);
        }
        protected void submit_click(object sender, EventArgs e)
        {
            string username = Request.Form["t1"];
            string pass = Request.Form["t2"];
            string email = Request.Form["t3"];
            bool a=se.check_user(username, pass);
            if(a)
            {
                Session["user"] = username;
                Response.Redirect("~/home.aspx");
            }
            else
            {
                string script = "<script type=\"text/javascript\">alert(\'" + "Username or Password is wrong!!" +  "\');</script>";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script);
               
            }
            
            
          
        }
    }
}