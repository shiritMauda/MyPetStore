$(document).ready(function () {
    $("#form").on("submit", function (e) {
        e.preventDefault();
        console.log("Submit!");
        resetTable();
        var params = "";
        var fromPrice = $("#fromPrice").val();
        var toPrice = $("#toPrice").val();
        var name = $("#name").val();

        params = params + "fromPrice="
        if (fromPrice) {
            params = params + fromPrice;
        } else {
            params = params + "0";
        }

        params = params + "&toPrice="
        if (toPrice) {
            params = params + toPrice;
            } else {
            params = params + "100000";
            }

        params = params + "&name="
        if (name) {
           
            params = params + name;
            } else {
                params = params + "";
            }

  
        console.log('params: ', params);
        const url = '/api/pet/GetList?' + params;
        $.get(url, showPets);
        });
})


    
function resetTable() {
    $(".row").remove();
}

function showPets(res) {
    
    console.log(res);

    for (i = 0; i < res.length; i++) {
        var id = res[i].Id;
        var name = res[i].Name;
        var price = res[i].Price;
        var image = res[i].Image;
       
        var markup = "<tr class='row'><td id='id'>" + id + "</td><td>" + name + "</td><td>" + price + "</td><td><img src=" + image + " class='rounded'> </td>";
        
        
        $("table tbody").append(markup  + "</tr >");
    }
}