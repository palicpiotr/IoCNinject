using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForNinject.Models
{
    public class Requisition
    {
        public int RequisitionID { get; set; }
        public DateTime CreationDate { get; set; }
        public string Status { get; set; }
        public int RequisitionCount { get; set; }
    }
}