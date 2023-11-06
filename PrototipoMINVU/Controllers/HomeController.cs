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
                Models.Registro cargador = new Models.Registro();

                cargador.CargaMapaintegracion();
                cargador.CargaSistemas();                 
                return View(cargador);
            }
            else
                return RedirectToAction("Login", "Seguridad");
        }



    }
}