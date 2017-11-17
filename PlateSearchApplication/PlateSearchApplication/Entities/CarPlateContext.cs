using Microsoft.EntityFrameworkCore;
using PlateSearchApplication.Models;

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
