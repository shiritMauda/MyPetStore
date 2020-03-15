@ModelType IEnumerable(Of MyPetStore.UserVM)
   @*<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">*@


@*<p>
    @Html.ActionLink("Create New", "Create")
</p>*@

<div class="card-deck">
    @For Each item In Model
        @<div class="card" style="width:400px">
            <img class="card-img-top" src="@item.Image" alt="Card image" style="width:100%">
            <div class="card-body">
                <h4 class="card-title">@item.Name</h4>
                <p class="card-text">@item.Desc</p>
                <a href="@Url.Action("Details", "Employee", New With {.id = item.Id})" class="btn btn-primary">See details</a>
            </div>
        </div>
    Next
</div>

@*<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>*@
@*<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>*@
@*<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>*@