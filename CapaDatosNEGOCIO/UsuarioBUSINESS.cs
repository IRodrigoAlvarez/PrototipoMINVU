using CapaDatosBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaDatosNEGOCIO
{
    public class UsuarioBUSINESS
    {
        public UsuarioBO validaUsuario(LoginBO Usuario)
        {
            //en este bloque se sube a mayusculas el string, para que todo se trabaje con mayusculas.
            string contrasena = Usuario.strPassword;
            Usuario.strPassword = PSMIN.HELPERS.MD5Helper.HashMD5(contrasena).ToUpper();
            Usuario.strPasswordUpper = PSMIN.HELPERS.MD5Helper.HashMD5(contrasena.ToUpper()).ToUpper();
            //se valida el usuario en la capa de datos DAO
            CapaDatosDATA.DAO.UsuarioDAO back_usuario = new CapaDatosDATA.DAO.UsuarioDAO();
            return back_usuario.ValidaUsuario(Usuario);

        }

        public void RegistrarUsuario(UsuarioBO Usuario)
        {
            //en este bloque se sube a mayusculas el string, para que todo se trabaje con mayusculas.

            //se valida el usuario en la capa de datos DAO
            CapaDatosDATA.DA.UsuarioDA back_usuario = new CapaDatosDATA.DA.UsuarioDA();
            CapaDatosDATA.DAO.UsuarioDAO back_usuario2 = new CapaDatosDATA.DAO.UsuarioDAO();

            int idusuario = back_usuario2.obtenerMaxIdUsuario();


            Usuario.idUsuario = idusuario + 1;

            back_usuario.RegistrarUsuario(Usuario);

        }


        public List<UsuarioBO> CargaTipoUsuarios() 
        {

            CapaDatosDATA.DAO.UsuarioDAO back_usuario = new CapaDatosDATA.DAO.UsuarioDAO();
            return back_usuario.CargaListaTipoUsuarios();


        }





    }
}