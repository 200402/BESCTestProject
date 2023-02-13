using DataBase.Tables;
using DataBase.Tables.TypeConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder Builder)
        {
            Builder.ApplyConfiguration(new BrandConfiguration());
            Builder.ApplyConfiguration(new CarModelConfiguration());
            base.OnModelCreating(Builder);
        }
    }
}
