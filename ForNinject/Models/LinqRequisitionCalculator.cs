using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForNinject.Models
{
    public class LinqRequisitionCalculator : ILinqRequisitionCalculator
    {
        public int CalculatorRequisitions(IEnumerable<Requisition> requisitions)
        {
            return requisitions.
                Where(r => r.CreationDate > DateTime.Parse("2016/11/12")).
                Sum(r => r.RequisitionCount);
        }
    }
}