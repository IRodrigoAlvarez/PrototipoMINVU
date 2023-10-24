using CapaDatosBO;
using CapaDatosNEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrototipoMINVU.Controllers
{
    public class ControlController : Controller
    {
        // FUNCIONES PARA EL RETORNO DE VISTAS

        [HttpPost]
        public ActionResult ControlSistemas(string control_select)
        {
            var alerta = Session["UsuarioConfirmado"];
            if (alerta != null)
            {               
                return View();
            }
            else
                return RedirectToAction("Login", "Seguridad");
        }











        // CONTROL PARA LAS INTEGRACIONES

        [HttpGet]
        public JsonResult ReporteINTEEX()
        {
            SistemasBUSINESS cargador = new SistemasBUSINESS();
            List<ReporteGeneralBO> objLista = new List<ReporteGeneralBO>();
           
            objLista= cargador.ReporteINTEEX();

            return Json(objLista, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult ReporteINTEIN()
        {
            SistemasBUSINESS cargador = new SistemasBUSINESS();
            List<ReporteGeneralBO> objLista = new List<ReporteGeneralBO>();
            objLista = cargador.ReporteINTEIN();      
            
            return Json(objLista, JsonRequestBehavior.AllowGet);
        }







    }
}
