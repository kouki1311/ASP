@ModelType asp_4270.Table
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
