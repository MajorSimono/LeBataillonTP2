var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $("#tblData").DataTable({
        "ajax": {
            "url": "/Player/GetAll"
        },
        "columns": [
            { "data": "NickName", "width": "20%" },
            { "data": "Email", "width": "10%" },
            { "data": "PhoneNumber", "width": "10%" },
            { "data": "FirstName", "width": "20%" },
            { "data": "LastName", "width": "20%" },
            { "data": "Level", "width": "10%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                    <div class="text-center">
                        <a href="/Player/Edit/${data}" class="btn btn-success text-white"style="cursor:pointer">
                        <i class="fas fa-edit"></i>
                        </a>
          <a href="/Player/Details/${data}" class="btn btn-info text-white"style="cursor:pointer">
          <i class="fas fa-info-circle"></i>
        </a>
          <a onclick=Delete("/Player/Delete/${data}") class="btn btn-danger text-white" style="cursor:pointer">
            <i class="fas fa-trash-alt"></i>
          </a>
        </div>
           `;
                }, "width": "25%"
            }
        ]
    })



}