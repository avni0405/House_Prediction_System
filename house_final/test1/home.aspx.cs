using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test1.ServiceReference1;

namespace test1
{
    public partial class home1 : System.Web.UI.Page
    {

        public IEnumerable<HouseDetail> h;
        public IEnumerable<AgentDetail> d;
        ServiceReference1.Service1Client se = new ServiceReference1.Service1Client();
        public void Page_Load(object sender, EventArgs e)
        {

            h = se.offer_value();
            d = se.agent();
            click.ServerClick += new EventHandler(submit_click);




        }
        protected void submit_click(object sender, EventArgs e)
        {
            string area = Request.Form["search"];
            Response.Redirect(String.Format("~/search.aspx?name={0}", area));
        }
    }
}