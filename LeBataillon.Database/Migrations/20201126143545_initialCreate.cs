﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeBataillon.Database.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NickName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Level = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(maxLength: 25, nullable: false),
                    CaptainId = table.Column<int>(nullable: false),
                    JoueurMaximum = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Players_CaptainId",
                        column: x => x.CaptainId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameDateTime = table.Column<DateTime>(nullable: false),
                    TeamDefendantId = table.Column<int>(nullable: true),
                    TeamAttackerId = table.Column<int>(nullable: true),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Teams_TeamAttackerId",
                        column: x => x.TeamAttackerId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_Teams_TeamDefendantId",
                        column: x => x.TeamDefendantId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Description", "Email", "FirstName", "LastName", "Level", "NickName", "PhoneNumber", "TeamId" },
                values: new object[,]
                {
                    { 1, "Description du joueur", "Adrian@bataillonMail.com", "Adrian", "Jonkruojis", 0, "AdrianAlias", "214-764-3816", 1 },
                    { 72, "Description du joueur", "Ralph@bataillonMail.com", "Ralph", "Vadtälje", 0, "RalphAlias", "381-864-2587", 4 },
                    { 71, "Description du joueur", "Jamal@bataillonMail.com", "Jamal", "Nuugaatrapaluk", 0, "JamalAlias", "764-635-6174", 8 },
                    { 70, "Description du joueur", "Pat@bataillonMail.com", "Pat", "Steinstrand", 0, "PatAlias", "336-476-3561", 3 },
                    { 69, "Description du joueur", "Krissy@bataillonMail.com", "Krissy", "Reidcoln", 0, "KrissyAlias", "718-337-7156", 7 },
                    { 68, "Description du joueur", "Adrian@bataillonMail.com", "Adrian", "Jonkruojis", 0, "AdrianAlias", "373-188-3543", 3 },
                    { 67, "Description du joueur", "Johana@bataillonMail.com", "Johana", "Enbo", 0, "JohanaAlias", "645-741-8138", 7 },
                    { 66, "Description du joueur", "Debi@bataillonMail.com", "Debi", "Jaunli", 0, "DebiAlias", "228-612-4525", 2 },
                    { 65, "Description du joueur", "Sheridan@bataillonMail.com", "Sheridan", "Hammervåg", 0, "SheridanAlias", "682-453-1112", 7 },
                    { 64, "Description du joueur", "Pierre@bataillonMail.com", "Pierre", "Akssandur", 0, "PierreAlias", "255-214-5587", 2 },
                    { 63, "Description du joueur", "Tyson@bataillonMail.com", "Tyson", "Balniai", 0, "TysonAlias", "637-165-2175", 6 },
                    { 62, "Description du joueur", "Antonetta@bataillonMail.com", "Antonetta", "Rovanola", 0, "AntonettaAlias", "111-726-6562", 2 },
                    { 61, "Description du joueur", "Sherlene@bataillonMail.com", "Sherlene", "Salkile", 0, "SherleneAlias", "564-567-2157", 6 },
                    { 60, "Description du joueur", "Marcella@bataillonMail.com", "Marcella", "Kalvee", 0, "MarcellaAlias", "146-338-7544", 1 },
                    { 59, "Description du joueur", "Jane@bataillonMail.com", "Jane", "Ólafsholt", 0, "JaneAlias", "521-271-3131", 5 },
                    { 58, "Description du joueur", "Mariella@bataillonMail.com", "Mariella", "Dragstrup", 0, "MariellaAlias", "173-842-8526", 1 },
                    { 57, "Description du joueur", "Marcie@bataillonMail.com", "Marcie", "Nittinen", 0, "MarcieAlias", "555-683-4113", 5 },
                    { 56, "Description du joueur", "Liliana@bataillonMail.com", "Liliana", "Boswood", 0, "LilianaAlias", "828-544-8588", 9 },
                    { 55, "Description du joueur", "Alejandro@bataillonMail.com", "Alejandro", "Mõisali", 0, "AlejandroAlias", "482-315-5175", 5 },
                    { 54, "Description du joueur", "Roma@bataillonMail.com", "Roma", "Guasabaro", 0, "RomaAlias", "865-156-1562", 9 },
                    { 53, "Description du joueur", "Vi@bataillonMail.com", "Vi", "Ulhus", 0, "ViAlias", "437-728-6157", 4 },
                    { 52, "Description du joueur", "Tad@bataillonMail.com", "Tad", "Ixtatla", 0, "TadAlias", "811-661-2544", 9 },
                    { 73, "Description du joueur", "Arielle@bataillonMail.com", "Arielle", "Eqalunavik", 0, "ArielleAlias", "727-223-5112", 8 },
                    { 51, "Description du joueur", "Troy@bataillonMail.com", "Troy", "Norrviken", 0, "TroyAlias", "374-422-7131", 4 },
                    { 74, "Description du joueur", "Troy@bataillonMail.com", "Troy", "Lystrup", 0, "TroyAlias", "454-352-1525", 4 },
                    { 76, "Description du joueur", "Simonne@bataillonMail.com", "Simonne", "Haapsa", 0, "SimonneAlias", "418-758-8543", 4 },
                    { 97, "Description du joueur", "Steven@bataillonMail.com", "Steven", "Ulhus", 0, "StevenAlias", "435-313-3181", 4 },
                    { 96, "Description du joueur", "Tad@bataillonMail.com", "Tad", "Eqalunavik", 0, "TadAlias", "887-154-8576", 8 },
                    { 95, "Description du joueur", "Emely@bataillonMail.com", "Emely", "Norrviken", 0, "EmelyAlias", "362-715-4163", 4 },
                    { 94, "Description du joueur", "Jamal@bataillonMail.com", "Jamal", "Nuugaatrapaluk", 0, "JamalAlias", "744-566-1558", 8 },
                    { 93, "Description du joueur", "Cathryn@bataillonMail.com", "Cathryn", "Breksos", 0, "CathrynAlias", "317-427-5145", 3 },
                    { 92, "Description du joueur", "Eugenie@bataillonMail.com", "Eugenie", "Reidcoln", 0, "EugenieAlias", "771-268-2532", 8 },
                    { 91, "Description du joueur", "Marlon@bataillonMail.com", "Marlon", "Lazmerge", 0, "MarlonAlias", "354-831-6127", 3 },
                    { 90, "Description du joueur", "Ernestine@bataillonMail.com", "Ernestine", "Clarehurst", 0, "ErnestineAlias", "626-772-2514", 7 },
                    { 89, "Description du joueur", "Debi@bataillonMail.com", "Debi", "Kulli", 0, "DebiAlias", "288-543-7181", 2 },
                    { 88, "Description du joueur", "Leida@bataillonMail.com", "Leida", "Kungstuna", 0, "LeidaAlias", "663-384-3576", 7 },
                    { 87, "Description du joueur", "Derick@bataillonMail.com", "Derick", "Ísafholt", 0, "DerickAlias", "235-245-8163", 2 },
                    { 86, "Description du joueur", "Bianca@bataillonMail.com", "Bianca", "Brønnøyden", 0, "BiancaAlias", "618-816-4558", 6 },
                    { 85, "Description du joueur", "Nicholas@bataillonMail.com", "Nicholas", "Rovanola", 0, "NicholasAlias", "272-657-8145", 2 },
                    { 84, "Description du joueur", "Sherlene@bataillonMail.com", "Sherlene", "Kedainkai", 0, "SherleneAlias", "544-428-5532", 6 },
                    { 83, "Description du joueur", "Conrad@bataillonMail.com", "Conrad", "Kalvee", 0, "ConradAlias", "127-361-1128", 1 },
                    { 82, "Description du joueur", "Berniece@bataillonMail.com", "Berniece", "Ketne", 0, "BernieceAlias", "581-122-6515", 6 },
                    { 81, "Description du joueur", "Tonita@bataillonMail.com", "Tonita", "Dragstrup", 0, "TonitaAlias", "154-773-2182", 1 },
                    { 80, "Description du joueur", "Sheryl@bataillonMail.com", "Sheryl", "Hókrókur", 0, "SherylAlias", "536-634-7577", 5 },
                    { 79, "Description du joueur", "Liliana@bataillonMail.com", "Liliana", "Boswood", 0, "LilianaAlias", "888-475-3174", 9 },
                    { 78, "Description du joueur", "Angelina@bataillonMail.com", "Angelina", "Kalatee", 0, "AngelinaAlias", "463-246-7561", 5 },
                    { 77, "Description du joueur", "Sherise@bataillonMail.com", "Sherise", "Guasabaro", 0, "SheriseAlias", "845-887-4156", 9 },
                    { 75, "Description du joueur", "Marcell@bataillonMail.com", "Marcell", "Apatcruz", 0, "MarcellAlias", "872-511-5138", 9 },
                    { 98, "Description du joueur", "Roma@bataillonMail.com", "Roma", "Apatcruz", 0, "RomaAlias", "853-442-7514", 9 },
                    { 50, "Description du joueur", "Eugenio@bataillonMail.com", "Eugenio", "Uummanqaq", 0, "EugenioAlias", "746-273-3526", 8 },
                    { 48, "Description du joueur", "Palmira@bataillonMail.com", "Palmira", "Flatwood", 0, "PalmiraAlias", "783-785-4588", 8 },
                    { 22, "Description du joueur", "Debi@bataillonMail.com", "Debi", "Kulli", 0, "DebiAlias", "232-327-7464", 2 },
                    { 21, "Description du joueur", "Leida@bataillonMail.com", "Leida", "Hammervåg", 0, "LeidaAlias", "684-168-3851", 7 },
                    { 20, "Description du joueur", "Derick@bataillonMail.com", "Derick", "Ísafholt", 0, "DerickAlias", "266-721-7446", 2 },
                    { 19, "Description du joueur", "Tyson@bataillonMail.com", "Tyson", "Brønnøyden", 0, "TysonAlias", "641-572-4833", 6 },
                    { 18, "Description du joueur", "Nicholas@bataillonMail.com", "Nicholas", "Rovanola", 0, "NicholasAlias", "213-433-8428", 2 },
                    { 17, "Description du joueur", "Sherlene@bataillonMail.com", "Sherlene", "Kedainkai", 0, "SherleneAlias", "576-284-5815", 6 },
                    { 16, "Description du joueur", "Conrad@bataillonMail.com", "Conrad", "Kalvee", 0, "ConradAlias", "158-845-1482", 1 },
                    { 15, "Description du joueur", "Berniece@bataillonMail.com", "Berniece", "Ketne", 0, "BernieceAlias", "523-786-6877", 6 },
                    { 14, "Description du joueur", "Mariella@bataillonMail.com", "Mariella", "Dragstrup", 0, "MariellaAlias", "185-557-2464", 1 },
                    { 13, "Description du joueur", "Sheryl@bataillonMail.com", "Sheryl", "Hókrókur", 0, "SherylAlias", "567-318-6851", 5 },
                    { 12, "Description du joueur", "Liliana@bataillonMail.com", "Liliana", "Boswood", 0, "LilianaAlias", "832-151-3446", 9 },
                    { 11, "Description du joueur", "Angelina@bataillonMail.com", "Angelina", "Kalatee", 0, "AngelinaAlias", "414-822-7833", 5 },
                    { 10, "Description du joueur", "Sherise@bataillonMail.com", "Sherise", "Guasabaro", 0, "SheriseAlias", "877-663-4428", 10 },
                    { 9, "Description du joueur", "Vi@bataillonMail.com", "Vi", "Haapsa", 0, "ViAlias", "441-434-8815", 9 },
                    { 8, "Description du joueur", "Marcell@bataillonMail.com", "Marcell", "Ixtatla", 0, "MarcellAlias", "823-375-4482", 8 },
                    { 7, "Description du joueur", "Troy@bataillonMail.com", "Troy", "Lystrup", 0, "TroyAlias", "476-136-1877", 7 },
                    { 6, "Description du joueur", "Arielle@bataillonMail.com", "Arielle", "Eqalunavik", 0, "ArielleAlias", "758-787-5464", 6 },
                    { 5, "Description du joueur", "Ralph@bataillonMail.com", "Ralph", "Vadtälje", 0, "RalphAlias", "333-648-2851", 5 },
                    { 4, "Description du joueur", "Palmira@bataillonMail.com", "Palmira", "Nuugaatrapaluk", 0, "PalmiraAlias", "785-411-6446", 4 },
                    { 3, "Description du joueur", "Pat@bataillonMail.com", "Pat", "Steinstrand", 0, "PatAlias", "367-252-3834", 3 },
                    { 2, "Description du joueur", "Krissy@bataillonMail.com", "Krissy", "Reidcoln", 0, "KrissyAlias", "742-813-7421", 2 },
                    { 23, "Description du joueur", "Ernestine@bataillonMail.com", "Ernestine", "Enbo", 0, "ErnestineAlias", "657-456-2877", 7 },
                    { 49, "Description du joueur", "Cathryn@bataillonMail.com", "Cathryn", "Breksos", 0, "CathrynAlias", "321-134-7113", 3 },
                    { 24, "Description du joueur", "Adrian@bataillonMail.com", "Adrian", "Lazmerge", 0, "AdrianAlias", "375-615-6481", 3 },
                    { 26, "Description du joueur", "Cathryn@bataillonMail.com", "Cathryn", "Breksos", 0, "CathrynAlias", "348-183-5427", 3 },
                    { 47, "Description du joueur", "Marlon@bataillonMail.com", "Marlon", "Steinstrand", 0, "MarlonAlias", "355-546-8175", 3 },
                    { 46, "Description du joueur", "Krissy@bataillonMail.com", "Krissy", "Clarehurst", 0, "KrissyAlias", "738-487-5562", 7 },
                    { 45, "Description du joueur", "Rosetta@bataillonMail.com", "Rosetta", "Jonkruojis", 0, "RosettaAlias", "212-258-1157", 3 },
                    { 44, "Description du joueur", "Leida@bataillonMail.com", "Leida", "Kungstuna", 0, "LeidaAlias", "665-811-5544", 7 },
                    { 43, "Description du joueur", "Barbie@bataillonMail.com", "Barbie", "Jaunli", 0, "BarbieAlias", "247-652-2132", 2 },
                    { 42, "Description du joueur", "Bianca@bataillonMail.com", "Bianca", "Brønnøyden", 0, "BiancaAlias", "622-523-6527", 7 },
                    { 41, "Description du joueur", "Pierre@bataillonMail.com", "Pierre", "Akssandur", 0, "PierreAlias", "274-364-3114", 2 },
                    { 40, "Description du joueur", "Adell@bataillonMail.com", "Adell", "Kedainkai", 0, "AdellAlias", "556-135-7581", 6 },
                    { 39, "Description du joueur", "Conrad@bataillonMail.com", "Conrad", "Siukoski", 0, "ConradAlias", "131-876-4176", 1 },
                    { 38, "Description du joueur", "Dina@bataillonMail.com", "Dina", "Ketne", 0, "DinaAlias", "583-637-8563", 6 },
                    { 37, "Description du joueur", "Tonita@bataillonMail.com", "Tonita", "Loktu", 0, "TonitaAlias", "166-488-4158", 1 },
                    { 36, "Description du joueur", "Jane@bataillonMail.com", "Jane", "Hókrókur", 0, "JaneAlias", "548-241-1545", 5 },
                    { 35, "Description du joueur", "Magen@bataillonMail.com", "Magen", "Albro", 0, "MagenAlias", "112-112-5132", 1 },
                    { 34, "Description du joueur", "Angelina@bataillonMail.com", "Angelina", "Nittinen", 0, "AngelinaAlias", "475-753-2427", 5 },
                    { 33, "Description du joueur", "Jeanetta@bataillonMail.com", "Jeanetta", "Mensmere", 0, "JeanettaAlias", "857-514-6814", 9 },
                    { 32, "Description du joueur", "Simonne@bataillonMail.com", "Simonne", "Mõisali", 0, "SimonneAlias", "422-465-2481", 4 },
                    { 31, "Description du joueur", "Roma@bataillonMail.com", "Roma", "Apatcruz", 0, "RomaAlias", "884-226-7876", 9 },
                    { 30, "Description du joueur", "Steven@bataillonMail.com", "Steven", "Ulhus", 0, "StevenAlias", "456-877-3463", 4 },
                    { 29, "Description du joueur", "Arielle@bataillonMail.com", "Arielle", "Eqalunavik", 0, "ArielleAlias", "831-638-8858", 8 },
                    { 28, "Description du joueur", "Emely@bataillonMail.com", "Emely", "Norrviken", 0, "EmelyAlias", "313-571-4445", 4 },
                    { 27, "Description du joueur", "Jamal@bataillonMail.com", "Jamal", "Nuugaatrapaluk", 0, "JamalAlias", "766-342-1832", 8 },
                    { 25, "Description du joueur", "Eugenie@bataillonMail.com", "Eugenie", "Reidcoln", 0, "EugenieAlias", "722-844-1814", 8 },
                    { 99, "Description du joueur", "Simonne@bataillonMail.com", "Simonne", "Mõisali", 0, "SimonneAlias", "478-681-3127", 5 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CaptainId", "Description", "JoueurMaximum", "TeamName" },
                values: new object[,]
                {
                    { 1, 1, "Description de l'éqiupe", 10, "Équipe de Adrian" },
                    { 2, 2, "Description de l'éqiupe", 10, "Équipe de Krissy" },
                    { 3, 3, "Description de l'éqiupe", 10, "Équipe de Pat" },
                    { 4, 4, "Description de l'éqiupe", 10, "Équipe de Palmira" },
                    { 5, 5, "Description de l'éqiupe", 10, "Équipe de Ralph" },
                    { 6, 6, "Description de l'éqiupe", 10, "Équipe de Arielle" },
                    { 7, 7, "Description de l'éqiupe", 10, "Équipe de Troy" },
                    { 8, 8, "Description de l'éqiupe", 10, "Équipe de Marcell" },
                    { 9, 9, "Description de l'éqiupe", 10, "Équipe de Vi" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "GameDateTime", "TeamAttackerId", "TeamDefendantId", "status" },
                values: new object[] { 1, new DateTime(220, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 2 });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "GameDateTime", "TeamAttackerId", "TeamDefendantId", "status" },
                values: new object[] { 2, new DateTime(220, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4, 2 });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "GameDateTime", "TeamAttackerId", "TeamDefendantId", "status" },
                values: new object[] { 3, new DateTime(220, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 7, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Games_TeamAttackerId",
                table: "Games",
                column: "TeamAttackerId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_TeamDefendantId",
                table: "Games",
                column: "TeamDefendantId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CaptainId",
                table: "Teams",
                column: "CaptainId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
