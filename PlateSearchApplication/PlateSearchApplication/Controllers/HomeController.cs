using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlateSearchApplication.Repositories;

namespace PlateSearchApplication.Controllers
{
    public class HomeController : Controller
    {
        CarPlateRepository CarPlateRepository;

        public HomeController(CarPlateRepository carPlateRepository)
        {
            CarPlateRepository = carPlateRepository;
        }

        [Route("/search")]
        [HttpGet]
        public IActionResult Index(string plate)
        {
            return View(CarPlateRepository.SearchPlateList(plate));
        }



        //[Route("/search/{plate}")]
        //[HttpGet]
        //public IActionResult ListByPlate(string plate)
        //{
        //    return Json(CarPlateRepository.SearchPlateList(plate));
        //}


    }
}
