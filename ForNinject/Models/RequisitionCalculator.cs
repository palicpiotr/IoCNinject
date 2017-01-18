using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForNinject.Models
{
    public class RequisitionCalculator
    {
        private ILinqRequisitionCalculator calc;
        public IEnumerable<Requisition> Requisitions { get; set; }

        public RequisitionCalculator(ILinqRequisitionCalculator calcParam)
        {
            this.calc = calcParam;
        }

        public int CalculateRequisitionsByDate()
        {
            return calc.CalculatorRequisitions(Requisitions);
        }
    }
}