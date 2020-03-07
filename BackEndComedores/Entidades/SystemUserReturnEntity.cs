using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Entidades
{
    public class SystemUserReturnEntity
    {
        public long ID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserType { get; set; }
        public Provider Provider { get; set; }
    }
}