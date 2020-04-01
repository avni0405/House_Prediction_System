using System;
using System.Collections.Generic;
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
    }
}
