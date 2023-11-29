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
                resultado.intIDtipousuario = Int32.Parse(r["id_tipousuario"].ToString());
                resultado.strTipousuario = r["descripcion_usuario"].ToString();
                resultado.strNombre = r["Nombre"].ToString();
                // para modo de prueba aceptados ingresar a cuaqluier usuario
                resultado.boolGenerica = false;
                resultado.boolVigente = true;
            }
            return resultado;
        }


        public List<UsuarioBO> CargaListaTipoUsuarios()
        {
            List<UsuarioBO> resultado = new List<UsuarioBO>();

            DataSet ds = new DataSet();
            UsuarioDA Conexion = new UsuarioDA();


            ds = Conexion.obtenerTipoUsuarios();

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                //Se llena la lista con los sistemas
                UsuarioBO usuario = new UsuarioBO();

                usuario.intIDtipousuario = Int32.Parse(r["id_tipousuario"].ToString());
                usuario.strTipousuario = r["descripcion_usuario"].ToString();
                
                if (usuario.intIDtipousuario != 0)
                    resultado.Add(usuario);
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