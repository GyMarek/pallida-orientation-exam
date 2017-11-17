using PlateSearchApplication.Entities;
using PlateSearchApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlateSearchApplication.Repositories
{
    public class CarPlateRepository
    {
        private CarPlateContext CarPlateContext;

        public CarPlateRepository(CarPlateContext carPlateContext)
        {
            CarPlateContext = carPlateContext;
        }

        public List<CarPlate> SearchPlateList(string plate)
        {
            var searchedPlate = from searchPlate in CarPlateContext.Licence_plates
                                where searchPlate.Plate.Contains(plate)
                                select searchPlate;

            return searchedPlate.ToList();
        }
    }
}
