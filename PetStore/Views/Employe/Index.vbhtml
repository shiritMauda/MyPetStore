@ModelType IEnumerable(Of PetStore.UserVM)

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>id</th>
        <th>name</th>
        <th>age</th>
        <th>email</th>
        <th>roles</th>
    </tr>

    @For Each item In Model
        @<tr>

    <td>
        @item.id
    </td>
    <td>
        @item.Name
    </td>
    <td>
        @item.Age
    </td>
    <td>
         @item.Email
    </td>
                <td>
    @item.Roles
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
