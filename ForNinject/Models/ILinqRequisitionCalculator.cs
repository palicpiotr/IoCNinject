using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForNinject.Models
{
    interface ILinqRequisitionCalculator
    {
        int CalculatorRequisitions(IEnumerable<Requisition> requisitions);
    }
}
