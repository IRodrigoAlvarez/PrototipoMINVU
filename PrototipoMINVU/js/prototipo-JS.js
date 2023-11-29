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









