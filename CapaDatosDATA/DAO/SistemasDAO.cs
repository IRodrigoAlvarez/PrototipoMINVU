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

                sistema.idSistema = Int32.Parse(r["id_sistema"].ToString());
                sistema.NombreSistema = r["nombre_sistema"].ToString();
                sistema.descripcion = r["descripcion"].ToString();
                sistema.id_AMBIENTE = Int32.Parse(r["id_ambiente"].ToString());
                resultado.Add(sistema);
            }


            return resultado;
        }


        public List<SistemasBO> cargaSistemasby(int ambiente)
        {
            // aquí se establece el dataset que se va a utilizar en la capa de Negocios, desde la base de datos(DA). 

            List<SistemasBO> resultado = new List<SistemasBO>();


            DataSet ds = new DataSet();
            SistemasDA Conexion = new SistemasDA();


            ds = Conexion.ObtenerSistemasbyAmbiente(ambiente);

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los sistemas
                SistemasBO sistema = new SistemasBO();

                sistema.idSistema = Int32.Parse(r["id_sistema"].ToString());
                sistema.NombreSistema = r["nombre_sistema"].ToString();
                sistema.descripcion = r["descripcion"].ToString();
                sistema.id_AMBIENTE = Int32.Parse(r["id_ambiente"].ToString());
                resultado.Add(sistema);
            }


            return resultado;
        }














        public List<JefesBO> cargaJefesproyectos()
        {

            List<JefesBO> resultado = new List<JefesBO>();

            DataSet ds = new DataSet();
            JefesDA Conexion = new JefesDA();

            ds = Conexion.obtenerJefes();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los jefes de proyectos que Existen en la bddd
                JefesBO estado = new JefesBO();
                estado.idJefeProyecto = Int32.Parse(r["idJefe"].ToString());
                estado.NombreJefeProyecto = r["nombreJefe"].ToString();
                estado.RUT = Int32.Parse(r["rut"].ToString());
                estado.Titulo = r["titulo"].ToString();
                estado.Experiencia = r["experiencia"].ToString();
                estado.Descripcion = r["descripcion"].ToString();

                resultado.Add(estado);
            }
            return resultado;

        }


        public List<EstadosBO> cargaEstados()
        {
            List<EstadosBO> resultado = new List<EstadosBO>();

            DataSet ds = new DataSet();
            SistemasDA Conexion = new SistemasDA();

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


        public List<AmbienteBO> cargaAmbientes()
        {
            List<AmbienteBO> resultado = new List<AmbienteBO>();

            DataSet ds = new DataSet();
            SistemasDA Conexion = new SistemasDA();

            ds = Conexion.obtenerAmbientes();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los proyectos que tiene el sistema MUNIN
                AmbienteBO estado = new AmbienteBO();

                estado.idAmbiente = Int32.Parse(r["id_ambiente"].ToString());
                estado.DescripcionAmbiente = r["nombre_ambiente"].ToString();

                resultado.Add(estado);
            }
            return resultado;
        }

        public List<AreasBO> cargaAreas()
        {
            List<AreasBO> resultado = new List<AreasBO>();

            DataSet ds = new DataSet();
            SistemasDA Conexion = new SistemasDA();

            ds = Conexion.obtenerAreas();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los proyectos que tiene el sistema MUNIN
                AreasBO estado = new AreasBO();

                estado.idArea = Int32.Parse(r["id_area"].ToString());
                estado.DescripcionArea = r["nombre_area"].ToString();

                resultado.Add(estado);
            }
            return resultado;
        }


    }
}