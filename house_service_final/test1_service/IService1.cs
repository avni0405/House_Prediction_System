using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace test1_service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        float predict_value(Details d);
        [OperationContract]
        void add_value(HouseDetail h, float p);
        [OperationContract]
        List<HouseDetail> get_value();

        // TODO: Add your service operations here
    }
    [DataContract]
    public class HouseDetail
    {

      
        string city=string.Empty;
         string area=string.Empty;
        string state;
        int squareFt;
       int no_of_bedroom;
         int bath;
         string contact_no;
         float price;
         bool isoffer;
         int bulit_year;
        string name = string.Empty;
        string image1;
        string image2;
        string image3;
        string image4;

        [DataMember]
        public string Image1
        {
            get { return image1; }
            set { image1 = value; }
        }

        [DataMember]
        public string Image2
        {
            get { return image2; }
            set { image2 = value; }
        }

        [DataMember]
        public string Image3
        {
            get { return image3; }
            set { image3 = value; }
        }

        [DataMember]
        public string Image4
        {
            get { return image4; }
            set { image4 = value; }
        }


        [DataMember]
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DataMember]
        public string Area
        {
            get { return area; }
            set { area = value; }
        }
        [DataMember]
        public string State
        {
            get { return state; }
            set { state= value; }
        }
        [DataMember]
        public int SquareFt
        {
            get { return squareFt; }
            set { squareFt = value; }
        }
        [DataMember]
        public int NoOfBedroom
        {
            get { return no_of_bedroom; }
            set { no_of_bedroom = value; }
        }
        [DataMember]
        public int Bath
        {
            get { return bath; }
            set { bath = value; }
        }
        [DataMember]
        public string ContactNo
        {
            get { return contact_no; }
            set { contact_no = value; }
        }
        [DataMember]
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        [DataMember]
        public bool IsOffer
        {
            get { return isoffer; }
            set { isoffer= value; }
        }
        [DataMember]
        public int BuiltYear
        {
            get { return bulit_year; }
            set { bulit_year = value; }
        }
    }
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Details
    {
        float loaarea;
        string street = string.Empty;
        string uti = string.Empty;
        string ne = string.Empty;
        string hs = string.Empty;
        float oq;
        float oc;
        float year;
        float totalbs;
        bool cair;
        float f1;
        float f2;
        float grliv;
        float fullbath;
        float bed;
        float kitchen;
        float abv;
        float price;
        [DataMember]
        public float LotArea
        {
            get { return loaarea; }
            set {loaarea = value; }
        }
        [DataMember]
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        [DataMember]
        public string Utilities
        {
            get { return uti; }
            set { uti = value; }
        }
        [DataMember]
        public string Neighborhood
        {
            get { return ne; }
            set { ne = value; }
        }
        [DataMember]
        public string HouseStyle
        {
            get { return hs; }
            set { hs = value; }
        }
        [DataMember]
        public float OverallQual
        {
            get { return oq; }
            set { oq = value; }
        }
        [DataMember]


        public float OverallCond
        {
            get { return oc; }
            set { oc = value; }
        }
        [DataMember]
        public float YearBuilt
        {
            get { return year; }
            set { year = value; }
        }
        [DataMember]
        public float TotalBsmtSF
        {
            get { return totalbs; }
            set { totalbs = value; }
        }
        [DataMember]
        public bool  CentralAir
        {
            get { return cair; }
            set { cair = value; }
        }
        [DataMember]
        public float FirstFlrSF
        {
            get { return f1; }
            set { f1 = value; }
        }
        [DataMember]
        public float SecondFlrSF
        {
            get { return f2; }
            set { f2 = value; }
        }
        [DataMember]
        public float GrLivArea
        {
            get { return grliv; }
            set { grliv = value; }
        }
        [DataMember]
        public float FullBath
        {
            get { return fullbath; }
            set { fullbath = value; }
        }
        [DataMember]
        public float BedroomAbvGr
        {
            get { return bed; }
            set {bed = value; }
        }
        [DataMember]
        public float KitchenAbvGr
        {
            get { return kitchen; }
            set { kitchen = value; }
        }
        [DataMember]
        public float TotRmsAbvGrd
        {
            get { return abv; }
            set { abv = value; }
        }
        [DataMember]
        public float SellPrice
        {
            get { return price; }
            set { price = value; }
        }
    }
}
