using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proyecto2020_1Aplicada2.Models
{
    public class Granja
    {
        [Key]
        public int MadreId { get; set; }
        public string Raza { get; set; }
        public int Corral { get; set; }

        public Granja()
        {
            MadreId = 0;
            Raza = string.Empty;
            Corral = 0;
        }
    }
}

