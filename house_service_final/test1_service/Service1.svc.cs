using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Test1_serviceML.Model;

namespace test1_service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        mydb db = new mydb();

       
        public float predict_value(Details d)
        {
            ModelInput ml = new ModelInput();
            ml.LotArea = d.LotArea;
            ml.Street = d.Street;
            ml.Neighborhood = d.Neighborhood;
            ml.Utilities = d.Utilities;
            ml.HouseStyle = d.HouseStyle;
            ml.OverallCond = d.OverallCond;
            ml.OverallQual = d.OverallQual;
            ml.YearBuilt = d.YearBuilt;
            ml.TotalBsmtSF = d.TotalBsmtSF;
            ml.CentralAir = d.CentralAir;
            ml.Col1stFlrSF = d.FirstFlrSF;
            ml.Col2ndFlrSF = d.SecondFlrSF;
            ml.GrLivArea = d.GrLivArea;
            ml.BedroomAbvGr = d.BedroomAbvGr;
            ml.FullBath = d.FullBath;
            ml.KitchenAbvGr = d.KitchenAbvGr;
            ml.TotRmsAbvGrd = d.TotRmsAbvGrd;
            ml.SalePrice = d.SellPrice;
            ConsumeModel c = new ConsumeModel();
     
            var p= ConsumeModel.Predict(ml);
            var re = p.Score;
            return re;
            

        }
        public List<HouseDetail> get_value()
        {
            List<HouseDetail> h=new List<HouseDetail>();
           var h1  = db.house.ToList();
           
            for(int i=0;i<h1.Count;i++)
            {
                HouseDetail d = new HouseDetail();
                d.Area = h1[i].area;
                d.City = h1[i].city;
                d.BuiltYear = h1[i].bulit_year;
                d.ContactNo = h1[i].contact_no;
                d.IsOffer = h1[i].isoffer;
                d.Price = h1[i].price;
                d.SquareFt = h1[i].squareFt;
                d.State = h1[i].state;
                d.Bath = h1[i].bathtub;
                d.Name = h1[i].name;
                d.NoOfBedroom = h1[i].no_of_bedroom;
                d.Image1 = h1[i].image1;
                d.Image2 = h1[i].image2;
                d.Image3 = h1[i].image3;
                d.Image4 = h1[i].image4;

                //d.Imgpath = h1[i].image;
                h.Add(d);


            }
            return h;
        }
        public void add_value(HouseDetail h, float price)
        {
            House h1 = new House();
            h1.city = h.City;
            h1.area = h.Area;
            h1.state = h.State;
            h1.squareFt = h.SquareFt;
            h1.no_of_bedroom = h.NoOfBedroom;
            h1.name = h.Name;
            h1.bathtub = h.Bath;
            h1.contact_no = h.ContactNo;
            h1.price = price;
            h1.image1 = h.Image1;
            h1.image2 = h.Image2;
            h1.image3 = h.Image3;
            h1.image4 = h.Image4;

            h1.bulit_year = h.BuiltYear;
            h1.isoffer = h.IsOffer;
            //Debug.WriteLine("image is " + h1.imgpath);
            Debug.WriteLine(h1.ToString());
            db.house.Add(h1);
            db.SaveChanges();
        }
    }
}
