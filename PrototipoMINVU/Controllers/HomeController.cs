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
                cargadorSis.CargaSistemas();             
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
            Session["NOMBRE_SISTEMA"] = nombre_sistemasedit;
            Session["ID_SUBSISTEMA"] = Int32.Parse(id_sistemasedit);

            if (alerta != null)
            {
                Models.Registro cargadorSis = new Models.Registro();

                cargadorSis.CargarCombos();
                cargadorSis.TraeCaractersticasSubSistema(Int32.Parse(id_sistemasedit));
                return View(cargadorSis);
            }
            else
                return RedirectToAction("Login", "Seguridad");
        }












        // Funciones backen para la carga o visualización de datos.
        [HttpPost]

        public ActionResult EditarSubSistema(Models.Registro subsistemanuevo, string id_subsistemasedit)
        {

            SubSistemasBO sistemaeditado = new SubSistemasBO();
            SubSistemasBUSINESS cargador = new SubSistemasBUSINESS();




            int id_subsistema = Int32.Parse(id_subsistemasedit);
            sistemaeditado = subsistemanuevo.SubSistemaExample;



            cargador.EditarSubSistema(id_subsistema, sistemaeditado);         

            return RedirectToAction("EditarSistemas","Home");
        }




    }
}