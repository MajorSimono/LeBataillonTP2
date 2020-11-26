var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $("#tblData").DataTable({
        "ajax": {
            "url": "/Team/GetAll"
        },
        "columns": [
            { "data": "teamName", "width": "20%" },
            { "data": "captainId", "width": "10%" },
            { "data": "joueurMaximum", "width": "10%" },

            {
                "data": "id",
                "render": function (data) {
                    return `
                    <div class="text-center">
                        <a href="/Team/Edit/${data}" class="btn btn-success text-white"style="cursor:pointer">
                        <i class="fas fa-edit">Edit</i>
                        </a>
          <a href="/Team/Details/${data}" class="btn btn-info text-white"style="cursor:pointer">
          <i class="fas fa-info-circle">Details</i>
        </a>
          <a href="/Team/Delete/${data}" class="btn btn-danger text-white" style="cursor:pointer">
            <i class="fas fa-trash-alt">Delete</i>
          </a>
        </div>
           `;
                }, "width": "25%"
            }
        ]
    })



}