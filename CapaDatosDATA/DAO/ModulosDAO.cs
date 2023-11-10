using CapaDatosBO;
using CapaDatosDATA.DA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CapaDatosDATA.DAO
{
    public class ModulosDAO
    {
        public List<ModuloBO> cargaModulos()
        {
            // aquí se establece el dataset que se va a utilizar en la capa de Negocios, desde la base de datos(DA). 

            List<ModuloBO> resultado = new List<ModuloBO>();           
            DataSet ds = new DataSet();
            ModulosDA Conexion = new ModulosDA(); 
            
            ds=Conexion.obtenerModulos();
            
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los sistemas
                ModuloBO sistema = new ModuloBO();

                sistema.idSistema = Int32.Parse(r["id_modulo"].ToString());
                sistema.NombreSistema = r["nombre_modulo"].ToString();
                sistema.DescripcionEstado = r["descripcion_estado"].ToString();
                sistema.descripcion = r["descripcion_modulo"].ToString();
                sistema.id_AMBIENTE = Int32.Parse(r["id_ambiente"].ToString());
                sistema.id_estado = Int32.Parse(r["id_estado"].ToString());

                if (sistema.idSistema > 0)
                    resultado.Add(sistema);
            }
            return resultado;
        }
        public List<ModuloBO> cargaModulosby(int ambiente)
        {
            // aquí se establece el dataset que se va a utilizar en la capa de Negocios, desde la base de datos(DA). 

            List<ModuloBO> resultado = new List<ModuloBO>();


            DataSet ds = new DataSet();
            ModulosDA Conexion = new ModulosDA();


            ds = Conexion.ObtenerModulobyAmbiente(ambiente);

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los sistemas
                ModuloBO sistema = new ModuloBO();
                sistema.idSistema = Int32.Parse(r["id_modulo"].ToString());
                sistema.NombreSistema = r["nombre_modulo"].ToString();
                sistema.descripcion = r["descripcion_modulo"].ToString();
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
                estado.idJefeProyecto = Int32.Parse(r["id_jefe"].ToString());
                estado.NombreJefeProyecto = r["nombre_jefe"].ToString();
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
            ModulosDA Conexion = new ModulosDA();

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
            ModulosDA Conexion = new ModulosDA();

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
            ModulosDA Conexion = new ModulosDA();

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
        public List<DataownerBO> cargaDO()
        {
            List<DataownerBO> resultado = new List<DataownerBO>();

            DataSet ds = new DataSet();
            ModulosDA Conexion = new ModulosDA();

            ds = Conexion.obtenerDO();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los proyectos que tiene el sistema MUNIN
                DataownerBO estado = new DataownerBO();

                estado.idDataOwner = Int32.Parse(r["id_dataow"].ToString());
                estado.nombre_data = r["nombre_origen"].ToString();
                resultado.Add(estado);
            }
            return resultado;

        }
        public List<ControlBO> cargaControlAcceso()
        {
            List<ControlBO> resultado = new List<ControlBO>();

            DataSet ds = new DataSet();
            ModulosDA Conexion = new ModulosDA();

            ds = Conexion.obtenerControlAcceso();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los proyectos que tiene el sistema MUNIN
                ControlBO estado = new ControlBO();

                estado.idControlAcceso = Int32.Parse(r["id_control"].ToString());
                estado.TipoControl = r["tipo_control"].ToString();
                resultado.Add(estado);
            }
            return resultado;

        }
        public List<AlcanceBO> cargaAlcance()
        {
            List<AlcanceBO> resultado = new List<AlcanceBO>();

            DataSet ds = new DataSet();
            ModulosDA Conexion = new ModulosDA();

            ds = Conexion.obtenerAlcance();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los proyectos que tiene el sistema MUNIN
                AlcanceBO estado = new AlcanceBO();

                estado.idAlcance = Int32.Parse(r["id_alcance"].ToString());
                estado.DescripcionAlcance = r["descripcion_alcance"].ToString();
                resultado.Add(estado);
            }
            return resultado;

        }
        public List<RegionBO> cargaRegiones()
        {
            List<RegionBO> resultado = new List<RegionBO>();

            DataSet ds = new DataSet();
            ModulosDA Conexion = new ModulosDA();

            ds = Conexion.obtenerRegiones();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los proyectos que tiene el sistema MUNIN
                RegionBO estado = new RegionBO();

                estado.idRegion = Int32.Parse(r["id_region"].ToString());
                estado.NombreRegion = r["nombre_region"].ToString();
                resultado.Add(estado);
            }
            return resultado;

        }
        public List<LegacyBO> cargaLegacy()
        {
            List<LegacyBO> resultado = new List<LegacyBO>();

            DataSet ds = new DataSet();
            ModulosDA Conexion = new ModulosDA();

            ds = Conexion.obtenerLegacy();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los proyectos que tiene el sistema MUNIN
                LegacyBO estado = new LegacyBO();

                estado.idLegacy = Int32.Parse(r["id_legacy"].ToString());
                estado.DescripcionLegacy = r["descripcion_legacy"].ToString();
                resultado.Add(estado);
            }
            return resultado;

        }
        public List<TipoSistemasBO> cargaTiposistemas()
        {
            List<TipoSistemasBO> resultado = new List<TipoSistemasBO>();

            DataSet ds = new DataSet();
            ModulosDA Conexion = new ModulosDA();

            ds = Conexion.obtenerTipoSistemas();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los proyectos que tiene el sistema MUNIN
                TipoSistemasBO estado = new TipoSistemasBO();

                estado.idTipoSistema = Int32.Parse(r["id_tiposistema"].ToString());
                estado.TipoSistema = r["descripcion_tipo"].ToString();
                resultado.Add(estado);
            }
            return resultado;

        }
        public List<TecnologiaBO> cargaTecnologias()
        {
            List<TecnologiaBO> resultado = new List<TecnologiaBO>();

            DataSet ds = new DataSet();
            ModulosDA Conexion = new ModulosDA();

            ds = Conexion.obtenerTecnologias();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los proyectos que tiene el sistema MUNIN
                TecnologiaBO estado = new TecnologiaBO();

                estado.idTecnologia = Int32.Parse(r["id_tecnologia"].ToString());
                estado.TipoTecnologia = r["nombre_tecnologia"].ToString();
                resultado.Add(estado);
            }
            return resultado;

        }
        public ModuloBO TraeModulobyid(int id_sistema) 
        {
            ModuloBO resultado = new ModuloBO();

            DataSet ds = new DataSet();
            ModulosDA Conexion = new ModulosDA();

            ds = Conexion.TraeModulobyid(id_sistema);

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los modulos que tiene el la base de datos

                resultado.idSistema = Int32.Parse(r["id_modulo"].ToString());
                resultado.NombreSistema = r["nombre_modulo"].ToString();
                resultado.id_estado = Int32.Parse(r["id_estado"].ToString());
                resultado.DescripcionEstado = r["descripcion_estado"].ToString();
                resultado.descripcion = r["descripcion_modulo"].ToString();
                resultado.id_AMBIENTE = Int32.Parse(r["id_ambiente"].ToString());
                resultado.AmbienteAlojado = r["nombre_ambiente"].ToString();

            }
            return resultado;
        }
        public int obtenerMaxidtablamodulos() 
        {
            int resultado = new int();

            DataSet ds = new DataSet();
            ModulosDA Conexion = new ModulosDA();

            ds = Conexion.MaxIDmodulos();
            
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                resultado = Int32.Parse(r["MAX(modulos.id_modulo)"].ToString());
            }
            return resultado;

        }



       


      




        
    }
}