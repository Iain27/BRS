using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BRS_Prototype.Models;
using BRS_Prototype.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BRS_Prototype.Controllers
{
    public class BloodRedSkiesController : Controller
    {
        private readonly IBloodRedSkiesPlaneRepository _bloodRedSkiesPlaneRepository;
        private readonly INationRepository _nationRepository;

        public BloodRedSkiesController(IBloodRedSkiesPlaneRepository bloodRedSkiesPlaneRepository, INationRepository nationRepository)
        {
            _bloodRedSkiesPlaneRepository = bloodRedSkiesPlaneRepository;
            _nationRepository = nationRepository;  
        }

        public IActionResult List()
        {
            //ViewBag.CountryName = "Britain";
            //return View(_bloodRedSkiesListRepository.AllBloodRedSkiesLists);
            BloodRedSkiesViewModel bloodRedSkiesViewModel = new BloodRedSkiesViewModel
                (_bloodRedSkiesPlaneRepository.AllBloodRedSkiesPlanes, _nationRepository.AllNations
               );
            return View(bloodRedSkiesViewModel);
        }
    }
}

