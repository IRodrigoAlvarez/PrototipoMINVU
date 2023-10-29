﻿using CapaDatosBO;
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
                cargadorSis.CargaSistemas();
                cargadorSis.CargaSubSistemas();
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
                cargadorSis.CargaSistemas();
                cargadorSis.CargarCombos();

                return View(cargadorSis);
            }
            else
                return RedirectToAction("Login", "Seguridad");
        }





        // ---------------------FUNCIONES BACKEND PARA EL FUNCIONAMIENTO DEL SISTEMA.






        [HttpPost]
        public ActionResult FrmSistemas(string id_sistemasedit, string nombre_sistemasedit, string descripcion_sistema, string ambiente_sistema)
        {
            Models.Registro cargadorSis = new Models.Registro();



            var alerta = Session["UsuarioConfirmado"];
            Session["ID_SISTEMA"] = id_sistemasedit;
            Session["NOMBRE_SISTEMA"] = nombre_sistemasedit;
            Session["DESCRIPCION"] = descripcion_sistema;

            if (alerta != null)
            {
                cargadorSis.CargarCombos();
                cargadorSis.CargaSistemabyID(Int32.Parse(id_sistemasedit));
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

            return RedirectToAction("EditarSistemas", "Registro");
        }




        [HttpPost]
        public ActionResult EditarSistemasGenerales(Models.Registro sistemanuevo, string id_sistemaedit)
        {

            SistemasBO sistemaeditado = new SistemasBO();
            SistemasBUSINESS cargador = new SistemasBUSINESS();

            int id_sistema = Int32.Parse(id_sistemaedit);

            sistemaeditado = sistemanuevo.SistemaExample;
            cargador.EditarSistemaGeneral(id_sistema, sistemaeditado);

            return RedirectToAction("EditarSistemas", "Registro");
        }





        [HttpPost]
        public ActionResult AgregarSistemaGeneral(Models.Registro sistema, string essubsistema) 
        {
            SistemasBO sistema_aux = new SistemasBO();
            SubSistemasBO subsi_aux = new SubSistemasBO();

            SistemasBUSINESS cargador = new SistemasBUSINESS();

            sistema_aux = sistema.SistemaExample;

            


            sistema_aux.id_estado = sistema.id_Estado;

            if (essubsistema == null)
                cargador.agregarsistema(sistema_aux);
            else {
                subsi_aux = sistema.SubSistemaExample;

                subsi_aux.NombreSubSistema = sistema.SistemaExample.NombreSistema;
                subsi_aux.DescripcionSubSistema = sistema.SistemaExample.descripcion;
                subsi_aux.id_estado = sistema.id_Estado;
                subsi_aux.idAmbiente = sistema.SistemaExample.id_AMBIENTE;

                subsi_aux.idSistemaenlazado = sistema.id_sistemaenlazado;




                cargador.agregarsubsistema(subsi_aux);
            }




            return RedirectToAction("EditarSistemas", "Registro");
        }









    }
}
