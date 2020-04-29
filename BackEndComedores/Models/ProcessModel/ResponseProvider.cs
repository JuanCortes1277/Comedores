using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Models.ProcessModel
{
    public class ResponseProvider
    {
        public long ID { get; set; }
        public long IDPreOrden { get; set; }
        public bool Response { get; set; }
    }

}