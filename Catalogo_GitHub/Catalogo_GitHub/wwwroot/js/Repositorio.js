function ListarRepositorios(pageNumber, pageSize) {
    let query = $("#txtPesquisar").val()

    let parameters = `pageNumber=${pageNumber}&pageSize=${pageSize}`

    if (query != "") {
        parameters += `&query=${query}`     
    }

    $.post("./ListarRepositorios",
       parameters, function (data) {
           $("#divRep").html(data);
           $(`#page_${pageNumber}`).addClass('active')
    });

    
    
}