@ModelType IEnumerable(Of PetStore.PetVM)

<style>
    img {
        height: 100px;
    }
</style>

@If SessionManager.IsManager Then
    @<p>
        @Html.ActionLink("Create New", "Create")
    </p>
End If


<form>
<div class="form-group">
    <label for="fromPrice">From Price</label>
    <input type="number" class="form-control" id="fromPrice" aria-describedby="emailHelp">
</div>
<div class="form-group">
    <label for="toPrice">To Price</label>
    <input type="number" class="form-control" id="toPrice">
</div>
<div class="form-group">
    <label for="name">Name</label>
    <input type="text" class="form-control" id="name">
</div>
<button id="button" type="submit" class="btn btn-primary glyphicon-search search">Search</button>
</form>


<table class="table">
    <tr>
        <th>id</th>
        <th>name</th>
        <th>price</th>
        <th>how it look</th>
    </tr>

    @For Each item In Model
        @<tr>

            <td>
                @item.Id
            </td>
            <td>
                @item.Name
            </td>
            <td>
                @item.Price
            </td>
            <td>
                <img src="@item.Image" class="rounded">
            </td>
            @If SessionManager.IsManager Then
                @<td>
                    @Html.ActionLink("Edit", "Edit", New With {.id = item.Id}) |
                    @Html.ActionLink("Delete", "Delete", New With {.id = item.Id})
                </td>
            End If

        </tr>
    Next

</table>
</div>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
<script src="~/Scripts/Home/PetList.js"></script>