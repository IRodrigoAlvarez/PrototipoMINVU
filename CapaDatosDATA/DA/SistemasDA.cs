using CapaDatosBO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CapaDatosDATA.DA
{
    public class SistemasDA
    {
        public DataSet obtenerSistemabyID(int sistema)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlConnection conex = new MySqlConnection();
                string servidor = "localhost";
                string bd = "prototipominvu";
                string usuario = "root";
                string password = "";
                string puerto = "3306";
                string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" 
                    + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
                conex.ConnectionString = cadenaConexion;
                conex.Open();

                string sp_validausuario = "PSM_CARGASISTEMASby";
                MySqlCommand comando = new MySqlCommand(sp_validausuario, conex);
                comando.CommandType = CommandType.StoredProcedure;  // Especifica que es un procedimiento almacenado.

                // Crea el parámetro y lo agrega al comando.
                MySqlParameter paramSistema = new MySqlParameter("@idsistema", MySqlDbType.Int32);
                paramSistema.Value = sistema;
                comando.Parameters.Add(paramSistema);

                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de datos: " + ex.Message, ex);
            }
            return ds;
        }

        public DataSet obtenerSistemas()
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlConnection conex = new MySqlConnection();
                string servidor = "localhost";
                string bd = "prototipominvu";
                string usuario = "root";
                string password = "";
                string puerto = "3306";
                string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";"
                    + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
                conex.ConnectionString = cadenaConexion;
                conex.Open();

                string sp_validausuario = "PSM_SISTEMAS";
                MySqlCommand comando = new MySqlCommand(sp_validausuario, conex);
                comando.CommandType = CommandType.StoredProcedure;  // Especifica que es un procedimiento almacenado.

                // Crea el parámetro y lo agrega al comando.
                

                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(ds);

            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de datos: " + ex.Message, ex);
            }
            return ds;
        }

        public DataSet CaracteristicasSistemasbyID(int sistema)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlConnection conex = new MySqlConnection();
                string servidor = "localhost";
                string bd = "prototipominvu";
                string usuario = "root";
                string password = "";
                string puerto = "3306";
                string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
                conex.ConnectionString = cadenaConexion;
                conex.Open();

                string sp_validausuario = "PSM_FRMEDITSISTEMA";
                MySqlCommand comando = new MySqlCommand(sp_validausuario, conex);
                comando.CommandType = CommandType.StoredProcedure;  // Especifica que es un procedimiento almacenado.

                // Crea el parámetro y lo agrega al comando.
                MySqlParameter paramSistema = new MySqlParameter("@idsistema", MySqlDbType.Int32);
                paramSistema.Value = sistema;
                comando.Parameters.Add(paramSistema);

                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de datos: " + ex.Message, ex);
            }
            return ds;
        }

        public void EditarSistema(int idsistema, SistemasBO SistemaNuevo)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlConnection conex = new MySqlConnection();
                string servidor = "localhost";
                string bd = "prototipominvu";
                string usuario = "root";
                string password = "";
                string puerto = "3306";
                string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
                conex.ConnectionString = cadenaConexion;
                conex.Open();

                string sp_validausuario = "PSM_EDITARSISTEMA";
                MySqlCommand comando = new MySqlCommand(sp_validausuario, conex);
                comando.CommandType = CommandType.StoredProcedure;  // Especifica que es un procedimiento almacenado.

                // Crea el parámetro y lo agrega al comando.


                MySqlParameter id_sistema = new MySqlParameter("@idsistemanuevo", MySqlDbType.Int32);
                id_sistema.Value = idsistema;
                comando.Parameters.Add(id_sistema);

                MySqlParameter nombreSistema = new MySqlParameter("@nombresistema", MySqlDbType.VarChar);
                nombreSistema.Value = SistemaNuevo.NombreSistema;
                comando.Parameters.Add(nombreSistema);

                MySqlParameter descripcion = new MySqlParameter("@descripcion", MySqlDbType.VarChar);
                descripcion.Value = SistemaNuevo.DescripcionSistema;
                comando.Parameters.Add(descripcion);

                MySqlParameter URLinicio = new MySqlParameter("@URLinicio", MySqlDbType.VarChar);
                URLinicio.Value = SistemaNuevo.URLinicio;
                comando.Parameters.Add(URLinicio);

                MySqlParameter URLdata = new MySqlParameter("@URLdatos", MySqlDbType.VarChar);
                URLdata.Value = SistemaNuevo.URLdatos;
                comando.Parameters.Add(URLdata);

                MySqlParameter DecretoAfecto = new MySqlParameter("@decretoafecto", MySqlDbType.VarChar);
                DecretoAfecto.Value = SistemaNuevo.DecretoAfecto;
                comando.Parameters.Add(DecretoAfecto);

                MySqlParameter CostoSistema = new MySqlParameter("@costosistema", MySqlDbType.Int32);
                CostoSistema.Value = SistemaNuevo.CostoSistema;
                comando.Parameters.Add(CostoSistema);

                MySqlParameter iddata = new MySqlParameter("@iddataow", MySqlDbType.Int32);
                iddata.Value = SistemaNuevo.id_dataowner;
                comando.Parameters.Add(iddata);

                MySqlParameter idjefeproyecto = new MySqlParameter("@idjefep", MySqlDbType.Int32);
                idjefeproyecto.Value = SistemaNuevo.id_jefeproyecto;
                comando.Parameters.Add(idjefeproyecto);

                MySqlParameter idtipocontrol = new MySqlParameter("@idcontrol", MySqlDbType.Int32);
                idtipocontrol.Value = SistemaNuevo.id_control;
                comando.Parameters.Add(idtipocontrol);

                MySqlParameter idalcance = new MySqlParameter("@idalcance", MySqlDbType.Int32);
                idalcance.Value = SistemaNuevo.id_alcance;
                comando.Parameters.Add(idalcance);

                MySqlParameter idtiposistema = new MySqlParameter("@idtiposistema", MySqlDbType.Int32);
                idtiposistema.Value = SistemaNuevo.id_tiposistema;
                comando.Parameters.Add(idtiposistema);

                MySqlParameter idtecnologia = new MySqlParameter("@idtecnologia", MySqlDbType.Int32);
                idtecnologia.Value = SistemaNuevo.id_tipotecnologia;
                comando.Parameters.Add(idtecnologia);

                MySqlParameter idlegacy = new MySqlParameter("@idlegacy", MySqlDbType.Int32);
                idlegacy.Value = SistemaNuevo.id_legacy;
                comando.Parameters.Add(idlegacy);

                MySqlParameter idregion = new MySqlParameter("@idregion", MySqlDbType.Int32);
                idregion.Value = SistemaNuevo.id_region;
                comando.Parameters.Add(idregion);

                MySqlParameter idestado = new MySqlParameter("@idestado", MySqlDbType.Int32);
                idestado.Value = SistemaNuevo.id_estado;
                comando.Parameters.Add(idestado);


                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de datos: " + ex.Message, ex);
            }
        }

        public void agregasistema(SistemasBO sistema)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlConnection conex = new MySqlConnection();
                string servidor = "localhost";
                string bd = "prototipominvu";
                string usuario = "root";
                string password = "";
                string puerto = "3306";
                string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
                conex.ConnectionString = cadenaConexion;
                conex.Open();

                string sp_validausuario = "PSM_AGREGASISTEMA";
                MySqlCommand comando = new MySqlCommand(sp_validausuario, conex);
                comando.CommandType = CommandType.StoredProcedure;  // Especifica que es un procedimiento almacenado.

                // Crea el parámetro y lo agrega al comando.

                MySqlParameter idSistema = new MySqlParameter("@id_sistema", MySqlDbType.Int32);
                idSistema.Value = sistema.id_sistema;
                comando.Parameters.Add(idSistema);

                MySqlParameter nombre_sistema = new MySqlParameter("@nombresi", MySqlDbType.VarChar);
                nombre_sistema.Value = sistema.NombreSistema;
                comando.Parameters.Add(nombre_sistema);

                MySqlParameter descripcion_sistema = new MySqlParameter("@descripcionsi", MySqlDbType.VarChar);
                descripcion_sistema.Value = sistema.DescripcionSistema;
                comando.Parameters.Add(descripcion_sistema);

                MySqlParameter idambiente = new MySqlParameter("@idambiente", MySqlDbType.Int32);
                idambiente.Value = sistema.idAmbiente;
                comando.Parameters.Add(idambiente);

                MySqlParameter idestados = new MySqlParameter("@idestado", MySqlDbType.Int32);
                idestados.Value = sistema.id_estado;
                comando.Parameters.Add(idestados);


                MySqlParameter fechadesarrollo = new MySqlParameter("@fechades", MySqlDbType.DateTime);
                fechadesarrollo.Value = "1997/12/12";
                comando.Parameters.Add(fechadesarrollo);

                MySqlParameter URLinicio = new MySqlParameter("@urlinicio", MySqlDbType.VarChar);
                URLinicio.Value = sistema.URLinicio;
                comando.Parameters.Add(URLinicio);

                MySqlParameter URLdatos = new MySqlParameter("@urldatos", MySqlDbType.VarChar);
                URLdatos.Value = sistema.URLdatos;
                comando.Parameters.Add(URLdatos);

                MySqlParameter costosistema = new MySqlParameter("@costosistema", MySqlDbType.Int32);
                costosistema.Value = sistema.CostoSistema;
                comando.Parameters.Add(costosistema);

                

                MySqlParameter decretoafecto = new MySqlParameter("@decretoafecto", MySqlDbType.VarChar);
                decretoafecto.Value = sistema.DecretoAfecto;
                comando.Parameters.Add(decretoafecto);

                MySqlParameter idarea = new MySqlParameter("@idarea", MySqlDbType.Int32);
                idarea.Value = sistema.id_area;
                comando.Parameters.Add(idarea);

                MySqlParameter iddata = new MySqlParameter("@iddata", MySqlDbType.Int32);
                iddata.Value = sistema.id_dataowner;
                comando.Parameters.Add(iddata);

                MySqlParameter idtecnologia = new MySqlParameter("@idtecnologia", MySqlDbType.Int32);
                idtecnologia.Value = sistema.id_tipotecnologia;
                comando.Parameters.Add(idtecnologia);

                MySqlParameter idtiposistema = new MySqlParameter("@idtiposi", MySqlDbType.Int32);
                idtiposistema.Value = sistema.id_tiposistema;
                comando.Parameters.Add(idtiposistema);

                MySqlParameter idregion = new MySqlParameter("@idregion", MySqlDbType.Int32);
                idregion.Value = sistema.id_region;
                comando.Parameters.Add(idregion);

               


                MySqlParameter idjefeproyecto = new MySqlParameter("@idjefeproyecto", MySqlDbType.Int32);
                idjefeproyecto.Value = sistema.id_jefeproyecto;
                comando.Parameters.Add(idjefeproyecto);

                MySqlParameter idcontrol = new MySqlParameter("@idcontrol", MySqlDbType.Int32);
                idcontrol.Value = sistema.id_control;
                comando.Parameters.Add(idcontrol);


                MySqlParameter idlegacy = new MySqlParameter("@idlegacy", MySqlDbType.Int32);
                idlegacy.Value = sistema.id_legacy;
                comando.Parameters.Add(idlegacy);

                MySqlParameter idalcance = new MySqlParameter("@idalcance", MySqlDbType.Int32);
                idalcance.Value = sistema.id_alcance;
                comando.Parameters.Add(idalcance);




                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de datos: " + ex.Message, ex);
            }
        }   

        public DataSet MaxIDsistemas()
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlConnection conex = new MySqlConnection();
                string servidor = "localhost";
                string bd = "prototipominvu";
                string usuario = "root";
                string password = "";
                string puerto = "3306";
                string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
                conex.ConnectionString = cadenaConexion;
                conex.Open();

                string sp_validausuario = "PSM_MaxIDsistemas";
                MySqlCommand comando = new MySqlCommand(sp_validausuario, conex);

                comando.CommandType = CommandType.StoredProcedure;  // Especifica que es un procedimiento almacenado.

                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de datos: " + ex.Message, ex);
            }

            return ds;
        }


        public DataSet obtenerReporteINTEGRACIONES()
        {

            DataSet ds = new DataSet();
            try
            {
                MySqlConnection conex = new MySqlConnection();
                string servidor = "localhost";
                string bd = "prototipominvu";
                string usuario = "root";
                string password = "";
                string puerto = "3306";
                string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
                conex.ConnectionString = cadenaConexion;
                conex.Open();

                string sp_validausuario = "";

                sp_validausuario = "PSM_REPORTEINTEEX";

                MySqlCommand comando = new MySqlCommand(sp_validausuario, conex);
                comando.CommandType = CommandType.StoredProcedure;  // Especifica que es un procedimiento almacenado.          

                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de datos: " + ex.Message, ex);
            }

            return ds;

        }


        public DataSet obtenerReporteSUBSISTEMAXVARIABLE(string control_select)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlConnection conex = new MySqlConnection();
                string servidor = "localhost";
                string bd = "prototipominvu";
                string usuario = "root";
                string password = "";
                string puerto = "3306";
                string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
                conex.ConnectionString = cadenaConexion;
                conex.Open();

                string sp_validausuario = "";


                if (control_select == "subsistemas_ambiente")
                    sp_validausuario = "PSM_REPORTESUBSISTEMASAMBIENTE";
                
                if (control_select == "subsistemas_estado")
                    sp_validausuario = "PSM_REPORTESUBSISTEMASESTADOS";

                if (control_select == "subsistemas_tecnologia")
                    sp_validausuario = "PSM_REPORTESUBSISTEMASTECNO";

                if (control_select == "subsistemas_area")
                    sp_validausuario = "PSM_REPORTESUBSISTEMASAREA";

                if (control_select == "subsistemas_data")
                    sp_validausuario = "PSM_REPORTESUBSISTEMASDATA";

                if (control_select == "subsistemas_tiposistema")
                    sp_validausuario = "PSM_REPORTESUBSISTEMASTIPOSI";

                if (control_select == "subsistemas_region")
                    sp_validausuario = "PSM_REPORTESUBSISTEMASREGION";               

                if (control_select == "subsistemas_jefe")
                    sp_validausuario = "PSM_REPORTESUBSISTEMASJEFEP";

                if (control_select == "subsistemas_control")
                    sp_validausuario = "PSM_REPORTESUBSISTEMASCONTROL";

                if (control_select == "subsistemas_alcance")
                    sp_validausuario = "PSM_REPORTESUBALCANCE";

                if (control_select == "subsistemas_legacy")
                    sp_validausuario = "PSM_REPORTESUBLEGACY";



                MySqlCommand comando = new MySqlCommand(sp_validausuario, conex);
                comando.CommandType = CommandType.StoredProcedure;  // Especifica que es un procedimiento almacenado.          

                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de datos: " + ex.Message, ex);
            }

            return ds;

        }


        public DataSet ObtenerSistemabyAmbiente(int ambiente)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlConnection conex = new MySqlConnection();
                string servidor = "localhost";
                string bd = "prototipominvu";
                string usuario = "root";
                string password = "";
                string puerto = "3306";
                string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
                conex.ConnectionString = cadenaConexion;
                conex.Open();

                // Nombre del procedimiento almacenado y configuración del parámetro
                string sp_validausuario = "PSM_SISTEMAbyambiente";
                MySqlCommand comando = new MySqlCommand(sp_validausuario, conex);
                comando.CommandType = CommandType.StoredProcedure; // Indicar que es un SP
                comando.Parameters.AddWithValue("@ambiente", ambiente); // Configurar el parámetro

                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de datos: " + ex.Message, ex);
            }
            return ds;
        }

        public DataSet TraeSistemabyid(int idsistema)
        {

            DataSet ds = new DataSet();
            try
            {
                MySqlConnection conex = new MySqlConnection();
                string servidor = "localhost";
                string bd = "prototipominvu";
                string usuario = "root";
                string password = "";
                string puerto = "3306";
                string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
                conex.ConnectionString = cadenaConexion;
                conex.Open();

                string sp_validausuario = "PSM_SISTEMAbyid";
                MySqlCommand comando = new MySqlCommand(sp_validausuario, conex);
                comando.CommandType = CommandType.StoredProcedure;  // Especifica que es un procedimiento almacenado.

                // Crea el parámetro y lo agrega al comando.


                MySqlParameter idSistema = new MySqlParameter("@idsistema", MySqlDbType.Int32);
                idSistema.Value = idsistema;
                comando.Parameters.Add(idSistema);

                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de datos: " + ex.Message, ex);
            }

            return ds;

        }



        public DataSet obtenerReporteSISTEMAXVARIABLE(string control_select)
        {

            DataSet ds = new DataSet();
            try
            {
                MySqlConnection conex = new MySqlConnection();
                string servidor = "localhost";
                string bd = "prototipominvu";
                string usuario = "root";
                string password = "";
                string puerto = "3306";
                string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
                conex.ConnectionString = cadenaConexion;
                conex.Open();

                string sp_validausuario = "";


                if (control_select == "sistemas_ambiente")
                    sp_validausuario = "PSM_GRAFICO_AMBIENTE";

                if (control_select == "sistemas_estado")
                    sp_validausuario = "PSM_GRAFICO_ESTADO";

                if (control_select == "sistemas_area")
                    sp_validausuario = "PSM_GRAFICO_AREAS";

                if (control_select == "sistemas_tecnologia")
                    sp_validausuario = "PSM_GRAFICO_TECNOLOGIA";

                if (control_select == "sistemas_tiposistema")
                    sp_validausuario = "PSM_GRAFICO_TIPOSI";

                if (control_select == "sistemas_region")
                    sp_validausuario = "PSM_GRAFICO_REGION";

                if (control_select == "sistemas_jefe")
                    sp_validausuario = "PSM_GRAFICO_JEFE";

                if (control_select == "sistemas_control")
                    sp_validausuario = "PSM_GRAFICO_CONTROL";

                if (control_select == "sistemas_alcance")
                    sp_validausuario = "PSM_GRAFICO_ALCANCE";

                if (control_select == "sistemas_legacy")
                    sp_validausuario = "PSM_GRAFICO_LEGACY";

                if (control_select == "sistemas_data")
                    sp_validausuario = "PSM_GRAFICO_DATAOW";
              



                MySqlCommand comando = new MySqlCommand(sp_validausuario, conex);
                comando.CommandType = CommandType.StoredProcedure;  // Especifica que es un procedimiento almacenado.          

                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de datos: " + ex.Message, ex);
            }

            return ds;

        }



    }
}