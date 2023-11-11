﻿using CapaDatosBO;
using CapaDatosNEGOCIO;
using Rotativa;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrototipoMINVU.Controllers
{
    public class ControlController : Controller
    {
        // ---------------------------FUNCIONES PARA EL RETORNO DE VISTAS

        public ActionResult ControlSistemas()
        {
            var alerta = Session["UsuarioConfirmado"];
            if (alerta != null)
            {
                return View();
            }
            else
                return RedirectToAction("Login", "Seguridad");
        }

        public ActionResult ReporteSistemas()
        {
            var alerta = Session["UsuarioConfirmado"];
            if (alerta != null)
            {
                Models.Registro cargador = new Models.Registro();

                cargador.CargaModulos();
                cargador.CargaSistemas();
                return View(cargador);
            }
            else
                return RedirectToAction("Login", "Seguridad");
        }

  

        // ---------------------FUNCIONES BACKEND PARA EL FUNCIONAMIENTO DEL SISTEMA.
        public ActionResult GenerarPDFModulo(int id_reportemodulo)
        {
            // Establece el nombre de la vista que deseas convertir en PDF
            string reporteVista = "pdfModulo";

            // Se crea un modelo que contenga los datos que se envian a la vista
            
            Models.Registro cargador = new Models.Registro();
            cargador.id_reportesistema = id_reportemodulo; 
            cargador.CargaModulobyID(id_reportemodulo);
            cargador.CargaIntegraciones();

            cargador.GenerarReporteModulo(id_reportemodulo);



            // Genera la vista como un PDF
            var pdf = new ViewAsPdf(reporteVista, cargador)
            {
                // Configura opciones adicionales aquí
                FileName = "ReportePrototipo.pdf",
                PageSize = Rotativa.Options.Size.Folio,
                PageMargins = new Rotativa.Options.Margins(5, 10, 5, 10)
            };

            // Convierte el PDF en un array de bytes
            byte[] pdfData = pdf.BuildFile(ControllerContext);

            // Establece el tipo MIME para que el navegador muestre el PDF
            Response.AddHeader("Content-Disposition", "inline; filename=ReportePrototipo.pdf");

            // Devuelve el PDF como un FileResult
            return File(pdfData, "application/pdf");
        }

        public ActionResult GenerarPDFSistema(int id_reportesistema)
        {
            // Establece el nombre de la vista que deseas convertir en PDF
            string reporteVista = "pdfSistemas";

            // Se crea un modelo que contenga los datos que se envian a la vista

            Models.Registro cargador = new Models.Registro();
            cargador.id_reportesistema = id_reportesistema;

            cargador.CargaSistemabyID(id_reportesistema);
            cargador.CargaIntegracionesby(id_reportesistema);



            // Genera la vista como un PDF
            var pdf = new ViewAsPdf(reporteVista, cargador)
            {
                // Configura opciones adicionales aquí
                FileName = "ReportePrototipo.pdf",
                PageSize = Rotativa.Options.Size.Folio,
                PageMargins = new Rotativa.Options.Margins(5, 10, 5, 10)
            };

            // Convierte el PDF en un array de bytes
            byte[] pdfData = pdf.BuildFile(ControllerContext);

            // Establece el tipo MIME para que el navegador muestre el PDF
            Response.AddHeader("Content-Disposition", "inline; filename=ReportePrototipo.pdf");

            // Devuelve el PDF como un FileResult
            return File(pdfData, "application/pdf");
        }






        // CONTROL PARA LOS SISTEMAS Y SUS CARACTERISTICAS.

        [HttpGet]
        public JsonResult ReporteSISTEMAXVARIABLE(string control_select)
        {
            SistemasBUSINESS cargador = new SistemasBUSINESS();
            List<ReporteGeneralBO> objLista = new List<ReporteGeneralBO>();

            objLista = cargador.ReporteSISTEMAXVARIABLE(control_select);

            return Json(objLista, JsonRequestBehavior.AllowGet);
        }


        // CONTROL PARA LOS MODULOS (Caracteristicas generales, depende del parámetro "control_select")

        [HttpGet]
        public JsonResult ReporteMODULOXVARIABLE(string control_select)
        {
            SistemasBUSINESS cargador = new SistemasBUSINESS();
            List<ReporteGeneralBO> objLista = new List<ReporteGeneralBO>();

            objLista = cargador.ReporteSUBSISTEMAXVARIABLE(control_select);

            return Json(objLista, JsonRequestBehavior.AllowGet);
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
