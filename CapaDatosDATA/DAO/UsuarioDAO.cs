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


        public int obtenerMaxIdUsuario()
        {

            int resultado = new int();

            DataSet ds = new DataSet();
            UsuarioDA Conexion = new UsuarioDA();

            ds = Conexion.MaxIDusuario();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                resultado = Int32.Parse(r["MAX(usuario.idUsuario)"].ToString());
            }
            return resultado;

        }

    }
}