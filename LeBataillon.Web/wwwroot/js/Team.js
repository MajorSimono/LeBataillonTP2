var dataTable;

if ($("#titre").text() == "The Battalion") {
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
}
else {
    $(document).ready(function () {
        loadDataTable();
    });

    function loadDataTable() {
        dataTable = $("#tblData").DataTable({

            language: {
                processing: "Traitement en cours...",
                search: "Rechercher&nbsp;:",
                lengthMenu: "Afficher _MENU_ &eacute;l&eacute;ments",
                info: "Affichage de l'&eacute;lement _START_ &agrave; _END_ sur _TOTAL_ &eacute;l&eacute;ments",
                infoEmpty: "Affichage de l'&eacute;lement 0 &agrave; 0 sur 0 &eacute;l&eacute;ments",
                infoFiltered: "(filtr&eacute; de _MAX_ &eacute;l&eacute;ments au total)",
                infoPostFix: "",
                loadingRecords: "Chargement en cours...",
                zeroRecords: "Aucun &eacute;l&eacute;ment &agrave; afficher",
                emptyTable: "Aucune donnée disponible dans le tableau",
                paginate: {
                    first: "Premier",
                    previous: "Pr&eacute;c&eacute;dent",
                    next: "Suivant",
                    last: "Dernier"
                },
                aria: {
                    sortAscending: ": activer pour trier la colonne par ordre croissant",
                    sortDescending: ": activer pour trier la colonne par ordre décroissant"
                }
            },

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
                            <i class="fas fa-edit">Éditer</i>
                            </a>
              <a href="/Team/Details/${data}" class="btn btn-info text-white"style="cursor:pointer">
              <i class="fas fa-info-circle">Détails</i>
            </a>
              <a href="/Team/Delete/${data}" class="btn btn-danger text-white" style="cursor:pointer">
                <i class="fas fa-trash-alt">Supprimer</i>
              </a>
            </div>
               `;
                    }, "width": "25%"
                }
            ]
        })



    }
}