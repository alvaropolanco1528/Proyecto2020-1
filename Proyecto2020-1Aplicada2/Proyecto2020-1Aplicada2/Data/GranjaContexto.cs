using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Proyecto2020_1Aplicada2.Models;



namespace Proyecto2020_1Aplicada2.Data
{
    public class GranjaContexto : DbContext
    {
        public DbSet<Granja> granjas { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=DataBase/Data.db");
        }
    }
}
