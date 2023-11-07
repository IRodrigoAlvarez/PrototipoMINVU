using CapaDatosBO;
using CapaDatosNEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrototipoMINVU.Controllers
{
    public class IntegracionesController : Controller
    {
        public ActionResult Integraciones()
        {
            var alerta = Session["UsuarioConfirmado"];
            if (alerta != null)
            {
                Models.Registro cargador = new Models.Registro();

                cargador.CargaIntegraciones();


                return View(cargador);
            }
            else
                return RedirectToAction("Login", "Seguridad");
        }



        public ActionResult addIntegration()
        {
            var alerta = Session["UsuarioConfirmado"];
            if (alerta != null)
            {

                Models.Registro cargador = new Models.Registro();

                cargador.CargaSistemas();
                cargador.CargaModulos();
                cargador.CargaIntegraciones();


                return View(cargador);
            }
            else
                return RedirectToAction("Login", "Seguridad");
        }







        // FUNCIONES BACKEND PARA EL FUNCIONAMIENTO DE LAS INTEGRACIONES
        public ActionResult RegistrarIntegracion(Models.Registro modelointegracion) 
        
        {

            IntegraBO integra = new IntegraBO();
     
            IntegracionesBUSINESS cargador = new IntegracionesBUSINESS();

            integra = modelointegracion.IntegracionExample;

            cargador.AgregarIntegracion(integra);


            return RedirectToAction("Integraciones","Integraciones");
        }





    }
}