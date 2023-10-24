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

                if(sistema.idSistema > 0)
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


            ds = Conexion.ObtenerSistemabyAmbiente(ambiente);

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
        public List<DataownerBO> cargaDO()
        {
            List<DataownerBO> resultado = new List<DataownerBO>();

            DataSet ds = new DataSet();
            SistemasDA Conexion = new SistemasDA();

            ds = Conexion.obtenerDO();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los proyectos que tiene el sistema MUNIN
                DataownerBO estado = new DataownerBO();

                estado.idDataOwner = Int32.Parse(r["id_codigo"].ToString());
                estado.nombre_data = r["nombre_origen"].ToString();
                resultado.Add(estado);
            }
            return resultado;

        }
        public List<ControlBO> cargaControlAcceso()
        {
            List<ControlBO> resultado = new List<ControlBO>();

            DataSet ds = new DataSet();
            SistemasDA Conexion = new SistemasDA();

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
            SistemasDA Conexion = new SistemasDA();

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
            SistemasDA Conexion = new SistemasDA();

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
            SistemasDA Conexion = new SistemasDA();

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
            SistemasDA Conexion = new SistemasDA();

            ds = Conexion.obtenerTipoSistemas();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los proyectos que tiene el sistema MUNIN
                TipoSistemasBO estado = new TipoSistemasBO();

                estado.idTipoSistema = Int32.Parse(r["id_tiposi"].ToString());
                estado.TipoSistema = r["descripcion_tipo"].ToString();
                resultado.Add(estado);
            }
            return resultado;

        }
        public List<TecnologiaBO> cargaTecnologias()
        {
            List<TecnologiaBO> resultado = new List<TecnologiaBO>();

            DataSet ds = new DataSet();
            SistemasDA Conexion = new SistemasDA();

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
        public SistemasBO TraeSistemabyid(int id_sistema) 
        {
            SistemasBO resultado = new SistemasBO();

            DataSet ds = new DataSet();
            SistemasDA Conexion = new SistemasDA();

            ds = Conexion.TraeSistemabyid(id_sistema);

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los proyectos que tiene el sistema MUNIN

                resultado.idSistema = Int32.Parse(r["id_sistema"].ToString());
                resultado.NombreSistema = r["nombre_sistema"].ToString();

                resultado.descripcion = r["descripcion"].ToString();
                resultado.id_AMBIENTE = Int32.Parse(r["id_ambiente"].ToString());
                resultado.AmbienteAlojado = r["nombre_ambiente"].ToString();

            }
            return resultado;
        }
        public int obtenerMaxidtablasistemas() 
        {
            int resultado = new int();

            DataSet ds = new DataSet();
            SistemasDA Conexion = new SistemasDA();

            ds = Conexion.MaxIDsistemas();
            
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                resultado = Int32.Parse(r["MAX(sistemas.id_sistema)"].ToString());
            }
            return resultado;

        }



        public List<ReporteGeneralBO> cargaReporteINTEEX() 
        {
            List<ReporteGeneralBO> resultado = new List<ReporteGeneralBO>();

            DataSet ds = new DataSet();
            SistemasDA Conexion = new SistemasDA();

            ds = Conexion.obtenerReporteINTEGRACIONES();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                ReporteGeneralBO estado = new ReporteGeneralBO();

                estado.idReporte = Int32.Parse(r["id_integracion"].ToString());
                estado.LabelEjeX = r["nombre_subsistema"].ToString();

                estado.IdEjeY = Int32.Parse(r["id_entidad_ext"].ToString());

                estado.LabelEjeY = r["entidad_externa"].ToString();


                resultado.Add(estado);
            }
            return resultado;

        }


        public List<ReporteGeneralBO> cargaReporteINTEIN()
        {
            List<ReporteGeneralBO> resultado = new List<ReporteGeneralBO>();

            DataSet ds = new DataSet();
            SistemasDA Conexion = new SistemasDA();

            ds = Conexion.obtenerReporteINTEGRACIONES();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                ReporteGeneralBO estado = new ReporteGeneralBO();

                estado.idReporte = Int32.Parse(r["id_integracion"].ToString());
                estado.LabelEjeX = r["nombre_subsistema"].ToString();

                estado.IdEjeY = Int32.Parse(r["id_entidad_int"].ToString());

                estado.LabelEjeY = r["entidad_interna"].ToString();


                resultado.Add(estado);
            }
            return resultado;

        }



    }
}