using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlateSearchApplication.Repositories;
using PlateSearchApplication.Models;

namespace PlateSearchApplication.Controllers
{
    public class HomeController : Controller
    {
        CarPlateRepository CarPlateRepository;
        CarPlate CarPlate;

        public HomeController(CarPlateRepository carPlateRepository, CarPlate carPlate)
        {
            CarPlateRepository = carPlateRepository;
            CarPlate = carPlate;
        }

        [Route("/search")]
        [HttpGet]
        public IActionResult Index(string plate)
        {
            return View(CarPlateRepository.SearchPlateList(plate));
        }

        [Route("/{what}")]
        [HttpGet]
        public IActionResult Index(string what, int temp)
        {
            if (what == "police")
            {
                return View(CarPlateRepository.ListPolice());
            }
            if (what == "diplomats")
            {
                return View(CarPlateRepository.ListDiplomats());
            }
            return NotFound();
        }

        [Route("/{brand}")]
        [HttpGet]
        public IActionResult Index(string brand, [FromBody] CarPlate plate)
        {
            return View(CarPlateRepository.SearchPlateList(brand));
        }
    }
}
