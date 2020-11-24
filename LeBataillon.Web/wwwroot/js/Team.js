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
            { "data": "TeamName", "width": "20%" },
            { "data": "CapitaineId", "width": "10%" },
            { "data": "JoueurMaximum", "width": "10%" },

            {
                "data": "id",
                "render": function (data) {
                    return `
                    <div class="text-center">
                        <a href="/Team/Edit/${data}" class="btn btn-success text-white"style="cursor:pointer">
                        <i class="fas fa-edit"></i>
                        </a>
          <a href="/Team/Details/${data}" class="btn btn-info text-white"style="cursor:pointer">
          <i class="fas fa-info-circle"></i>
        </a>
          <a onclick=Delete("/Team/Delete/${data}") class="btn btn-danger text-white" style="cursor:pointer">
            <i class="fas fa-trash-alt"></i>
          </a>
        </div>
           `;
                }, "width": "25%"
            }
        ]
    })



}