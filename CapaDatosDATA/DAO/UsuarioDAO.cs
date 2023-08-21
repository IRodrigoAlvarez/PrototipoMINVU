using CapaDatosBO;
using CapaDatosDATA.DA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CapaDatosDATA.DAO
{
    public class UsuarioDAO
    {
        public UsuarioBO ValidaUsuario(LoginBO loginBO)
        {
            // aquí se establece el dataset a utilizar en el sistema, desde la base de datos 
            // si está válido o no está valido y lo retorna.


            UsuarioDA Conexion = new UsuarioDA();
            DataSet dsUsuario = Conexion.obtenerUsuario(loginBO.intRut, loginBO.strPassword, loginBO.strPasswordUpper);
            UsuarioBO resultado = new UsuarioBO();
            foreach (DataRow r in dsUsuario.Tables[0].Rows)
            {
                //llenar los datos del usuario
                resultado.intRut = Int32.Parse(r["RUT"].ToString());
                resultado.strPass = r["Password"].ToString();
                resultado.strNombre = r["Nombre"].ToString();
                // para modo de prueba aceptados ingresar a cuaqluier usuario
                resultado.boolGenerica = false;
                resultado.boolVigente = true;

            }




            

            return resultado;
        }
    }
}