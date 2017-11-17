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

        public List<CarPlate> ListPolice()
        {
            var searchedPolice = from searchPlate in CarPlateContext.Licence_plates
                                where searchPlate.Plate.Contains("RB")
                                select searchPlate;

            return searchedPolice.ToList();
        }

        public List<CarPlate> ListDiplomats()
        {
            var searchedDiplomats = from searchPlate in CarPlateContext.Licence_plates
                                 where searchPlate.Plate.Contains("DT")
                                 select searchPlate;

            return searchedDiplomats.ToList();
        }

        public List<CarPlate> SearchBrandList(string brand)
        {
            var searchedBrand = from searchBrand in CarPlateContext.Licence_plates
                                where searchBrand.Car_brand == brand
                                select searchBrand;

            return searchedBrand.ToList();
        }
    }
}
