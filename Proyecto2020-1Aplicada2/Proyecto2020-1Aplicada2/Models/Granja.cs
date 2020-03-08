using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_2020_1.Models
{
    public class Granja
    {
        [Key]
        public int MadreId { get; set; }
        public string Raza { get; set; }
        public int Corral { get; set; }

    }
}
