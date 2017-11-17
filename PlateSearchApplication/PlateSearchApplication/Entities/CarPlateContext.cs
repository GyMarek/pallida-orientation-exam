using Microsoft.EntityFrameworkCore;
using PlateSearchApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlateSearchApplication.Entities
{
    public class CarPlateContext : DbContext
    {
        public CarPlateContext(DbContextOptions<CarPlateContext> options) : base(options)
        {

        }

        public DbSet<CarPlate> Licence_plates { get; set; }
    }
}
