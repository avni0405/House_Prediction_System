using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using test1.ServiceReference1;

namespace test1
{
    public partial class view_property : System.Web.UI.Page
    {
        public IEnumerable<HouseDetail> h;
        ServiceReference1.Service1Client se = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
           h= se.get_property(Session["user"].ToString());
           hnameid.ServerClick += new EventHandler(submit_click);




        }
       
        protected void submit_click(object sender,EventArgs e)
        {
            var name = Request.Form["hname"];
            se.delete(name);
            string script = "<script type=\"text/javascript\">alert(\'" + "Property deleted sucessfully!!" + "\');</script>";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script);
        }
    }
}