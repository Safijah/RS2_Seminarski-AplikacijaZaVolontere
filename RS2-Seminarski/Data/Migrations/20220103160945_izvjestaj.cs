using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class izvjestaj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Izvještaj");

            migrationBuilder.CreateTable(
                name: "Izvjestaj",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cilj = table.Column<string>(nullable: true),
                    VolonterskeAktivnosti = table.Column<string>(nullable: true),
                    Teme = table.Column<string>(nullable: true),
                    PrisutniUcenici = table.Column<string>(nullable: true),
                    OdsutniUcenici = table.Column<string>(nullable: true),
                    Napomena = table.Column<string>(nullable: true),
                    VolonterID = table.Column<string>(nullable: true),
                    NajavaID = table.Column<int>(nullable: false),
                    StanjeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Izvjestaj", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Izvjestaj_Najava_NajavaID",
                        column: x => x.NajavaID,
                        principalTable: "Najava",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Izvjestaj_Stanje_StanjeID",
                        column: x => x.StanjeID,
                        principalTable: "Stanje",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Izvjestaj_Volonter_VolonterID",
                        column: x => x.VolonterID,
                        principalTable: "Volonter",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Izvjestaj_NajavaID",
                table: "Izvjestaj",
                column: "NajavaID");

            migrationBuilder.CreateIndex(
                name: "IX_Izvjestaj_StanjeID",
                table: "Izvjestaj",
                column: "StanjeID");

            migrationBuilder.CreateIndex(
                name: "IX_Izvjestaj_VolonterID",
                table: "Izvjestaj",
                column: "VolonterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Izvjestaj");

            migrationBuilder.CreateTable(
                name: "Izvještaj",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cilj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NajavaID = table.Column<int>(type: "int", nullable: false),
                    Napomena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OdsutniUcenici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrisutniUcenici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StanjeID = table.Column<int>(type: "int", nullable: false),
                    Teme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VolonterID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    VolonterskeAktivnosti = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Izvještaj", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Izvještaj_Najava_NajavaID",
                        column: x => x.NajavaID,
                        principalTable: "Najava",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Izvještaj_Stanje_StanjeID",
                        column: x => x.StanjeID,
                        principalTable: "Stanje",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Izvještaj_Volonter_VolonterID",
                        column: x => x.VolonterID,
                        principalTable: "Volonter",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Izvještaj_NajavaID",
                table: "Izvještaj",
                column: "NajavaID");

            migrationBuilder.CreateIndex(
                name: "IX_Izvještaj_StanjeID",
                table: "Izvještaj",
                column: "StanjeID");

            migrationBuilder.CreateIndex(
                name: "IX_Izvještaj_VolonterID",
                table: "Izvještaj",
                column: "VolonterID");
        }
    }
}
