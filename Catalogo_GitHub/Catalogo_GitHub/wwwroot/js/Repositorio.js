$(document).ready(function () {
    ListarRepositorios()
});

$("#txtPesquisar").keyup(function () {
    ListarRepositorios()
});

function ListarRepositorios() {
    let query = $("#txtPesquisar").val()

    if (query=="") {
        $.post("./ListarRepositorios", function (data) {
                $("#divRep").html(data);
        });
    }
    else {
        $.post("./ListarRepositorios",
            `query=${query}`, function (data) {
                $("#divRep").html(data);
            });
    }

    
}