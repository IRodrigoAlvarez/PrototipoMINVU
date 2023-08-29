// javascript para abrir el formulario de los sistemas 



function GenerarListaproyectos() {
    let IDseleccion = document.getElementById("idSistema").value;
    $("#textindexregistro").hide();

    if (IDseleccion == 1) {
        $("#comboProyectosMUNIN").show();
        $("#tablaMunin").show();
        
        

    } else {
        $("#textindexregistro").show();
        $("#tablaMunin").hide();
        $("#comboProyectosMUNIN").hide();


    }






  





    if (IDseleccion == 2) {
        $("#proyectosTraza").show();

    }
    if (IDseleccion == 3) {

        $("#proyectosRUKAN").show();

    }
    if (IDseleccion == 4) {

        $("#proyectosUMBRAL").show();

    }
    if (IDseleccion == 5) {
        $("#proyectosSNAT").show();

    }
    if (IDseleccion == 6) {
        $("#proyectosSPS").show();

    }
}


function GenerarComboAction() {
    $("#comboAction").show();

}


function GenerarFormulario(){

    let IDseleccion = document.getElementById("id_accion_drop").value;

    //agregar proyecto
    if (IDseleccion == 1) {
        $("#FormularioAgregarProyecto").show();
        
    }


}






//examples














/*filtro de busqueda, paginacion y cantidad de registros.*/
$(document).ready(function () {
    //GeneraDatatable();

    $("#indexCrilla").val();

    indexGrilla = (parseInt($("#indexCrilla").val()) - 1);

    if (indexGrilla > 1) {
        window.location.href = "#" + indexGrilla + "";
    }
  
    

});


function GeneraDatatable() {
    $('#datatableReg').DataTable({
        "dom": 'B<"float-right"i><"float-left"f>t<"float-left"l><"float-right"p><"clearfix">',
        "scrollY": "50vh",
        "scrollX": "100px",
        "scrollCollapse": true,
        "bScrollAutoCss": true,
        "bProcessing": true,
        "bRetrieve": true,
        "bJQueryUI": true,
        "bPaginate": false,
        "sScrollXInner": "110%",     
        language: {
            "sProcessing": "Procesando...",
            "sZeroRecords": "No se encontraron coincidencias",
            "sEmptyTable": "",
            "sInfoEmpty": "",
            "sInfoPostFix": "",
            "sSearch": "Buscar:",
            "sUrl": "",
            "sInfoThousands": ",",
            "sLoadingRecords": "Cargando...",
            "oPaginate": {
                "sFirst": "Primero",
                "sLast": "Último",
                "sNext": "Siguiente",
                "sPrevious": "Anterior"
            },
            "oAria": {
                "sSortAscending": ": Activar para ordenar la columna de manera ascendente",
                "sSortDescending": ": Activar para ordenar la columna de manera descendente"
            }

        }
    });
}


function ModalFonasa(rut, dv) {
    /*let dv = document.getElementById("dvPriorizador").value;*/
    $("#idrut").val(rut);
    $('#dv').val(dv);
    //    alert(rut);
    $(".modalDF2").load("../Home/DatosFonasa?rut=" + rut + "&dv=" + dv, function () {
        $("#ModalFonasa").modal({ show: true });
    });
}

//modal nuevo de priorizacion de interconsultas
function ModalPriorizacion(idIC, HistEspe,index) {
    parent.document.getElementById('abc').value = idIC;
    parent.document.getElementById('abc2').value = HistEspe;
    parent.document.getElementById('abc3').value = index;
    parent.document.getElementById('ModalPriori').onclick();
}

//**********************************************************************************
function ModalGrabarInterConsulta() {

    //if ($("#seleccionarrederivar").val() == "") {
    //    alert("establecimiento es obligatorio");
    //    $("#errorEstablecimiento").css("display", "block");
    //    $("#seleccionarrederivar").focus();

    //    return false;
    //}

    //if ($("#Cambiarespecialidaddestino").val() == "") {
    //    alert("establecimiento es obligatorio");
    //    return false;
    //}

    var srechazo = document.getElementById('sRechazo').value;
    var sCategoria = document.getElementById('sCategoria').value;
    var caRechazo = document.getElementById('caRechazo').value;
    var fechafallecimiento = document.getElementById('fechafallecimiento').value;
    if (sCategoria == 4) {
        if (srechazo == "" && srechazo != 14) {
            /*$('#sRechazo').prop('required', true);*/
            /*alert("Faltan campos marcados en rojo obligatorios por seleccionar.")*/
            document.getElementById("sRechazo").style.borderColor = 'red';
            document.getElementById("labelcamposrequeridos").style.display = 'block';
            
        } else {
            if (srechazo == 14 && caRechazo == "") {
                document.getElementById("caRechazo").style.borderColor = 'red';
                document.getElementById("sRechazo").style.borderColor = 'gray';
                document.getElementById("labelcamposrequeridos").style.display = 'block';
            }
            else {
                if (srechazo == 1 || srechazo == 2 || srechazo == 8 || srechazo == 9 || srechazo == 10 || srechazo == 17 || caRechazo == 4 || caRechazo == 12) {
                    if (fechafallecimiento == "") {
                        document.getElementById("fechafallecimiento").style.borderColor = 'red';
                        document.getElementById("sRechazo").style.borderColor = 'gray';
                        document.getElementById("caRechazo").style.borderColor = 'gray';
                        document.getElementById("labelcamposrequeridos").style.display = 'block';
                    }
                    else {
                        document.getElementById("divContentPriori").style.display = 'none';
                        document.getElementById("modalDeseagrabar").style.display = 'block';
                        document.getElementById("boton-volverUP").style.display = 'none';
                    }

                } else {
                    document.getElementById("divContentPriori").style.display = 'none';
                    document.getElementById("modalDeseagrabar").style.display = 'block';
                    document.getElementById("boton-volverUP").style.display = 'none';
                }
                    

            }
        }
    }
     else {
        
        document.getElementById("divContentPriori").style.display = 'none';
        document.getElementById("modalDeseagrabar").style.display = 'block';
        document.getElementById("boton-volverUP").style.display = 'none';
    }



}


