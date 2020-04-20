using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test1.ServiceReference1;

namespace test1
{
    public partial class search : System.Web.UI.Page
    {
        public IEnumerable<HouseDetail> h1;
        protected void Page_Load(object sender, EventArgs e)
        {

            string name = Request.QueryString["name"];
            ServiceReference1.Service1Client se = new ServiceReference1.Service1Client();
          h1=  se.search_area(name);

        }
    }
}