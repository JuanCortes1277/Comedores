//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackEndComedores
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transport
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
        public Nullable<long> IDProvider { get; set; }
    }
}
