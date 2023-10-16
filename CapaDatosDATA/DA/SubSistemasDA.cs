using CapaDatosBO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CapaDatosDATA.DA
{
    public class SubSistemasDA
    {
        public DataSet obtenerSubSistemasbyID(int sistema)
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

                string sp_validausuario = "PSM_CARGASUBSISTEMASby";
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

        public DataSet obtenerSubSistemas()
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

                string sp_validausuario = "PSM_SUBSISTEMAS";
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

        public DataSet CaracteristicasSubSistemasbyID(int sistema)
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

                string sp_validausuario = "PSM_FRMSUBSIby";
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

        public void EditarSubSistema(int idsistema, SubSistemasBO SistemaNuevo)
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

                string sp_validausuario = "PSM_EDITARSUBSISTEMA";
                MySqlCommand comando = new MySqlCommand(sp_validausuario, conex);
                comando.CommandType = CommandType.StoredProcedure;  // Especifica que es un procedimiento almacenado.

                // Crea el parámetro y lo agrega al comando.


                MySqlParameter idSubSistema = new MySqlParameter("@idsistemanuevo", MySqlDbType.Int32);
                idSubSistema.Value = idsistema;
                comando.Parameters.Add(idSubSistema);

                MySqlParameter nombreSistema = new MySqlParameter("@nombresubsistema", MySqlDbType.VarChar);
                nombreSistema.Value = SistemaNuevo.NombreSubSistema;
                comando.Parameters.Add(nombreSistema);

                MySqlParameter descripcion = new MySqlParameter("@descripcion", MySqlDbType.VarChar);
                descripcion.Value = SistemaNuevo.DescripcionSubSistema;
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

        public void agregasubsistema(SubSistemasBO sistema)
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

                string sp_validausuario = "PSM_AGREGASUBSISTEMA";
                MySqlCommand comando = new MySqlCommand(sp_validausuario, conex);
                comando.CommandType = CommandType.StoredProcedure;  // Especifica que es un procedimiento almacenado.

                // Crea el parámetro y lo agrega al comando.

                MySqlParameter idSistema = new MySqlParameter("@idsubsistema", MySqlDbType.Int32);
                idSistema.Value = sistema.idSubSistema;
                comando.Parameters.Add(idSistema);               

                MySqlParameter idSistemaenlazado = new MySqlParameter("@idsistemaenlazado", MySqlDbType.Int32);
                idSistemaenlazado.Value = sistema.idSistemaenlazado;
                comando.Parameters.Add(idSistemaenlazado);

                MySqlParameter idambiente = new MySqlParameter("@idambiente", MySqlDbType.Int32);
                idambiente.Value = sistema.idAmbiente;
                comando.Parameters.Add(idambiente);

                MySqlParameter nombre_sistema = new MySqlParameter("@nombresubsi", MySqlDbType.VarChar);
                nombre_sistema.Value = sistema.NombreSubSistema;
                comando.Parameters.Add(nombre_sistema);               

                MySqlParameter URLinicio = new MySqlParameter("@urlinicio", MySqlDbType.VarChar);
                URLinicio.Value = sistema.URLinicio;
                comando.Parameters.Add(URLinicio);

                MySqlParameter URLdatos = new MySqlParameter("@urldatos", MySqlDbType.VarChar);
                URLdatos.Value = sistema.URLdatos;
                comando.Parameters.Add(URLdatos);

                MySqlParameter costosistema = new MySqlParameter("@costosistema", MySqlDbType.Int32);
                costosistema.Value = Int32.Parse(sistema.CostoSistema);
                comando.Parameters.Add(costosistema);

                MySqlParameter descripcion_sistema = new MySqlParameter("@descripcionsubsi", MySqlDbType.VarChar);
                descripcion_sistema.Value = sistema.DescripcionSubSistema;
                comando.Parameters.Add(descripcion_sistema);

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

                MySqlParameter idestados = new MySqlParameter("@idestados", MySqlDbType.Int32);
                idestados.Value = sistema.id_estado;
                comando.Parameters.Add(idestados);


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

        public DataSet MaxIDsubsistemas()
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

                string sp_validausuario = "PSM_MaxIDsubsistemas";
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