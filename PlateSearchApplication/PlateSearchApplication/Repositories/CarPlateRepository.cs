using PlateSearchApplication.Entities;
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
    }
}
