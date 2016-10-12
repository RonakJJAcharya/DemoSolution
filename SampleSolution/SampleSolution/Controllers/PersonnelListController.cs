using SampleSolution.Interfaces.Personnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleSolution.Controllers
{
    public class PersonnelListController : Controller
    {
        private readonly IPersonnelRepository _personnelListRepository;
        public PersonnelListController(IPersonnelRepository personnelListRepository)
        {
            _personnelListRepository = personnelListRepository;    
        }

        public ActionResult GetPersonnelList(int? personnelId)
        {
            var _personnelList = _personnelListRepository.GetPersonnelList().Where(x =>x.PersonnelId == personnelId).FirstOrDefault();
            return View("PersonnelList", _personnelList);
        }

    }
}
