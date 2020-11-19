using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeBataillon.Database.Migrations
{
    public partial class AddGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameDateTime = table.Column<DateTime>(nullable: false),
                    TeamDefendantId = table.Column<int>(nullable: false),
                    TeamAttackerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NickName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false)
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
                    TeamName = table.Column<string>(nullable: true),
                    CaptainId = table.Column<int>(nullable: false)
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

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "GameDateTime", "TeamAttackerId", "TeamDefendantId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 9, 21, 16, 52, 2, 648, DateTimeKind.Local).AddTicks(8442), 8, 7 },
                    { 28, new DateTime(2020, 10, 18, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(330), 4, 3 },
                    { 29, new DateTime(2020, 10, 19, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(362), 8, 7 },
                    { 30, new DateTime(2020, 10, 20, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(395), 3, 2 },
                    { 31, new DateTime(2020, 10, 21, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(429), 6, 5 },
                    { 32, new DateTime(2020, 10, 22, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(460), 2, 1 },
                    { 33, new DateTime(2020, 10, 23, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(550), 5, 4 },
                    { 34, new DateTime(2020, 10, 24, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(586), 9, 8 },
                    { 35, new DateTime(2020, 10, 25, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(618), 4, 3 },
                    { 36, new DateTime(2020, 10, 26, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(648), 7, 6 },
                    { 37, new DateTime(2020, 10, 27, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(680), 3, 2 },
                    { 38, new DateTime(2020, 10, 28, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(710), 6, 5 },
                    { 39, new DateTime(2020, 10, 29, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(743), 2, 1 },
                    { 40, new DateTime(2020, 10, 30, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(774), 5, 4 },
                    { 41, new DateTime(2020, 10, 31, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(805), 8, 7 },
                    { 42, new DateTime(2020, 11, 1, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(837), 4, 3 },
                    { 43, new DateTime(2020, 11, 2, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(867), 7, 6 },
                    { 44, new DateTime(2020, 11, 3, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(897), 3, 2 },
                    { 45, new DateTime(2020, 11, 4, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(973), 6, 5 },
                    { 46, new DateTime(2020, 11, 5, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(1004), 9, 8 },
                    { 47, new DateTime(2020, 11, 6, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(1035), 5, 4 },
                    { 48, new DateTime(2020, 11, 7, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(1082), 8, 7 },
                    { 27, new DateTime(2020, 10, 17, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(299), 9, 8 },
                    { 26, new DateTime(2020, 10, 16, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(267), 5, 4 },
                    { 49, new DateTime(2020, 11, 8, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(1113), 4, 3 },
                    { 24, new DateTime(2020, 10, 14, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(204), 7, 6 },
                    { 2, new DateTime(2020, 9, 22, 16, 52, 2, 651, DateTimeKind.Local).AddTicks(9298), 4, 3 },
                    { 3, new DateTime(2020, 9, 23, 16, 52, 2, 651, DateTimeKind.Local).AddTicks(9425), 7, 6 },
                    { 4, new DateTime(2020, 9, 24, 16, 52, 2, 651, DateTimeKind.Local).AddTicks(9464), 3, 2 },
                    { 5, new DateTime(2020, 9, 25, 16, 52, 2, 651, DateTimeKind.Local).AddTicks(9498), 6, 5 },
                    { 6, new DateTime(2020, 9, 26, 16, 52, 2, 651, DateTimeKind.Local).AddTicks(9576), 9, 8 },
                    { 7, new DateTime(2020, 9, 27, 16, 52, 2, 651, DateTimeKind.Local).AddTicks(9609), 5, 4 },
                    { 25, new DateTime(2020, 10, 15, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(234), 2, 1 },
                    { 9, new DateTime(2020, 9, 29, 16, 52, 2, 651, DateTimeKind.Local).AddTicks(9672), 4, 3 },
                    { 10, new DateTime(2020, 9, 30, 16, 52, 2, 651, DateTimeKind.Local).AddTicks(9704), 7, 6 },
                    { 11, new DateTime(2020, 10, 1, 16, 52, 2, 651, DateTimeKind.Local).AddTicks(9735), 2, 1 },
                    { 12, new DateTime(2020, 10, 2, 16, 52, 2, 651, DateTimeKind.Local).AddTicks(9768), 6, 5 },
                    { 8, new DateTime(2020, 9, 28, 16, 52, 2, 651, DateTimeKind.Local).AddTicks(9640), 8, 7 },
                    { 14, new DateTime(2020, 10, 4, 16, 52, 2, 651, DateTimeKind.Local).AddTicks(9835), 5, 4 },
                    { 15, new DateTime(2020, 10, 5, 16, 52, 2, 651, DateTimeKind.Local).AddTicks(9866), 8, 7 },
                    { 16, new DateTime(2020, 10, 6, 16, 52, 2, 651, DateTimeKind.Local).AddTicks(9899), 3, 2 },
                    { 17, new DateTime(2020, 10, 7, 16, 52, 2, 651, DateTimeKind.Local).AddTicks(9931), 7, 6 },
                    { 18, new DateTime(2020, 10, 8, 16, 52, 2, 651, DateTimeKind.Local).AddTicks(9965), 2, 1 },
                    { 19, new DateTime(2020, 10, 9, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(44), 6, 5 },
                    { 20, new DateTime(2020, 10, 10, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(77), 9, 8 },
                    { 21, new DateTime(2020, 10, 11, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(108), 4, 3 },
                    { 22, new DateTime(2020, 10, 12, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(140), 8, 7 },
                    { 23, new DateTime(2020, 10, 13, 16, 52, 2, 652, DateTimeKind.Local).AddTicks(173), 3, 2 },
                    { 13, new DateTime(2020, 10, 3, 16, 52, 2, 651, DateTimeKind.Local).AddTicks(9802), 9, 8 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Level", "NickName", "PhoneNumber" },
                values: new object[,]
                {
                    { 64, "Pierre@bataillonMail.com", "Pierre", "Akssandur", 0, "PierreAlias", "255-214-5587" },
                    { 65, "Sheridan@bataillonMail.com", "Sheridan", "Hammervåg", 0, "SheridanAlias", "682-453-1112" },
                    { 66, "Debi@bataillonMail.com", "Debi", "Jaunli", 0, "DebiAlias", "228-612-4525" },
                    { 67, "Johana@bataillonMail.com", "Johana", "Enbo", 0, "JohanaAlias", "645-741-8138" },
                    { 72, "Ralph@bataillonMail.com", "Ralph", "Vadtälje", 0, "RalphAlias", "381-864-2587" },
                    { 69, "Krissy@bataillonMail.com", "Krissy", "Reidcoln", 0, "KrissyAlias", "718-337-7156" },
                    { 70, "Pat@bataillonMail.com", "Pat", "Steinstrand", 0, "PatAlias", "336-476-3561" },
                    { 71, "Jamal@bataillonMail.com", "Jamal", "Nuugaatrapaluk", 0, "JamalAlias", "764-635-6174" },
                    { 68, "Adrian@bataillonMail.com", "Adrian", "Jonkruojis", 0, "AdrianAlias", "373-188-3543" },
                    { 63, "Tyson@bataillonMail.com", "Tyson", "Balniai", 0, "TysonAlias", "637-165-2175" },
                    { 52, "Tad@bataillonMail.com", "Tad", "Ixtatla", 0, "TadAlias", "811-661-2544" },
                    { 61, "Sherlene@bataillonMail.com", "Sherlene", "Salkile", 0, "SherleneAlias", "564-567-2157" },
                    { 60, "Marcella@bataillonMail.com", "Marcella", "Kalvee", 0, "MarcellaAlias", "146-338-7544" },
                    { 59, "Jane@bataillonMail.com", "Jane", "Ólafsholt", 0, "JaneAlias", "521-271-3131" },
                    { 58, "Mariella@bataillonMail.com", "Mariella", "Dragstrup", 0, "MariellaAlias", "173-842-8526" },
                    { 57, "Marcie@bataillonMail.com", "Marcie", "Nittinen", 0, "MarcieAlias", "555-683-4113" },
                    { 56, "Liliana@bataillonMail.com", "Liliana", "Boswood", 0, "LilianaAlias", "828-544-8588" },
                    { 55, "Alejandro@bataillonMail.com", "Alejandro", "Mõisali", 0, "AlejandroAlias", "482-315-5175" },
                    { 54, "Roma@bataillonMail.com", "Roma", "Guasabaro", 0, "RomaAlias", "865-156-1562" },
                    { 53, "Vi@bataillonMail.com", "Vi", "Ulhus", 0, "ViAlias", "437-728-6157" },
                    { 73, "Arielle@bataillonMail.com", "Arielle", "Eqalunavik", 0, "ArielleAlias", "727-223-5112" },
                    { 62, "Antonetta@bataillonMail.com", "Antonetta", "Rovanola", 0, "AntonettaAlias", "111-726-6562" },
                    { 74, "Troy@bataillonMail.com", "Troy", "Lystrup", 0, "TroyAlias", "454-352-1525" },
                    { 86, "Bianca@bataillonMail.com", "Bianca", "Brønnøyden", 0, "BiancaAlias", "618-816-4558" },
                    { 76, "Simonne@bataillonMail.com", "Simonne", "Haapsa", 0, "SimonneAlias", "418-758-8543" },
                    { 51, "Troy@bataillonMail.com", "Troy", "Norrviken", 0, "TroyAlias", "374-422-7131" },
                    { 97, "Steven@bataillonMail.com", "Steven", "Ulhus", 0, "StevenAlias", "435-313-3181" },
                    { 96, "Tad@bataillonMail.com", "Tad", "Eqalunavik", 0, "TadAlias", "887-154-8576" },
                    { 95, "Emely@bataillonMail.com", "Emely", "Norrviken", 0, "EmelyAlias", "362-715-4163" },
                    { 94, "Jamal@bataillonMail.com", "Jamal", "Nuugaatrapaluk", 0, "JamalAlias", "744-566-1558" },
                    { 93, "Cathryn@bataillonMail.com", "Cathryn", "Breksos", 0, "CathrynAlias", "317-427-5145" },
                    { 92, "Eugenie@bataillonMail.com", "Eugenie", "Reidcoln", 0, "EugenieAlias", "771-268-2532" },
                    { 91, "Marlon@bataillonMail.com", "Marlon", "Lazmerge", 0, "MarlonAlias", "354-831-6127" },
                    { 90, "Ernestine@bataillonMail.com", "Ernestine", "Clarehurst", 0, "ErnestineAlias", "626-772-2514" },
                    { 89, "Debi@bataillonMail.com", "Debi", "Kulli", 0, "DebiAlias", "288-543-7181" },
                    { 88, "Leida@bataillonMail.com", "Leida", "Kungstuna", 0, "LeidaAlias", "663-384-3576" },
                    { 87, "Derick@bataillonMail.com", "Derick", "Ísafholt", 0, "DerickAlias", "235-245-8163" },
                    { 85, "Nicholas@bataillonMail.com", "Nicholas", "Rovanola", 0, "NicholasAlias", "272-657-8145" },
                    { 84, "Sherlene@bataillonMail.com", "Sherlene", "Kedainkai", 0, "SherleneAlias", "544-428-5532" },
                    { 83, "Conrad@bataillonMail.com", "Conrad", "Kalvee", 0, "ConradAlias", "127-361-1128" },
                    { 82, "Berniece@bataillonMail.com", "Berniece", "Ketne", 0, "BernieceAlias", "581-122-6515" },
                    { 81, "Tonita@bataillonMail.com", "Tonita", "Dragstrup", 0, "TonitaAlias", "154-773-2182" },
                    { 80, "Sheryl@bataillonMail.com", "Sheryl", "Hókrókur", 0, "SherylAlias", "536-634-7577" },
                    { 79, "Liliana@bataillonMail.com", "Liliana", "Boswood", 0, "LilianaAlias", "888-475-3174" },
                    { 78, "Angelina@bataillonMail.com", "Angelina", "Kalatee", 0, "AngelinaAlias", "463-246-7561" },
                    { 77, "Sherise@bataillonMail.com", "Sherise", "Guasabaro", 0, "SheriseAlias", "845-887-4156" },
                    { 75, "Marcell@bataillonMail.com", "Marcell", "Apatcruz", 0, "MarcellAlias", "872-511-5138" },
                    { 50, "Eugenio@bataillonMail.com", "Eugenio", "Uummanqaq", 0, "EugenioAlias", "746-273-3526" },
                    { 25, "Eugenie@bataillonMail.com", "Eugenie", "Reidcoln", 0, "EugenieAlias", "722-844-1814" },
                    { 48, "Palmira@bataillonMail.com", "Palmira", "Flatwood", 0, "PalmiraAlias", "783-785-4588" },
                    { 21, "Leida@bataillonMail.com", "Leida", "Hammervåg", 0, "LeidaAlias", "684-168-3851" },
                    { 20, "Derick@bataillonMail.com", "Derick", "Ísafholt", 0, "DerickAlias", "266-721-7446" },
                    { 19, "Tyson@bataillonMail.com", "Tyson", "Brønnøyden", 0, "TysonAlias", "641-572-4833" },
                    { 18, "Nicholas@bataillonMail.com", "Nicholas", "Rovanola", 0, "NicholasAlias", "213-433-8428" },
                    { 17, "Sherlene@bataillonMail.com", "Sherlene", "Kedainkai", 0, "SherleneAlias", "576-284-5815" },
                    { 16, "Conrad@bataillonMail.com", "Conrad", "Kalvee", 0, "ConradAlias", "158-845-1482" },
                    { 15, "Berniece@bataillonMail.com", "Berniece", "Ketne", 0, "BernieceAlias", "523-786-6877" },
                    { 14, "Mariella@bataillonMail.com", "Mariella", "Dragstrup", 0, "MariellaAlias", "185-557-2464" },
                    { 13, "Sheryl@bataillonMail.com", "Sheryl", "Hókrókur", 0, "SherylAlias", "567-318-6851" },
                    { 12, "Liliana@bataillonMail.com", "Liliana", "Boswood", 0, "LilianaAlias", "832-151-3446" },
                    { 11, "Angelina@bataillonMail.com", "Angelina", "Kalatee", 0, "AngelinaAlias", "414-822-7833" },
                    { 10, "Sherise@bataillonMail.com", "Sherise", "Guasabaro", 0, "SheriseAlias", "877-663-4428" },
                    { 9, "Vi@bataillonMail.com", "Vi", "Haapsa", 0, "ViAlias", "441-434-8815" },
                    { 8, "Marcell@bataillonMail.com", "Marcell", "Ixtatla", 0, "MarcellAlias", "823-375-4482" },
                    { 7, "Troy@bataillonMail.com", "Troy", "Lystrup", 0, "TroyAlias", "476-136-1877" },
                    { 6, "Arielle@bataillonMail.com", "Arielle", "Eqalunavik", 0, "ArielleAlias", "758-787-5464" },
                    { 5, "Ralph@bataillonMail.com", "Ralph", "Vadtälje", 0, "RalphAlias", "333-648-2851" },
                    { 4, "Palmira@bataillonMail.com", "Palmira", "Nuugaatrapaluk", 0, "PalmiraAlias", "785-411-6446" },
                    { 3, "Pat@bataillonMail.com", "Pat", "Steinstrand", 0, "PatAlias", "367-252-3834" },
                    { 2, "Krissy@bataillonMail.com", "Krissy", "Reidcoln", 0, "KrissyAlias", "742-813-7421" },
                    { 1, "Adrian@bataillonMail.com", "Adrian", "Jonkruojis", 0, "AdrianAlias", "214-764-3816" },
                    { 22, "Debi@bataillonMail.com", "Debi", "Kulli", 0, "DebiAlias", "232-327-7464" },
                    { 23, "Ernestine@bataillonMail.com", "Ernestine", "Enbo", 0, "ErnestineAlias", "657-456-2877" },
                    { 24, "Adrian@bataillonMail.com", "Adrian", "Lazmerge", 0, "AdrianAlias", "375-615-6481" },
                    { 98, "Roma@bataillonMail.com", "Roma", "Apatcruz", 0, "RomaAlias", "853-442-7514" },
                    { 47, "Marlon@bataillonMail.com", "Marlon", "Steinstrand", 0, "MarlonAlias", "355-546-8175" },
                    { 46, "Krissy@bataillonMail.com", "Krissy", "Clarehurst", 0, "KrissyAlias", "738-487-5562" },
                    { 45, "Rosetta@bataillonMail.com", "Rosetta", "Jonkruojis", 0, "RosettaAlias", "212-258-1157" },
                    { 44, "Leida@bataillonMail.com", "Leida", "Kungstuna", 0, "LeidaAlias", "665-811-5544" },
                    { 43, "Barbie@bataillonMail.com", "Barbie", "Jaunli", 0, "BarbieAlias", "247-652-2132" },
                    { 42, "Bianca@bataillonMail.com", "Bianca", "Brønnøyden", 0, "BiancaAlias", "622-523-6527" },
                    { 41, "Pierre@bataillonMail.com", "Pierre", "Akssandur", 0, "PierreAlias", "274-364-3114" },
                    { 40, "Adell@bataillonMail.com", "Adell", "Kedainkai", 0, "AdellAlias", "556-135-7581" },
                    { 39, "Conrad@bataillonMail.com", "Conrad", "Siukoski", 0, "ConradAlias", "131-876-4176" },
                    { 38, "Dina@bataillonMail.com", "Dina", "Ketne", 0, "DinaAlias", "583-637-8563" },
                    { 49, "Cathryn@bataillonMail.com", "Cathryn", "Breksos", 0, "CathrynAlias", "321-134-7113" },
                    { 37, "Tonita@bataillonMail.com", "Tonita", "Loktu", 0, "TonitaAlias", "166-488-4158" },
                    { 35, "Magen@bataillonMail.com", "Magen", "Albro", 0, "MagenAlias", "112-112-5132" },
                    { 34, "Angelina@bataillonMail.com", "Angelina", "Nittinen", 0, "AngelinaAlias", "475-753-2427" },
                    { 33, "Jeanetta@bataillonMail.com", "Jeanetta", "Mensmere", 0, "JeanettaAlias", "857-514-6814" },
                    { 32, "Simonne@bataillonMail.com", "Simonne", "Mõisali", 0, "SimonneAlias", "422-465-2481" },
                    { 31, "Roma@bataillonMail.com", "Roma", "Apatcruz", 0, "RomaAlias", "884-226-7876" },
                    { 30, "Steven@bataillonMail.com", "Steven", "Ulhus", 0, "StevenAlias", "456-877-3463" },
                    { 29, "Arielle@bataillonMail.com", "Arielle", "Eqalunavik", 0, "ArielleAlias", "831-638-8858" },
                    { 28, "Emely@bataillonMail.com", "Emely", "Norrviken", 0, "EmelyAlias", "313-571-4445" },
                    { 27, "Jamal@bataillonMail.com", "Jamal", "Nuugaatrapaluk", 0, "JamalAlias", "766-342-1832" },
                    { 26, "Cathryn@bataillonMail.com", "Cathryn", "Breksos", 0, "CathrynAlias", "348-183-5427" },
                    { 36, "Jane@bataillonMail.com", "Jane", "Hókrókur", 0, "JaneAlias", "548-241-1545" },
                    { 99, "Simonne@bataillonMail.com", "Simonne", "Mõisali", 0, "SimonneAlias", "478-681-3127" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CaptainId", "TeamName" },
                values: new object[,]
                {
                    { 1, 10, "Krissy" },
                    { 2, 20, "Pat" },
                    { 3, 30, "Palmira" },
                    { 4, 40, "Ralph" },
                    { 5, 50, "Arielle" },
                    { 6, 60, "Troy" },
                    { 7, 70, "Marcell" },
                    { 8, 80, "Vi" },
                    { 9, 90, "Sherise" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CaptainId",
                table: "Teams",
                column: "CaptainId");
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
