@ModelType MyPetStore.PetVM

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
    <h4>Product</h4>
    <div class="form-control">

        @Html.TextBoxFor(Function(model) model.Id, New With {.id = "Id", .class = "form-field"})
    </div>
    <div class="form-control">
        @Html.LabelFor(Function(model) model.Name)
        @Html.TextBoxFor(Function(model) model.Name, New With {.id = "Name", .class = "form-field"})
    </div>
    <div class="form-control">
        @Html.LabelFor(Function(model) model.Price)
        @Html.TextBoxFor(Function(model) model.Price, New With {.id = "Price", .class = "form-field"})
    </div>
    <div class="form-control">
        @Html.LabelFor(Function(model) model.Image)
        @Html.TextBoxFor(Function(model) model.Image, New With {.id = "Image", .class = "form-field"})
    </div>
    <hr />
    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <input type="submit" value="Save" class="btn btn-default" />
        </div>
    </div>
</div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>
<script src="~/Scripts/jquery-3.4.1.min.js "></script>
<script src="~/Scripts/jquery.validate.min.js"></script>
<script src="~/Scripts/jquery.validate.unobtrusive.min.js"></script>

