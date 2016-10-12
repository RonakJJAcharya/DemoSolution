using SampleSolution.Interfaces.TrainSolution;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleSolution.Controllers
{
    public class TrainSolutionController : Controller
    {
        private readonly ITest _test;
        private readonly IDataReaderRepository _dataReaderRepository;

        public TrainSolutionController(ITest test)
        {
            _test = test;
           

        }

        public ActionResult getSolution()
        {
            string filePath = Server.MapPath("~/Content/SampleData.txt");
            
            //int test = _test.getVal();
            //ViewData["test"] = test;
            return View("TrainSolution");
        }
    }
}
