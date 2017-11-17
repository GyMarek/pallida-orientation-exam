using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlateSearchApplication.Repositories;
using PlateSearchApplication.Models;

namespace PlateSearchApplication.Controllers
{
    public class RESTController : Controller
    {
        CarPlateRepository CarPlateRepository;
        CarPlate CarPlate;

        public RESTController(CarPlateRepository carPlateRepository, CarPlate carPlate)
        {
            CarPlateRepository = carPlateRepository;
            CarPlate = carPlate;
        }

        [Route("api/search/{brand}")]
        [HttpGet]
        public IActionResult ListByPlate(string brand)
        {
            return Json(CarPlateRepository.SearchBrandList(brand));
        }
    }
}
