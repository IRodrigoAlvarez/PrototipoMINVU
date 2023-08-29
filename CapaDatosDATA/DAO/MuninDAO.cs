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


        public List<AccionBO> cargaAcciones()
        {
            List<AccionBO> resultado = new List<AccionBO>();

            AccionBO opcion_acion = new AccionBO();

            opcion_acion.idAccion = 1;
            opcion_acion.DescripcionAccion = "Agregar Proyecto";

            resultado.Add(opcion_acion);

            opcion_acion = new AccionBO();


            opcion_acion.idAccion = 2;
            opcion_acion.DescripcionAccion = "Modificar Proyecto";

            resultado.Add(opcion_acion);


            opcion_acion = new AccionBO();

            opcion_acion.idAccion = 3;
            opcion_acion.DescripcionAccion = "Eliminar Proyecto";
            resultado.Add(opcion_acion);

            return resultado;
        }

        public List<EstadosBO> cargaEstados()
        {
            List<EstadosBO> resultado = new List<EstadosBO>();

            DataSet ds = new DataSet();
            MuninDA Conexion = new MuninDA();

            ds = Conexion.obtenerEstados();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los proyectos que tiene el sistema MUNIN
                EstadosBO estado = new EstadosBO();

                estado.idEstado = Int32.Parse(r["id_estado"].ToString());
                estado.DescripcionEstado = r["descripcion_estado"].ToString();
               
                resultado.Add(estado);
            }




            return resultado;
        }
    }
}