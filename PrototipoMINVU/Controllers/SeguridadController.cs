using CapaDatosBO;
using CapaDatosNEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrototipoMINVU.Controllers
{
    public class SeguridadController : Controller
    {
        public ActionResult Login()
        {
            var alerta = Session["UsuarioConfirmado"];

            if (alerta != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
                return View();
        }



        [HttpPost]
        public ActionResult RegistroUsuario()
        {
            Models.Usuario cargador = new Models.Usuario();

            cargador.CargatipoUsuarios();            


            return View(cargador);
        }





        [HttpPost]
        public ActionResult RegistraUsuario(Models.Usuario usuarionuevo)
        {

            UsuarioBO usuario = new UsuarioBO();

            UsuarioBUSINESS cargador = new UsuarioBUSINESS();


            usuario.intRut = usuarionuevo.Rut;
            usuario.strPass = usuarionuevo.Contrasena;
            usuario.strNombre = usuarionuevo.Nombre;
            usuario.intIDtipousuario = usuarionuevo.IdTipoUsuario;
            usuario.strRepeatPass = usuarionuevo.Repetircontraseña;
            usuario.Correoelectronico = usuarionuevo.CorreoElectronico;
           

            if(usuario.strPass == usuario.strRepeatPass)
            {

                cargador.RegistrarUsuario(usuario);
                return RedirectToAction("Login", "Seguridad");
            }

            return RedirectToAction("Login","Seguridad");
        }

















        public ActionResult CambiaPass()
        {
            var alerta = Session["UsuarioConfirmado"];

            if (alerta != null)
            {
                return View();
            }
            else                
                return RedirectToAction("Index", "Home");
        }




        public ActionResult CambiarPassword(Models.Usuario objUsuario)
        {

            if (objUsuario.Contrasena == objUsuario.ContrasenaNueva)
            {


            }

            return RedirectToAction("Index", "Home");
        }



        public ActionResult ValidaUsuario(Models.Usuario usuariomod)
        {
            try
            {
                //usuario login que está intentando ingresar al sitio
                LoginBO UsuarioLogin = new LoginBO();
                //herramienta que hará las validaciones de las credenciales
                UsuarioBUSINESS Certificador = new UsuarioBUSINESS();

                //datos del formulario de sesión
                UsuarioLogin.intRut = usuariomod.Rut;
                UsuarioLogin.strPassword = usuariomod.Contrasena;

                // Si el usuario está validado, retornará un objeto.
                var UsuarioValidado = Certificador.validaUsuario(UsuarioLogin);


                //si el objeto es distinto de null, entonces la cuenta no está registrado
                if (UsuarioValidado != null)
                {
                    //si la cuenta está inhabilitada o baneada,  boolVigente es falsa.
                    if (UsuarioValidado.boolVigente == true)
                    {

                        Session["UsuarioConfirmado"] = UsuarioValidado;
                        Session["TipoUsuario"] = UsuarioValidado.strTipousuario;
                        Session["strNombre"] = UsuarioValidado.strNombre;

                        Session.Timeout = 700;

                        //si el usuario o la contraseña están íncorrectos, boolGenérica es falsa.
                        if (UsuarioValidado.boolGenerica == false)
                        {
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            ViewBag.mensaje = -1;
                            ViewBag.resp = "Usuario o Contraseña incorrectos.";
                            return View("Login");
                        }
                    }
                    else
                    {
                        ViewBag.mensaje = -1;
                        ViewBag.resp = "Cuenta inhabilitada";
                        return View("Login");
                    }
                }
                else
                {
                    ViewBag.resp = "Usuario no registrado";
                }
            }
            catch (Exception ex)
            {
                ViewBag.mensaje = -1;
                ViewBag.resp = ex.Message;
                Session["mensajeerror"] = ViewBag.resp;
                return RedirectToAction("Login");
            }
            return View("Login");
        }


        public ActionResult CerrarSesion()
        {
            Session["objUsuarioBO"] = null;
            Session["strNombre"] = null;
            Session["UsuarioConfirmado"] = null;
            Session.Abandon();

            return View("Login");

        }
    }
}
