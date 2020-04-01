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

        // TODO: Add your service operations here
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
