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
                    //si la cuenta está habilitada o baneada, se le cambia el estado a boolVigente.
                    if (UsuarioValidado.boolVigente == true)
                    {

                        Session["UsuarioConfirmado"] = UsuarioValidado;
                        Session["strNombre"] = UsuarioValidado.strNombre;

                        Session.Timeout = 700;

                        //si el usuario o la contraseña están íncorrectos, se le cambia el estado a boolGenérica.
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
            Session.Abandon();
            return View("Login");

        }
    }
}
