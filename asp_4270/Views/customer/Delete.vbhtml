@ModelType asp_4270.Table
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Table</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.顧客名)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.顧客名)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.フリガナ)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.フリガナ)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.性別)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.性別)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.会社名)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.会社名)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.住所)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.住所)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
