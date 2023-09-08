using CapaDatosBO;
using CapaDatosDATA.DA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CapaDatosDATA.DAO
{
    public class SubSistemaDAO
    {

        public List<SubSistemasBO> cargaSubSistemas()
        {
            // aquí se establece el dataset que se va a utilizar en la capa de Negocios, desde la base de datos(DA). 

            List<SubSistemasBO> resultado = new List<SubSistemasBO>();


            DataSet ds = new DataSet();
            SistemasDA Conexion = new SistemasDA();


            ds = Conexion.obtenerSubSistemas();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los sistemas
                SubSistemasBO sistema = new SubSistemasBO();

                sistema.idSubSistema = Int32.Parse(r["id_subsistema"].ToString());
                sistema.NombreSubSistema = r["nombre_sistema"].ToString();
                resultado.Add(sistema);
            }


            return resultado;





        }
    }
}