using CapaDatosBO;
using CapaDatosNEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrototipoMINVU.Controllers
{
    public class RegistroController : Controller
    {


        // ---------------------------FUNCIONES PARA EL RETORNO DE VISTAS

        public ActionResult EditarSistemas()
        {
            var alerta = Session["UsuarioConfirmado"];
            if (alerta != null)
            {
                Models.Registro cargadorSis = new Models.Registro();
                cargadorSis.CargaModulos();
                cargadorSis.CargaSistemas();
                return View(cargadorSis);
            }
            else
                return RedirectToAction("Login", "Seguridad");
        }

        public ActionResult AgregarSistemas()
        {
            var alerta = Session["UsuarioConfirmado"];
            if (alerta != null)
            {
                Models.Registro cargadorSis = new Models.Registro();
                cargadorSis.CargaModulos();
                cargadorSis.CargarCombos();

                return View(cargadorSis);
            }
            else
                return RedirectToAction("Login", "Seguridad");
        }





        // ---------------------FUNCIONES BACKEND PARA EL FUNCIONAMIENTO DEL SISTEMA.
        [HttpPost]
        public ActionResult FrmModulos(string id_sistemasedit, string nombre_sistemasedit)
        {
            Models.Registro cargadorSis = new Models.Registro();

            var alerta = Session["UsuarioConfirmado"];
            Session["ID_MODULO"] = id_sistemasedit;
            Session["NOMBRE_SISTEMA"] = nombre_sistemasedit;
            if (alerta != null)
            {
                cargadorSis.CargarCombos();
                cargadorSis.CargaModulobyID(Int32.Parse(id_sistemasedit));
                return View(cargadorSis);
            }
            else
                return RedirectToAction("Login", "Seguridad");
        }




        [HttpPost]
        public ActionResult FrmSistemas(string id_sistemasedit, string nombre_sistemasedit)
        {
            var alerta = Session["UsuarioConfirmado"];

            Session["NOMBRE_SISTEMA"] = nombre_sistemasedit;
            Session["ID_SISTEMA"] = Int32.Parse(id_sistemasedit);

            if (alerta != null)
            {
                Models.Registro cargadorSis = new Models.Registro();

                cargadorSis.CargarCombos();
                cargadorSis.TraeCaractersticasSistema(Int32.Parse(id_sistemasedit));
                return View(cargadorSis);
            }
            else
                return RedirectToAction("Login", "Seguridad");
        }



        [HttpPost]
        public void EliminarSistema(string id_sistemasedit)
        {

            SistemasBUSINESS cargador = new SistemasBUSINESS();

            int id_sistemaeliminar = Int32.Parse(id_sistemasedit);

            cargador.EliminarSistema(id_sistemaeliminar);

        }










        // Funciones backen para la carga o visualización de datos.
        [HttpPost]

        public ActionResult EditarSistema(Models.Registro sistemanuevo, string id_sistemasedit)
        {

            SistemasBO sistemaeditado = new SistemasBO();
            SistemasBUSINESS cargador = new SistemasBUSINESS();

            int id_sistema = Int32.Parse(id_sistemasedit);

            sistemaeditado = sistemanuevo.SistemaExample;
            cargador.EditarSistema(id_sistema, sistemaeditado);

            return RedirectToAction("EditarSistemas", "Registro");
        }




        [HttpPost]
        public ActionResult EditarModulo(Models.Registro sistemanuevo, string id_sistemaedit)
        {

            ModuloBO sistemaeditado = new ModuloBO();
            ModulosBUSINESS cargador = new ModulosBUSINESS();

            int id_sistema = Int32.Parse(id_sistemaedit);

            sistemaeditado = sistemanuevo.ModuloExample;
            cargador.EditarModulo(id_sistema, sistemaeditado);

            return RedirectToAction("EditarSistemas", "Registro");
        }





        [HttpPost]
        public ActionResult RegistraModuloSistema(Models.Registro sistema, string essistema) 
        {
            ModuloBO modulo_aux = new ModuloBO();
            SistemasBO sistema_aux = new SistemasBO();

            ModulosBUSINESS cargador = new ModulosBUSINESS();
            SistemasBUSINESS cargador2 = new SistemasBUSINESS();


            modulo_aux = sistema.ModuloExample;       
            modulo_aux.id_estado = sistema.id_Estado;



            if (essistema == null)
                cargador.agregarmodulo(modulo_aux);
            else {
                sistema_aux = sistema.SistemaExample;

                sistema_aux.NombreSistema = sistema.ModuloExample.NombreSistema;
                sistema_aux.DescripcionSistema = sistema.ModuloExample.descripcion;
                sistema_aux.id_estado = sistema.id_Estado;
                sistema_aux.idAmbiente = sistema.ModuloExample.id_AMBIENTE;

                cargador2.agregarsistema(sistema_aux);
            }




            return RedirectToAction("EditarSistemas", "Registro");
        }









    }
}
