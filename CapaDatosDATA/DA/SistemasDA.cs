﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CapaDatosDATA.DA
{
    public class SistemasDA
    {
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
                string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
                conex.ConnectionString = cadenaConexion;
                conex.Open();

                string sp_validausuario = @"Call PSM_SISTEMAS";
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
                string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
                conex.ConnectionString = cadenaConexion;
                conex.Open();

                string sp_validausuario = @"Call PSM_CARGASUBSISTEMAS";
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
                string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
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
    }
}