using CapaDatosBO;
using CapaDatosNEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrototipoMINVU.Models
{
    public class Usuario
    {        
        [Required]
        public int Rut { get; set; }


        [Required]
        public string Contrasena { get; set; }


        [Required]
        public string ContrasenaNueva { get; set; }



        public string Nombre { get; set; }

        [Required]

        public string Repetircontraseña { get; set; }


        public string CorreoElectronico { get; set; }




        public int IdTipoUsuario { get; set; }
        public string TipoUsuario { get; set; }

        public List<UsuarioBO> ListaTipoUsuarios { get; set; }









        public void CargatipoUsuarios() 
        {
            UsuarioBO usuario = new UsuarioBO();
            UsuarioBUSINESS cargador = new UsuarioBUSINESS();

            usuario.ListaTipoUsuario = cargador.CargaTipoUsuarios();

            ListaTipoUsuarios = usuario.ListaTipoUsuario;
        
        
        }

    }
}