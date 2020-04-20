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
        public List<AgentDetail> agent()
        {
            Dictionary<string[], int> d = new Dictionary<string[], int>();
            var p=db.house.GroupBy(u => u.username).Select(u => new {name= u.Key, count = u.Count() }).ToList();
            List<AgentDetail> ag = new List<AgentDetail>();
            for(int i=0;i<p.Count;i++)
            {
                string name1 = p[i].name;
                var a = db.user.Where(u => u.username == name1).Select(u => u.image1).ToList();
                AgentDetail ag1 = new AgentDetail();
                ag1.Count = p[i].count;
                ag1.Username = p[i].name;
                if (a.Count != 0)
                    ag1.Image = a[0];
                else
                    ag1.Image = "";

                ag.Add(ag1);

                
               
            }
            return ag;
        }
        public List<HouseDetail> offer_value()
        {
            List<HouseDetail> h = new List<HouseDetail>();
            var h1 = db.house.Where(u => u.isoffer == "yes").ToList();
            for (int i = 0; i < h1.Count; i++)
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
                d.Id = h1[i].Id;
                h.Add(d);


            }
            return h;

        }
        public List<HouseDetail> get_property(string uname)
        {
            List<HouseDetail> h = new List<HouseDetail>();
            var h1 = db.house.Where(u=>u.username==uname).ToList();
            for (int i = 0; i < h1.Count; i++)
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
                d.Id = h1[i].Id;
                d.Image1 = h1[i].image1;
                d.Image2 = h1[i].image2;
                d.Image3 = h1[i].image3;
                d.Image4 = h1[i].image4;
                h.Add(d);


            }
            return h;

        }
        public void add_user(user u)
        {
            db.user.Add(u);
            db.SaveChanges();
        }
        public bool check_user(string uname,string pass)
        {
            var a = db.user.Where(u =>  u.username == uname && u.password == pass ).Select(u=>u.username).ToList();
            if(a.Count!=0)
            {
                return true;
            }
            return false;

        }
        public List<HouseDetail> search_area(string area)
        {
            List<HouseDetail> h = new List<HouseDetail>();
            var h1 = db.house.Where(i => i.state == area).ToList();
            for (int i = 0; i < h1.Count; i++)
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
                h.Add(d);


            }
            return h;
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
                d.Id=h1[i].Id;
                d.Image1 = h1[i].image1;
                d.Image2 = h1[i].image2;
                d.Image3 = h1[i].image3;
                d.Image4 = h1[i].image4;
              
                h.Add(d);


            }
            return h;
        }
        public void delete(string name)
        {
            var a=db.house.Where(i => i.name == name).Select(u=>u.Id).ToList();
            int id = a[0];
            House h = db.house.Find(id);
            db.house.Remove(h);
            db.SaveChanges();


            }


        
        public void add_value(HouseDetail h)
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
            h1.price = h.Price;
            h1.username = h.Username;
            h1.image1 = h.Image1;
            h1.image2 = h.Image2;
            h1.image3 = h.Image3;
            h1.image4 = h.Image4;
            h1.isoffer = h.IsOffer;
            db.house.Add(h1);
            db.SaveChanges();
        }
    }
}
