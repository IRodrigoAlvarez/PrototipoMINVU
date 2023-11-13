using CapaDatosBO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CapaDatosDATA.DA
{
    public class UsuarioDA
    {
        public DataSet obtenerUsuario(int intUsuario, string strPassword, string strPasswordUpper)
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

                string sp_validausuario = @"Call PSM_VALIDAUSUARIO(@idrut,@idpas)";
                MySqlCommand comando = new MySqlCommand(sp_validausuario, conex);
                comando.Parameters.AddWithValue("@idrut", intUsuario);
                comando.Parameters.AddWithValue("@idpas", strPassword);
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(ds);

            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de datos: " + ex.Message, ex);
            }
            return ds;
        }


        public void RegistrarUsuario(UsuarioBO usuarionuevo)
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

                string sp_validausuario = "PSM_AGREGARUSUARIO";
                MySqlCommand comando = new MySqlCommand(sp_validausuario, conex);
                comando.CommandType = CommandType.StoredProcedure;  // Especifica que es un procedimiento almacenado.

                // Crea el parámetro y lo agrega al comando.
                MySqlParameter idSistemadelete = new MySqlParameter("@idUsuario", MySqlDbType.Int32);
                idSistemadelete.Value = usuarionuevo.idUsuario;
                comando.Parameters.Add(idSistemadelete);

                MySqlParameter RUT = new MySqlParameter("@RUT", MySqlDbType.Int32);
                RUT.Value = usuarionuevo.intRut;
                comando.Parameters.Add(RUT);

                MySqlParameter CORREO = new MySqlParameter("@correo", MySqlDbType.VarChar);
                CORREO.Value = usuarionuevo.Correoelectronico;
                comando.Parameters.Add(CORREO);

                MySqlParameter strpass = new MySqlParameter("@strPass", MySqlDbType.VarChar);
                strpass.Value = usuarionuevo.strPass;
                comando.Parameters.Add(strpass);

                MySqlParameter nombre_usuario = new MySqlParameter("@nombre", MySqlDbType.VarChar);
                nombre_usuario.Value = usuarionuevo.strNombre;
                comando.Parameters.Add(nombre_usuario);

                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(ds);

            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de datos: " + ex.Message, ex);
            }
        }


        public DataSet MaxIDusuario()
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

                string sp_validausuario = "PSM_MaxIDusuario";
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