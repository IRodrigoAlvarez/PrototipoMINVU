using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosBO
{
    public class DataownerBO
    {
        public int idDataOwner { get; set; }
        public String nombre_data { get; set; }
        public List<DataownerBO> ListaDataOwners { get; set; }
    }
}