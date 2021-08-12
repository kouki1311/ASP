@ModelType IEnumerable(Of asp_4270.Table)
@Code
ViewData("Title") = "Index"
End Code
<style>
    .1{
        color:#000002
    }
</style>
<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th class="1">
            @Html.DisplayNameFor(Function(model) model.Id)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.顧客名)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.フリガナ)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.性別)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.会社名)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.住所)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
    <td>
        @Html.DisplayFor(Function(modelItem) item.Id)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.顧客名)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.フリガナ)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.性別)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.会社名)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.住所)
    </td>
    <td>
        @Html.ActionLink("Edit", "Edit", New With {.id = item.Id}) |
        @Html.ActionLink("Details", "Details", New With {.id = item.Id}) |
        @Html.ActionLink("Delete", "Delete", New With {.id = item.Id})
    </td>
</tr>
Next

</table>
