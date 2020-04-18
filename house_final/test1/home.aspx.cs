using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test1.ServiceReference2;

namespace test1
{
    public partial class home1 : System.Web.UI.Page
    {
        public IEnumerable<HouseDetail> h;
        ServiceReference2.Service1Client se = new ServiceReference2.Service1Client();
        public void Page_Load(object sender, EventArgs e)
        {

             h=se.get_value();  
           
         

           
        }
    }
}