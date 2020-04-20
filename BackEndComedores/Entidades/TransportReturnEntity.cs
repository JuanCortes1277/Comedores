using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Entidades
{
    public class TransportReturnEntity
    {
        public long ID { get; set; }
        public string Code { get; set; }
        public string CarPlate { get; set; }
        public string Brand { get; set; }
        public Nullable<int> Year { get; set; }
        public string PersonInCharge { get; set; }
        public Nullable<long> PhonePersonInCharge { get; set; }
        public string MailPersonInCharge { get; set; }
        public Nullable<decimal> PaymentValue { get; set; }
        public Nullable<bool> Availability { get; set; }
        public Nullable<int> TransportType { get; set; }
        public Nullable<int> PaymentUnity { get; set; }
        public Nullable<int> PaymentMeasurement { get; set; }
        public Provider IDProvider { get; set; }
        //
    }
}