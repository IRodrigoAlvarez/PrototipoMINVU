using CapaDatosBO;
using CapaDatosDATA.DA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CapaDatosDATA.DAO
{
    public class MuninDAO
    {
        public List<ProyectosBO> cargaProyectos()
        {
            List<ProyectosBO> resultado = new List<ProyectosBO>();
            DataSet ds = new DataSet();
            MuninDA Conexion = new MuninDA();

            ds = Conexion.obtenerProyectos();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los proyectos que tiene el sistema MUNIN
                ProyectosBO sistema = new ProyectosBO();

                sistema.idProyecto = Int32.Parse(r["id_proyecto"].ToString());
                sistema.Nombre_proyecto = r["nombre_proyecto"].ToString();
                sistema.Jefe_proyecto = r["jefe_proyecto"].ToString();
                sistema.id_estado_proyecto = Int32.Parse(r["id_estado_proyecto"].ToString());
                resultado.Add(sistema);
            }
            return resultado;
        }
    }
}