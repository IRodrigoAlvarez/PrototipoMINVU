using CapaDatosBO;
using CapaDatosNEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrototipoMINVU.Controllers
{
    public class HomeController : Controller
    {


        //Control de vistas
        public ActionResult Index()
        {


            
            var alerta = Session["UsuarioConfirmado"];
            if (alerta != null)
            {
                return View();
            }
            else
                return RedirectToAction("Login", "Seguridad");
        }
        public ActionResult RegistroSistemas()
        {
            var alerta = Session["UsuarioConfirmado"];
            if (alerta != null)
            {
                Models.Sistemas cargadorSis = new Models.Sistemas();
                cargadorSis.CargaSistemas();

                return View(cargadorSis);
            }
            else
                return RedirectToAction("Login", "Seguridad");
        }

        // Funciones backen para la carga o visualización de datos.

       








    }
}