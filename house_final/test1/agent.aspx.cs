﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test1.ServiceReference2;

namespace test1
{
   
    public partial class home : System.Web.UI.Page
    {
        ServiceReference2.Service1Client se = new ServiceReference2.Service1Client();
        
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
            HouseDetail h = new HouseDetail();

            h.City = Request.Form["t21"];
            h.Area = Request.Form["t2"];
            h.State = Request.Form["t20"];
            h.SquareFt = int.Parse(Request.Form["t11"]) + int.Parse(Request.Form["t12"]);
            h.NoOfBedroom = int.Parse(Request.Form["t15"]);
            h.Name = (Request.Form["t23"]);
            h.Bath = int.Parse(Request.Form["t24"]);
            h.ContactNo = Request.Form["t19"];
            h.Price= float.Parse(Request.Form["t18"]);
            h.IsOffer = bool.Parse(Request.Form["t22"]);
            h.BuiltYear = int.Parse(Request.Form["t8"]);
            if (img1.HasFile)
            {
                try
                {
                    string str = img1.FileName;
                    img1.PostedFile.SaveAs(Server.MapPath("~/upload/" + str));
                    string imgpath = "~/upload/" + str.ToString();
                    h.Image1 = imgpath;

                }
                catch(Exception ee)
                {
                    Debug.WriteLine(ee);
                }

            }
            if (img2.HasFile)
            {
                try
                {
                    string str = img2.FileName;
                    img2.PostedFile.SaveAs(Server.MapPath("~/upload/" + str));
                    string imgpath = "~/upload/" + str.ToString();
                    h.Image2 = imgpath;

                }
                catch (Exception ee)
                {
                    Debug.WriteLine(ee);
                }

            }
            if (img3.HasFile)
            {
                try
                {
                    string str = img3.FileName;
                    img3.PostedFile.SaveAs(Server.MapPath("~/upload/" + str));
                    string imgpath = "~/upload/" + str.ToString();
                    h.Image3 = imgpath;

                }
                catch (Exception ee)
                {
                    Debug.WriteLine(ee);
                }

            }
            if (img4.HasFile)
            {
                try
                {
                    string str = img4.FileName;
                    img4.PostedFile.SaveAs(Server.MapPath("~/upload/" + str));
                    string imgpath = "~/upload/" + str.ToString();
                    h.Image4 = imgpath;

                }
                catch (Exception ee)
                {
                    Debug.WriteLine(ee);
                }

            }

            se.add_value(h,re);




            string script = "<script type=\"text/javascript\">alert(\'" + "Predicted value"+re.ToString() + "\');</script>";
            ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", script);
           



        }
    }
}