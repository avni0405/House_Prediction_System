using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test1.ServiceReference1;

namespace test1
{
    public partial class signup : System.Web.UI.Page
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
            user u = new user();
            u.username = username;
            u.password = pass;
            u.email = email;
            if (img1.HasFile)
            {
                try
                {
                    string str = img1.FileName;
                    img1.PostedFile.SaveAs(Server.MapPath("~/upload/" + str));
                    string imgpath = "/upload/" + str.ToString();
                    u.image1 = imgpath;

                }
                catch (Exception ee)
                {
                    Debug.WriteLine(ee);
                }

            }
            se.add_user(u);
            Response.Redirect("~/login.aspx");
        }
    }
}