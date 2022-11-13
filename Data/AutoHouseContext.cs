using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{

    public class AutoHouseContext:DbContext
    {
        public AutoHouseContext(DbContextOptions<AutoHouseContext>options)
            : base(options) { }


        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<CarSpecification> CarSpecifications { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server = TISHO\\SQLEXPRESS; Database = DealerData; Trusted_connection=True;");
        }
    }
}
