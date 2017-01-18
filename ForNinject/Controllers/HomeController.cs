using ForNinject.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForNinject.Controllers
{
    public class HomeController : Controller
    {
        private ILinqRequisitionCalculator calc;

        private Requisition[] requisitions =
        {
            new Requisition {RequisitionID = 1, CreationDate = DateTime.Parse("2016/12/12"), RequisitionCount = 12, Status = "Closed" },
            new Requisition {RequisitionID = 1, CreationDate = DateTime.Parse("2016/12/13"), RequisitionCount = 1, Status = "Closed" },
            new Requisition {RequisitionID = 1, CreationDate = DateTime.Parse("2016/12/14"), RequisitionCount = 4, Status = "Closed" },
            new Requisition {RequisitionID = 1, CreationDate = DateTime.Parse("2016/12/14"), RequisitionCount = 6, Status = "Closed" },
            new Requisition {RequisitionID = 1, CreationDate = DateTime.Parse("2016/12/15"), RequisitionCount = 11, Status = "Closed" },
        };

        public HomeController(ILinqRequisitionCalculator calcParam)
        {
            this.calc = calcParam;
        }

        public ActionResult Index()
        {
            RequisitionCalculator reqCalc = new RequisitionCalculator(calc)
            {
                Requisitions = requisitions
            };
            int totalCount = reqCalc.CalculateRequisitionsByDate();
            return View(totalCount);
        }
    }
}