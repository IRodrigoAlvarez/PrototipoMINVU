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
        public List<string> cargaSistemas()
        {
            // aquí se establece el dataset que se va a utilizar en la capa de Negocios, desde la base de datos(DA). 


            SistemasDA Conexion = new SistemasDA();
            DataSet dsUsuario = Conexion.obtenerSistemas();
            List<string> aux = new List<string>();

            SistemasBO resultado = new SistemasBO();


            foreach (DataRow r in dsUsuario.Tables[0].Rows)
            {
                //Se llena la lista con los sistemas
                resultado.idSistema = Int32.Parse(r["idSistema"].ToString());
                resultado.NombreSistema = r["Nombre_Sistema"].ToString();
                aux.Add(resultado.NombreSistema);
                
            }

            resultado.ListaSistemas = aux;

            return resultado.ListaSistemas;
        }
    }
}