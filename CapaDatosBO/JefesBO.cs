using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosBO
{
    public class JefesBO
    {

        public int idJefeProyecto { get; set; }
        public string NombreJefeProyecto { get; set; }

        public int RUT { get; set; }

        public string DV { get; set; }

        public string Titulo { get; set; }
        public string Experiencia { get; set; }

        public string Descripcion { get; set; }

        public List<SubSistemasBO> ListaJefesProyectos { get; set; }

    }
}