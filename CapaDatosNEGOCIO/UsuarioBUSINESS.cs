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
            Usuario.strPassword = HPH.HELPERS.MD5Helper.HashMD5(contrasena).ToUpper();
            Usuario.strPasswordUpper = HPH.HELPERS.MD5Helper.HashMD5(contrasena.ToUpper()).ToUpper();
            //se valida el usuario en la capa de datos DAO
            CapaDatosDATA.DAO.UsuarioDAO back_usuario = new CapaDatosDATA.DAO.UsuarioDAO();
            return back_usuario.ValidaUsuario(Usuario);

        }

        
    }
}