function grabardatos() {
    document.getElementById('formPriorizador').submit();
}




function cerrarDeseaGrabar() {  
    document.getElementById("modalDeseagrabar").style.display = 'none';
    document.getElementById("divContentPriori").style.display = 'block';
    document.getElementById("boton-volverUP").style.display = 'block';
}

//**********************************************************************************

function fModalPriorizar(idIC, HistEspe) {
    window.open('../Home/Priorizador' + '?idIC=' + idIC + '&HistEspe=' + HistEspe);
}

function fModalPriorizar2(idIC) {
    var formData = new FormData();
    formData.append("idIC", idIC.value);
    $('#idBloqueo').html('');
    $.ajax({
        type: "post",
        url: "../Home/Bloquear",
        data: formData,
        dataType: 'json',
        success: function (response) {
            $.each(response.lineas, function (obj) {
                $('#idBloqueo').append(obj.bloqueoIc);

            })

        },
        error: function (error) {
            $('#GeneralSection').html(error.responseText);
        }
    });

}



/* funcion exportar index */
function fBtnExportar() {
    const $btnExportar = document.querySelector("#btnExportar"),
        $datatablePriori = document.querySelector("#datatableReg");

    //Quitar ver y PDF
    $("#datatableReg th:first-child, #datatableReg td:first-child").remove();
    $("#datatableReg th:first-child, #datatableReg td:first-child").remove();   

    let tableExport = new TableExport($datatablePriori,
        {
            exportButtons: false,
            filename: "Interconsultas-report",
            sheetname: "Mi tabla de Excel",
        });

    let datos = tableExport.getExportData();
    let preferenciasDocumento = datos.datatablePriori.xlsx;
    tableExport.export2file(preferenciasDocumento.data, preferenciasDocumento.mimeType, preferenciasDocumento.filename, preferenciasDocumento.fileExtension, preferenciasDocumento.merges, preferenciasDocumento.RTL, preferenciasDocumento.sheetname);
    location.reload();
}

//funcion leslie
function OpenVentana(pagina, nTop, nLeft, nHeight, nWidth) {
    
    window.scrollTo(0, 0);
    var width = document.documentElement.clientWidth + document.documentElement.scrollLeft;
    var height = document.documentElement.clientHeight + document.documentElement.scrollTop;
    var layer = document.createElement("div");
    layer.style.zIndex = 2;
    layer.id = "layer";
    layer.style.position = "absolute";
    layer.style.top = "0px";
    layer.style.left = "0px";
    layer.style.height = "100%";
    layer.style.width = "100%";
    layer.style.backgroundColor = "black";
    layer.style.opacity = "0.68";
    layer.style.filter += ("progid:DXImageTransform.Microsoft.Alpha(opacity=68)");
    document.body.style.position = "static";
    document.body.appendChild(layer);
    var iframe = document.createElement("iframe");
    iframe.name = "popup";
    iframe.id = "popup";
    iframe.style.borderRadius = "15px";
    iframe.src = pagina + document.getElementById('abc').value + '&HistEspe=' + document.getElementById('abc2').value + '&index=' + document.getElementById('abc3').value;
    iframe.style.position = "fixed";
    iframe.style.zIndex = 3;
    iframe.style.backgroundColor = "white";
    iframe.frameBorder = "0";
    iframe.style.height = nHeight;
    iframe.style.width = nWidth;
    iframe.style.top = nTop;
    iframe.style.left = nLeft;
    document.body.appendChild(iframe);

}




//funcion cerrar modal leslie
function ClosePop() {
    var layer = document.getElementById("layer");
    var iframe = document.getElementById("popup");
    document.body.removeChild(layer); // remove layer
    document.body.removeChild(iframe); // remove div
}


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







