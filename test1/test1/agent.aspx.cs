using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test1.ServiceReference1;

namespace test1
{
   
    public partial class home : System.Web.UI.Page
    {
        ServiceReference1.Service1Client se = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
        
            click.ServerClick += new EventHandler(submit_click);
        }
        protected void submit_click(object sender, EventArgs e)
        {
            Details d = new Details();
            d.LotArea = float.Parse(Request.Form["t1"]);
            d.Street = Request.Form["t2"];
            d.Utilities = Request.Form["t3"];
            d.Neighborhood = Request.Form["t4"];
            d.HouseStyle = Request.Form["t5"];
            d.OverallQual =float.Parse( Request.Form["t6"]);
            d.OverallCond = float.Parse(Request.Form["t7"]);
            d.YearBuilt = float.Parse(Request.Form["t8"]);
            d.TotalBsmtSF = float.Parse(Request.Form["t9"]);
            d.CentralAir = bool.Parse(Request.Form["t10"]);
            d.FirstFlrSF = float.Parse(Request.Form["t11"]);
            d.SecondFlrSF = float.Parse(Request.Form["t12"]);
            d.GrLivArea = float.Parse(Request.Form["t13"]);
            d.FullBath = float.Parse(Request.Form["t14"]);
            d.BedroomAbvGr = float.Parse(Request.Form["t15"]);
            d.KitchenAbvGr = float.Parse(Request.Form["t16"]);
            d.TotRmsAbvGrd = float.Parse(Request.Form["t17"]);
            d.SellPrice = float.Parse(Request.Form["t18"]);
            float re = se.predict_value(d);
            string script = "<script type=\"text/javascript\">alert(\'" + "Predicted value"+re.ToString() + "\');</script>";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script);
           



        }
    }
}