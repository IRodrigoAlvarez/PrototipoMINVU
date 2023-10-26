﻿using CapaDatosBO;
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

        public List<SubSistemasBO> cargaSubSistemasbyID(int id_sistema)
        {
            // aquí se establece el dataset que se va a utilizar en la capa de Negocios, desde la base de datos(DA). 
            List<SubSistemasBO> resultado = new List<SubSistemasBO>();

            DataSet ds = new DataSet();
            SubSistemasDA Conexion = new SubSistemasDA();


            ds = Conexion.obtenerSubSistemasbyID(id_sistema);

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los sistemas
                SubSistemasBO sistema = new SubSistemasBO();

                sistema.idSubSistema = Int32.Parse(r["id_subsistema"].ToString());
                sistema.NombreSubSistema = r["nombre_subsistema"].ToString();
                sistema.NombreJefeProyecto = r["nombreJefe"].ToString();
                sistema.EstadoSubSistema = r["descripcion_estado"].ToString();
                resultado.Add(sistema);
            }
            return resultado;
        }

        public List<SubSistemasBO> CargaSubsistemas()
        {
            // aquí se establece el dataset que se va a utilizar en la capa de Negocios, desde la base de datos(DA). 

            List<SubSistemasBO> resultado = new List<SubSistemasBO>();

            DataSet ds = new DataSet();
            SubSistemasDA Conexion = new SubSistemasDA();


            ds = Conexion.obtenerSubSistemas();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los sistemas
                SubSistemasBO sistema = new SubSistemasBO();

                sistema.idSubSistema = Int32.Parse(r["id_sistema"].ToString());
                sistema.NombreSubSistema = r["nombre_subsistema"].ToString();
                sistema.NombreSistemaEnlazado = r["sistema_enlazado"].ToString();
                sistema.EstadoSubSistema = r["estado_sistema"].ToString();

                if (sistema.idSubSistema != 0)
                    resultado.Add(sistema);
            }
            return resultado;
        }

        public SubSistemasBO CaracteristicasSubsistema(int id_subsistema)
        {
            // aquí se establece el dataset que se va a utilizar en la capa de Negocios, desde la base de datos(DA). 

            DataSet ds = new DataSet();


            SubSistemasDA Conexion = new SubSistemasDA();
            SubSistemasBO sistema = new SubSistemasBO();


            ds = Conexion.CaracteristicasSubSistemasbyID(id_subsistema);


            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los sistemas

                sistema.idSubSistema = Int32.Parse(r["id_subsistema"].ToString());
                sistema.NombreSubSistema = r["nombre_subsistema"].ToString();

                sistema.URLinicio = r["URLinicio"].ToString();
                sistema.URLdatos = r["URLdatos"].ToString();
                sistema.CostoSistema = r["costo_sistema"].ToString();
                sistema.DescripcionSubSistema = r["descripcion_subsistema"].ToString();
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

                sistema.id_estado = Int32.Parse(r["id_estados"].ToString());
                sistema.EstadoSubSistema = r["descripcion_estado"].ToString();

                sistema.id_control = Int32.Parse(r["id_control"].ToString());
                sistema.TipoControlAcceso = r["tipo_control"].ToString();

                sistema.id_jefeproyecto = Int32.Parse(r["id_jefeproyecto"].ToString());
                sistema.NombreJefeProyecto = r["nombreJefe"].ToString();

                sistema.id_legacy = Int32.Parse(r["id_legacy"].ToString());
                sistema.TipoLegacy = r["descripcion_legacy"].ToString();

                sistema.id_alcance = Int32.Parse(r["id_alcance"].ToString());
                sistema.TipoAlcance = r["descripcion_alcance"].ToString();



            }



            return sistema;
        }


        public int obtenerMaxidtablasubsistemas()
        {
            int resultado = new int();

            DataSet ds = new DataSet();
            SubSistemasDA Conexion = new SubSistemasDA();

            ds = Conexion.MaxIDsubsistemas();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                resultado = Int32.Parse(r["MAX(sub_sistemas.id_subsistema)"].ToString());
            }
            return resultado;

        }





        public List<ReporteGeneralBO> cargaReporteINTEEX()
        {
            List<ReporteGeneralBO> resultado = new List<ReporteGeneralBO>();

            DataSet ds = new DataSet();
            SubSistemasDA Conexion = new SubSistemasDA();

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
            SubSistemasDA Conexion = new SubSistemasDA();

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
            SubSistemasDA Conexion = new SubSistemasDA();

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

    }

}