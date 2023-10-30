using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrototipoMINVU.Models
{
    public class Usuario
    {        
        [Required]
        public int Rut { get; set; }


        [Required]
        public string Contrasena { get; set; }


        [Required]
        public string ContrasenaNueva { get; set; }



        public string Nombre { get; set; }
        
    }
}