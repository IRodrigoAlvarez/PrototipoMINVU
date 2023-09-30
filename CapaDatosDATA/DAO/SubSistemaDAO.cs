using CapaDatosBO;
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


        public List<SubSistemasBO> EditarSubSistema(int id_sistema, SubSistemasBO SistemaNuevo)
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
                sistema.CostoSistema = Int32.Parse(r["costo_sistema"].ToString());
                sistema.DescripcionSubSistema = r["descripcion_subsistema"].ToString();
                sistema.DecretoAfecto = r["decreto_afecto"].ToString();
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


    }
}