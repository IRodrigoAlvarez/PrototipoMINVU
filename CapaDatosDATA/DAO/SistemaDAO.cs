using CapaDatosBO;
using CapaDatosDATA.DA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CapaDatosDATA.DAO
{
    public class SistemaDAO
    {

        public List<SistemasBO> cargaSistemasbyID(int id_sistema)
        {
            // aquí se establece el dataset que se va a utilizar en la capa de Negocios, desde la base de datos(DA). 
            List<SistemasBO> resultado = new List<SistemasBO>();

            DataSet ds = new DataSet();
            SistemasDA Conexion = new SistemasDA();


            ds = Conexion.obtenerSistemasbyID(id_sistema);

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los sistemas
                SistemasBO sistema = new SistemasBO();

                sistema.id_sistema = Int32.Parse(r["id_sistema"].ToString());
                sistema.NombreSistema = r["nombre_sistema"].ToString();
                sistema.NombreJefeProyecto = r["nombre_jefe"].ToString();
                sistema.EstadoSistema = r["descripcion_estado"].ToString();
                resultado.Add(sistema);
            }
            return resultado;
        }

        public List<SistemasBO> CargaSistemas()
        {
            // aquí se establece el dataset que se va a utilizar en la capa de Negocios, desde la base de datos(DA). 

            List<SistemasBO> resultado = new List<SistemasBO>();

            DataSet ds = new DataSet();
            SistemasDA Conexion = new SistemasDA();


            ds = Conexion.obtenerSistemas();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los sistemas
                SistemasBO sistema = new SistemasBO();

                sistema.id_sistema = Int32.Parse(r["id_sistema"].ToString());
                sistema.NombreSistema = r["nombre_sistema"].ToString();

                if (sistema.id_sistema != 0)
                    resultado.Add(sistema);
            }
            return resultado;
        }

        public SistemasBO CaracteristicasSistema(int id_sistema)
        {
            // aquí se establece el dataset que se va a utilizar en la capa de Negocios, desde la base de datos(DA). 

            DataSet ds = new DataSet();


            SistemasDA Conexion = new SistemasDA();
            SistemasBO sistema = new SistemasBO();


            ds = Conexion.CaracteristicasSistemasbyID(id_sistema);


            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los sistemas

                sistema.id_sistema = Int32.Parse(r["id_sistema"].ToString());
                sistema.NombreSistema = r["nombre_sistema"].ToString();

                sistema.URLinicio = r["URLinicio"].ToString();
                sistema.URLdatos = r["URLdatos"].ToString();
                sistema.CostoSistema = r["costo_sistema"].ToString();
                sistema.DescripcionSistema = r["descripcion_sistema"].ToString();
                sistema.DecretoAfecto = r["decreto_afecto"].ToString();

                sistema.idAmbiente = Int32.Parse(r["id_ambiente"].ToString());
                sistema.AmbienteAlojado = r["nombre_ambiente"].ToString();


                sistema.id_area = Int32.Parse(r["id_area"].ToString());
                sistema.TipoArea = r["nombre_area"].ToString();

                sistema.id_dataowner = Int32.Parse(r["id_data"].ToString());
                sistema.DueñoDatos = r["nombre_origen"].ToString();

                sistema.id_tipotecnologia = Int32.Parse(r["id_tecnologia"].ToString());

                sistema.TipoTecnologia = r["nombre_tecnologia"].ToString();

                sistema.id_tiposistema = Int32.Parse(r["id_tiposistema"].ToString());
                sistema.TipoSistema = r["descripcion_tipo"].ToString();

                sistema.id_region = Int32.Parse(r["id_region"].ToString());
                sistema.Region = r["nombre_region"].ToString();

                sistema.id_estado = Int32.Parse(r["id_estado"].ToString());
                sistema.EstadoSistema = r["descripcion_estado"].ToString();

                sistema.id_control = Int32.Parse(r["id_control"].ToString());
                sistema.TipoControlAcceso = r["tipo_control"].ToString();

                sistema.id_jefeproyecto = Int32.Parse(r["id_jefeproyecto"].ToString());
                sistema.NombreJefeProyecto = r["nombre_jefe"].ToString();

                sistema.id_legacy = Int32.Parse(r["id_legacy"].ToString());
                sistema.TipoLegacy = r["descripcion_legacy"].ToString();

                sistema.id_alcance = Int32.Parse(r["id_alcance"].ToString());
                sistema.TipoAlcance = r["descripcion_alcance"].ToString();



            }



            return sistema;
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


        public List<ReporteGeneralBO> cargaSUBSISTEMAXVARIABLE(string control_select)
        {

            List<ReporteGeneralBO> resultado = new List<ReporteGeneralBO>();

            DataSet ds = new DataSet();
            SistemasDA Conexion = new SistemasDA();

            ds = Conexion.obtenerReporteSUBSISTEMAXVARIABLE(control_select);

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                ReporteGeneralBO estado = new ReporteGeneralBO();

                estado.idReporte = Int32.Parse(r["idY"].ToString());
                estado.LabelEjeX = r["etiquetaX"].ToString();

                estado.IdEjeY = Int32.Parse(r["idX"].ToString());
                estado.LabelEjeY = r["etiquetaY"].ToString();



                resultado.Add(estado);
            }
            return resultado;




        }



        public List<ReporteGeneralBO> cargaSISTEMAXVARIABLE(string control_select)
        {
            List<ReporteGeneralBO> resultado = new List<ReporteGeneralBO>();

            DataSet ds = new DataSet();
            SistemasDA Conexion = new SistemasDA();

            ds = Conexion.obtenerReporteSISTEMAXVARIABLE(control_select);

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                ReporteGeneralBO estado = new ReporteGeneralBO();

                estado.idReporte = Int32.Parse(r["idY"].ToString());
                estado.LabelEjeX = r["etiquetaX"].ToString();

                estado.IdEjeY = Int32.Parse(r["idX"].ToString());
                estado.LabelEjeY = r["etiquetaY"].ToString();



                resultado.Add(estado);
            }
            return resultado;

        }


    }

}