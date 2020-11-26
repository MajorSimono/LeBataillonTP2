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
            { "data": "nickName", "width": "20%" },
            { "data": "email", "width": "10%" },
            { "data": "phoneNumber", "width": "10%" },
            { "data": "firstName", "width": "20%" },
            { "data": "lastName", "width": "20%" },
            { "data": "level", "width": "10%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                    <div class="text-center">
                        <a href="/Player/Edit/${data}" class="btn btn-success text-white"style="cursor:pointer">
                        <i class="fas fa-edit">Edit</i>
                        </a>
          <a href="/Player/Details/${data}" class="btn btn-info text-white"style="cursor:pointer">
          <i class="fas fa-info-circle">Details</i>
        </a>
          <a href="/Player/Delete/${data}" class="btn btn-danger text-white" style="cursor:pointer">
            <i class="fas fa-trash-alt">Delete</i>
          </a>
        </div>
           `;
                }, "width": "25%"
            }
        ]
    })



}