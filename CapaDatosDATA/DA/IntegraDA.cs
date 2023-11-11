using CapaDatosBO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CapaDatosDATA.DA
{
    public class IntegraDA
    {

        public DataSet obtenerTipoIntegracion()
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

                string sp_validausuario = "PSM_CARGATIPOINTEGRACIONES";
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

        public DataSet obtenerIntegraciones()
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

                string sp_validausuario = "PSM_INTEGRACIONES";
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


        public DataSet obtenerIntegracionesSistemasby(int sistema)
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

                string sp_validausuario = "PSM_INTEGRA_SISTEMASby";
                MySqlCommand comando = new MySqlCommand(sp_validausuario, conex);
                comando.CommandType = CommandType.StoredProcedure;  // Especifica que es un procedimiento almacenado.

                // Crea el parámetro y lo agrega al comando.
                MySqlParameter idIntegracion = new MySqlParameter("@idsistema", MySqlDbType.Int32);
                idIntegracion.Value = sistema;
                comando.Parameters.Add(idIntegracion);

                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de datos: " + ex.Message, ex);
            }
            return ds;
        }


        public DataSet AddIntegracion(IntegraBO integracion)
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

                string sp_validausuario = "PSM_ADDINTEGRACION";
                MySqlCommand comando = new MySqlCommand(sp_validausuario, conex);
                comando.CommandType = CommandType.StoredProcedure;  // Especifica que es un procedimiento almacenado.

                // Crea el parámetro y lo agrega al comando.
                MySqlParameter idIntegracion = new MySqlParameter("@idinte", MySqlDbType.Int32);
                idIntegracion.Value = integracion.id_integracion;
                comando.Parameters.Add(idIntegracion);

                MySqlParameter idSistemaOrigen = new MySqlParameter("@idso", MySqlDbType.Int32);
                idSistemaOrigen.Value = integracion.id_sistemaorigen;
                comando.Parameters.Add(idSistemaOrigen);

                MySqlParameter idSistemaDestino = new MySqlParameter("@idsd", MySqlDbType.Int32);
                idSistemaDestino.Value = integracion.id_sistemadestino;
                comando.Parameters.Add(idSistemaDestino);

                MySqlParameter idSistemaDestino2 = new MySqlParameter("@idsd2", MySqlDbType.Int32);
                idSistemaDestino2.Value = integracion.id_sistemadestino2;
                comando.Parameters.Add(idSistemaDestino2);

                MySqlParameter idModuloOrigen = new MySqlParameter("@idmo", MySqlDbType.Int32);
                idModuloOrigen.Value = integracion.id_moduloorigen;
                comando.Parameters.Add(idModuloOrigen);

                MySqlParameter idModuloDestino = new MySqlParameter("@idmd", MySqlDbType.Int32);
                idModuloDestino.Value = integracion.id_modulodestino;
                comando.Parameters.Add(idModuloDestino);

                MySqlParameter idModuloDestino2 = new MySqlParameter("@idmd2", MySqlDbType.Int32);
                idModuloDestino2.Value = integracion.id_modulodestino2;
                comando.Parameters.Add(idModuloDestino2);

                MySqlParameter idTipoIntegracion = new MySqlParameter("@idtint", MySqlDbType.Int32);
                idTipoIntegracion.Value = integracion.id_tipointegracion;
                comando.Parameters.Add(idTipoIntegracion);

                MySqlParameter idEntidadExterna = new MySqlParameter("@identex", MySqlDbType.Int32);
                idEntidadExterna.Value = integracion.id_entidadexterna;
                comando.Parameters.Add(idEntidadExterna);


                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en capa de datos: " + ex.Message, ex);
            }
            return ds;
        }



        public DataSet MaxIDintegra()
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

                string sp_validausuario = "PSM_MAXIDintegra";
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