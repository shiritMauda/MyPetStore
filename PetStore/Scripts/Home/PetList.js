$(document).ready(function () {
    $("#button").on("click", function (e) {
        e.preventDefault();
            console.log("Submit!");
            filterTable($("#fromPrice").val(),$("#toPrice").val(),$("#name").val())
        });
})

function filterTable(fromPrice, toPrice, name) {
    var petList;
    petList = $.get("/api/Pet/GetList?fromPrice=" + fromPrice + "?toPrice=" + toPrice + "?name=" + name);
    console.log("finish get");
}
