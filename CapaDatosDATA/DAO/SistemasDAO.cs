using CapaDatosBO;
using CapaDatosDATA.DA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CapaDatosDATA.DAO
{
    public class SistemasDAO
    {

        public List<SistemasBO> cargaSistemas()
        {
            // aquí se establece el dataset que se va a utilizar en la capa de Negocios, desde la base de datos(DA). 

            List<SistemasBO> resultado = new List<SistemasBO>();


            DataSet ds = new DataSet();
            SistemasDA Conexion = new SistemasDA();  
            

            ds=Conexion.obtenerSistemas();
            
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los sistemas
                SistemasBO sistema = new SistemasBO();

                sistema.idSistema = Int32.Parse(r["idSistema"].ToString());
                sistema.NombreSistema = r["Nombre_Sistema"].ToString();
                resultado.Add(sistema);
            }


            return resultado;
        }
    }
}