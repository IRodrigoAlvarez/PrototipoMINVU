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

        public ActionResult EditarSistemas()
        {
            var alerta = Session["UsuarioConfirmado"];
            if (alerta != null)
            {
                Models.Registro cargadorSis = new Models.Registro();
                cargadorSis.CargaParametros();
                cargadorSis.CargarCombos();
                return View(cargadorSis);
            }
            else
                return RedirectToAction("Login", "Seguridad");


        }







        [HttpPost]
        public ActionResult FrmSistemas(string id_sistemasedit, string nombre_sistemasedit, string descripcion_sistema)
        {
            var alerta = Session["UsuarioConfirmado"];
            Session["ID_SISTEMA"] = id_sistemasedit;
            Session["NOMBRE_SISTEMA"] = nombre_sistemasedit;
            Session["DESCRIPCION"] = descripcion_sistema;

            if (alerta != null)
            {
                Models.Registro cargadorSis = new Models.Registro();
                cargadorSis.CargaSubsistemasbyID(Int32.Parse(id_sistemasedit));
                return View(cargadorSis);
            }
            else
                return RedirectToAction("Login", "Seguridad");
        }




        [HttpPost]
        public ActionResult FrmSubsistemas(string id_sistemasedit, string nombre_sistemasedit, string descripcion_subsistema)
        {
            var alerta = Session["UsuarioConfirmado"];
            Session["ID_SISTEMA"] = id_sistemasedit;
            Session["NOMBRE_SISTEMA"] = nombre_sistemasedit;
            Session["DESCRIPCION"] = descripcion_subsistema;


            if (alerta != null)
            {
                Models.Registro cargadorSis = new Models.Registro();

                cargadorSis.CargarCombos();


                return View();
            }
            else
                return RedirectToAction("Login", "Seguridad");
        }












        // Funciones backen para la carga o visualización de datos.

        public ActionResult EditarSubSistema(string id_nombre)
        {
            // Recupera el valor de "NOMBRE_SISTEMA" de la sesión
            string nombreSistema = id_nombre;

            // Puedes usar el valor de "nombreSistema" como sea necesario en tu controlador
            // ...

            return RedirectToAction("FrmSistemas","Home");
        }




    }
}