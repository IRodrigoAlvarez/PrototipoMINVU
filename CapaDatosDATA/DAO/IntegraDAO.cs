using CapaDatosBO;
using CapaDatosDATA.DA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CapaDatosDATA.DAO
{
    public class IntegraDAO
    {
        public List<IntegraBO> cargaTipoIntegracion()
        {
            List<IntegraBO> resultado = new List<IntegraBO>();

            DataSet ds = new DataSet();
            IntegraDA Conexion = new IntegraDA();

            ds = Conexion.obtenerTipoIntegracion();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los proyectos que tiene el sistema MUNIN
                IntegraBO estado = new IntegraBO();

                estado.id_tipointegracion = Int32.Parse(r["id_tipointeg"].ToString());
                estado.tipo_integracion = r["tipo_integracion"].ToString();

                resultado.Add(estado);
            }
            return resultado;
        }

        public int obtenerMaxidtablaintegraciones() 
        { 
            int resultado = new int();

            DataSet ds = new DataSet();
            IntegraDA Conexion = new IntegraDA();

            ds = Conexion.MaxIDintegra();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                resultado = Int32.Parse(r["MAX(integraciones.id_integracion)"].ToString());
            }
            return resultado;

        }


    }
}