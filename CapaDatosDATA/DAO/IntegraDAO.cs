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

                if(estado.id_tipointegracion>0)
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


        public List<IntegraBO> cargaIntegraciones()
        {
            List<IntegraBO> resultado = new List<IntegraBO>();

            DataSet ds = new DataSet();
            IntegraDA Conexion = new IntegraDA();

            ds = Conexion.obtenerIntegraciones();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los proyectos que tiene el sistema MUNIN
                IntegraBO integracion = new IntegraBO();

                integracion.id_integracion = Int32.Parse(r["id_integracion"].ToString());
                integracion.tipo_integracion = r["tipo_integracion"].ToString();

                integracion.nombre_sistema_origen = r["Sistema_Origen"].ToString();

                integracion.nombre_sistema_destino = r["Sistema_Destino"].ToString();
                integracion.nombre_sistema_destino2 = r["Sistema_Destino2"].ToString();

                integracion.nombre_modulo_origen = r["Modulo_Origen"].ToString();
                integracion.nombre_modulo_destino = r["Modulo_Destino"].ToString();
                integracion.nombre_modulo_destino2 = r["Modulo_Destino2"].ToString();


                if(integracion.id_integracion>0)
                    resultado.Add(integracion);
            }
            return resultado;
        }

        public IntegraBO cargaIntegracionby(int integracion)
        {
            IntegraBO resultado = new IntegraBO();

            DataSet ds = new DataSet(); 
            IntegraDA Conexion = new IntegraDA();

            ds = Conexion.obtenerIntegracionby(integracion);

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los proyectos que tiene el sistema MUNIN

                resultado.id_integracion = Int32.Parse(r["id_integracion"].ToString());
                resultado.id_tipointegracion = Int32.Parse(r["id_tipointeg"].ToString());

                resultado.id_sistemaorigen = Int32.Parse(r["Sistema_Origen"].ToString());
                resultado.id_sistemadestino = Int32.Parse(r["Sistema_Destino"].ToString());
                resultado.id_sistemadestino2 = Int32.Parse(r["Sistema_Destino2"].ToString());

                resultado.id_moduloorigen = Int32.Parse(r["Modulo_Origen"].ToString());
                resultado.id_modulodestino = Int32.Parse(r["Modulo_Destino"].ToString());
                resultado.id_modulodestino2 = Int32.Parse(r["Modulo_Destino2"].ToString());

            }
            return resultado;
        }

        public List<IntegraBO> cargaIntegracionesSistemasby(int sistema)
        {
            List<IntegraBO> resultado = new List<IntegraBO>();

            DataSet ds = new DataSet();
            IntegraDA Conexion = new IntegraDA();

            ds = Conexion.obtenerIntegracionesSistemasby(sistema);

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los proyectos que tiene el sistema MUNIN
                IntegraBO integracion = new IntegraBO();

                integracion.id_integracion = Int32.Parse(r["id_integracion"].ToString());
                integracion.tipo_integracion = r["tipo_integracion"].ToString();

                integracion.nombre_sistema_origen = r["Sistema_Origen"].ToString();

                integracion.nombre_sistema_destino = r["Sistema_Destino"].ToString();

                integracion.nombre_modulo_destino = r["Modulo_Destino"].ToString();


                resultado.Add(integracion);
            }
            return resultado;
        }


    }
}