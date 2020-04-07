using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test1.ServiceReference1;

namespace test1
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        ServiceReference1.Service1Client se = new ServiceReference1.Service1Client();
        protected void Button1_Click(object sender, EventArgs e)
        {
            Details d = new Details();
            d.LotArea =float.Parse(t1.Text);
            d.Street = DropDownList1.SelectedValue;
            d.Utilities = DropDownList2.SelectedValue;
            d.Neighborhood = DropDownList3.SelectedValue;
            d.HouseStyle = DropDownList4.SelectedValue;
            d.OverallQual = float.Parse(t2.Text);
            d.OverallCond = float.Parse(t3.Text);
            d.YearBuilt = float.Parse(t4.Text);
            d.TotalBsmtSF = float.Parse(t5.Text);
            d.CentralAir = bool.Parse(t6.Text);
            d.FirstFlrSF = float.Parse(t7.Text);
            d.SecondFlrSF = float.Parse(t8.Text);
            d.GrLivArea = float.Parse(t9.Text);
            d.FullBath = float.Parse(t10.Text);
            d.BedroomAbvGr = float.Parse(t11.Text);
            d.KitchenAbvGr = float.Parse(t12.Text);
            d.SellPrice = float.Parse(t13.Text);
            d.TotRmsAbvGrd = float.Parse(t14.Text);
            float re = se.predict_value(d);
            Label1.Text = "Predicted value"+re.ToString();


        }
    }
}