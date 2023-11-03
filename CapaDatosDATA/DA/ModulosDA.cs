using CapaDatosBO;
using MySql.Data.MySqlClient;
using System;
using System.Data;
namespace CapaDatosDATA.DA
{
    public class ModulosDA
    {
        public DataSet obtenerModulos()
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

                string sp_validausuario = @"Call PSM_MODULOS";
                MySqlCommand comando = new MySqlCommand(sp_validausuario, conex);
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(ds);

            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de datos: " + ex.Message, ex);
            }
            return ds;
        }




        public void EditarModulo(int idsistema, ModuloBO SistemaNuevo)
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

                string sp_validausuario = "PSM_EDITARMODULO";
                MySqlCommand comando = new MySqlCommand(sp_validausuario, conex);
                comando.CommandType = CommandType.StoredProcedure;  // Especifica que es un procedimiento almacenado.

                // Crea el parámetro y lo agrega al comando.


                MySqlParameter idSistema = new MySqlParameter("@idsistema", MySqlDbType.Int32);
                idSistema.Value = idsistema;
                comando.Parameters.Add(idSistema);

                MySqlParameter idAmbiente = new MySqlParameter("@idambiente", MySqlDbType.Int32);
                idAmbiente.Value = SistemaNuevo.id_AMBIENTE;
                comando.Parameters.Add(idAmbiente);

                MySqlParameter idestado = new MySqlParameter("@idestado", MySqlDbType.Int32);
                idestado.Value = SistemaNuevo.id_estado;
                comando.Parameters.Add(idestado);

                MySqlParameter nombre_sistema = new MySqlParameter("@nombresistema", MySqlDbType.VarChar);
                nombre_sistema.Value = SistemaNuevo.NombreSistema;
                comando.Parameters.Add(nombre_sistema);

                MySqlParameter descripcion_sistema = new MySqlParameter("@descripcionsistema", MySqlDbType.VarChar);
                descripcion_sistema.Value = SistemaNuevo.descripcion;
                comando.Parameters.Add(descripcion_sistema);




                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de datos: " + ex.Message, ex);
            }




        }


        public void agregaMODULO(ModuloBO sistema)
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

                string sp_validausuario = "PSM_AGREGAMODULO";
                MySqlCommand comando = new MySqlCommand(sp_validausuario, conex);
                comando.CommandType = CommandType.StoredProcedure;  // Especifica que es un procedimiento almacenado.

                // Crea el parámetro y lo agrega al comando.

                MySqlParameter idSistema = new MySqlParameter("@idsistema", MySqlDbType.Int32);
                idSistema.Value = sistema.idSistema;
                comando.Parameters.Add(idSistema);

                MySqlParameter nombre_sistema = new MySqlParameter("@nombre_sistema", MySqlDbType.VarChar);
                nombre_sistema.Value = sistema.NombreSistema;
                comando.Parameters.Add(nombre_sistema);

                MySqlParameter descripcion_sistema = new MySqlParameter("@descripcion_sistema", MySqlDbType.VarChar);
                descripcion_sistema.Value = sistema.descripcion;
                comando.Parameters.Add(descripcion_sistema);

                MySqlParameter idambiente = new MySqlParameter("@idambiente", MySqlDbType.Int32);
                idambiente.Value = sistema.id_AMBIENTE;
                comando.Parameters.Add(idambiente);

                MySqlParameter idestado = new MySqlParameter("@idestado", MySqlDbType.Int32);
                idestado.Value = sistema.id_estado;
                comando.Parameters.Add(idestado);

                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de datos: " + ex.Message, ex);
            }




        }



        public DataSet MaxIDmodulos()
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

                string sp_validausuario = "PSM_MaxIDmodulos";
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




        public DataSet TraeModulobyid(int idmodulo)
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

                string sp_validausuario = "PSM_MODULObyid";
                MySqlCommand comando = new MySqlCommand(sp_validausuario, conex);
                comando.CommandType = CommandType.StoredProcedure;  // Especifica que es un procedimiento almacenado.

                // Crea el parámetro y lo agrega al comando.


                MySqlParameter idSistema = new MySqlParameter("@idsistema", MySqlDbType.Int32);
                idSistema.Value = idmodulo;
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





        public DataSet ObtenerModulobyAmbiente(int ambiente)
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
                string sp_validausuario = "PSM_MODULObyambiente";
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








        // cargadores para los combos

        public DataSet obtenerEstados()
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

                string sp_validausuario = @"Call PSM_CARGAESTADOS";
                MySqlCommand comando = new MySqlCommand(sp_validausuario, conex);
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(ds);

            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de datos: " + ex.Message, ex);
            }
            return ds;


        }
        public DataSet obtenerAmbientes()
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

                string sp_validausuario = @"Call PSM_CARGAMBIENTES";
                MySqlCommand comando = new MySqlCommand(sp_validausuario, conex);
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(ds);

            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de datos: " + ex.Message, ex);
            }
            return ds;
        }
        public DataSet obtenerAreas()
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

                string sp_validausuario = "PSM_CARGAAREAS";
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
        public DataSet obtenerDO()
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

                string sp_validausuario = "PSM_CARGADO";
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
        public DataSet obtenerControlAcceso()
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

                string sp_validausuario = "PSM_CARGACONTROLACCESO";
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
        public DataSet obtenerAlcance()
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

                string sp_validausuario = "PSM_CARGAALCANCES";
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
        public DataSet obtenerRegiones()
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

                string sp_validausuario = "PSM_CARGAREGION";
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
        public DataSet obtenerLegacy()
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

                string sp_validausuario = "PSM_CARGALEGACY";
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
        public DataSet obtenerTipoSistemas()
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

                string sp_validausuario = "PSM_CARGATIPOSISTEMA";
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
        public DataSet obtenerTecnologias()
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

                string sp_validausuario = "PSM_CARGATECNOLOGIA";
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


    }



}