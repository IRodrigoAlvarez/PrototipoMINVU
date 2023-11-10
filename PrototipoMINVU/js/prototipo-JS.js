// javascript para abrir el formulario de los sistemas 



function bloqdes()
{
    var sistemaOrigen = $('#id_sistemaorigen');
    var moduloOrigen = $('#id_moduloorigen');

    var selectedValueSistema = sistemaOrigen.val();
    var selectedValueModulo = moduloOrigen.val();

    if (selectedValueSistema === "") {
        moduloOrigen.prop('disabled', false); // Habilita el elemento
    } else {
        moduloOrigen.prop('disabled', true); // Deshabilita el elemento
    }
    
    if (selectedValueModulo === "") {
        sistemaOrigen.prop('disabled', false); // Habilita el elemento
    } else {
        sistemaOrigen.prop('disabled', true); // Deshabilita el elemento
    }
}






function GenerarListaAmbiente() {

    let IDseleccion = document.getElementById("idAmbiente").value;
    $("#textindexregistro").hide();
    $("#tablaMODULOS").hide();

    if (IDseleccion == 1) {
        $("#tablaSISTEMASenproduccion").hide();
        $("#tablaSISTEMASendesarrollo").show();
        $("#tablaSISTEMASentesting").hide();

    }
    if (IDseleccion == 2) {
        $("#tablaSISTEMASenproduccion").hide();
        $("#tablaSISTEMASendesarrollo").hide();
        $("#tablaSISTEMASentesting").show();

    }
    if (IDseleccion == 3) {
        $("#tablaSISTEMASenproduccion").show();
        $("#tablaSISTEMASendesarrollo").hide();
        $("#tablaSISTEMASentesting").hide();


    }   
    
}



function abreForm() {

    $("#containerEditSistema").show();
} 




function GenerarListasubsistemas() {
    let IDseleccion = document.getElementById("idSistema").value;
    $("#textindexregistro").hide();



    if (IDseleccion == 1) {
        $("#contSubSI").show();
        $("#tablaSISTEMASenproduccion").show();
        
        

    } else {
        $("#textindexregistro").show();
        $("#tablaSISTEMASenproduccion").hide();
        $("#containerSubSI").hide();


    }

}



function GenerarFormulario(){

    let IDseleccion = document.getElementById("id_subsistema").value;

    //agregar proyecto
    if (IDseleccion == 1) {
        $("#FormularioEditarSistema").show();
        
    }


}








//examples


function fBtnExportar2() {
	$('#modalCargando').show();						   
    $.ajax({
        type: "post",
        url: "../Home/excel",
        data:
        {
            'intRut': document.getElementById("data_intRut").value,
            'strNombre': document.getElementById("data_strNombre").value,
            'strApellidoPaterno': document.getElementById("data_strApellidoPaterno").value,
            'idrangoetario': document.getElementById("data_idrangoetario").value,
            'FechaEmisionDesde': document.getElementById("data_FechaEmisionDesde").value,
            'FechaEmisionHasta': document.getElementById("data_FechaEmisionHasta").value,
            'FechaCategorizacionDesde': document.getElementById("data_FechaCategorizacionDesde").value,
            'FechaCategorizacionHasta': document.getElementById("data_FechaCategorizacionHasta").value,
            'EstablecimientoD': document.getElementById("data_EstablecimientoD").value,
            'Especialidad': document.getElementById("data_Especialidad").value,
            'idsubespe': document.getElementById("data_idsubespe").value,
            'estado': document.getElementById("data_estado").value,
            'idprocedimiento': document.getElementById("data_idprocedimiento").value,
            'idusucategorizador': document.getElementById("data_idusucategorizador").value,
            'idusupriorizador': document.getElementById("data_idusupriorizador").value,
            'idusurechazo': document.getElementById("data_idusurechazo").value
        },
        success: function (response)
        {
            
            $('#modalCargando').hide();
            if (response != "0") {
                window.location.href = window.location.href.replace("Home/TraerFiltrosParaInterconsultas", "") + "/Home/" + response + "";
                setInterval(function () {
                    deleteExportar(response);
                }, 30000);                               
            } else {
                Swal.fire({
                    position: 'center',
                    icon: 'info',
                    allowOutsideClick: false,
                    title: "INFORMATIVO",
                    showConfirmButton: true,
                    html: '<label>Sin registros para descargar</label>'
                });
            }

        },
        error: function (error) {
			$('#modalCargando').hide();						   
        
        }
    });
}

function deleteExportar(path) {
    $.ajax({
        type: "post",
        url: "../Home/QuitarExcel",
        data: {
            'path': path,
        },
        success: function (response) {

        },
        error: function (error) {
            console.log(error);
        }
    });
}







