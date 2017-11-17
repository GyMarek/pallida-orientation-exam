using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PlateSearchApplication.Entities;

namespace PlateSearchApplication.Migrations
{
    [DbContext(typeof(CarPlateContext))]
    [Migration("20171117085857_plateSearch")]
    partial class plateSearch
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PlateSearchApplication.Models.CarPlate", b =>
                {
                    b.Property<int>("PlateId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Car_brand");

                    b.Property<string>("Car_model");

                    b.Property<string>("Color");

                    b.Property<string>("Plate");

                    b.Property<int>("Year");

                    b.HasKey("PlateId");

                    b.ToTable("Licence_plates");
                });
        }
    }
}
