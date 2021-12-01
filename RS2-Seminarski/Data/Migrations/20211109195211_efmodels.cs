using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class efmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ime",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prezime",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GodisnjiPlan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Godina = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GodisnjiPlan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sekcija",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sekcija", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spol",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spol", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TipSkole",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipSkole", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Skola",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    TipSkoleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skola", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Skola_TipSkole_TipSkoleID",
                        column: x => x.TipSkoleID,
                        principalTable: "TipSkole",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    SpolID = table.Column<int>(nullable: false),
                    GradID = table.Column<int>(nullable: false),
                    SkolaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Admin_Grad_GradID",
                        column: x => x.GradID,
                        principalTable: "Grad",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Admin_AspNetUsers_ID",
                        column: x => x.ID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Admin_Skola_SkolaID",
                        column: x => x.SkolaID,
                        principalTable: "Skola",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Admin_Spol_SpolID",
                        column: x => x.SpolID,
                        principalTable: "Spol",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Ucenici",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    SkolaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ucenici", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ucenici_Skola_SkolaID",
                        column: x => x.SkolaID,
                        principalTable: "Skola",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Volonter",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    SpolID = table.Column<int>(nullable: false),
                    GradID = table.Column<int>(nullable: false),
                    SkolaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volonter", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Volonter_Grad_GradID",
                        column: x => x.GradID,
                        principalTable: "Grad",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Volonter_AspNetUsers_ID",
                        column: x => x.ID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Volonter_Skola_SkolaID",
                        column: x => x.SkolaID,
                        principalTable: "Skola",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Volonter_Spol_SpolID",
                        column: x => x.SpolID,
                        principalTable: "Spol",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "KorisniLink",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    AdminID1 = table.Column<string>(nullable: true),
                    AdminID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisniLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KorisniLink_Admin_AdminID1",
                        column: x => x.AdminID1,
                        principalTable: "Admin",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetaljiPlana",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivTeme1 = table.Column<string>(nullable: true),
                    NazivTeme2 = table.Column<string>(nullable: true),
                    Cilj1 = table.Column<string>(nullable: true),
                    Cilj2 = table.Column<string>(nullable: true),
                    Aktivnost1 = table.Column<string>(nullable: true),
                    Aktivnost2 = table.Column<string>(nullable: true),
                    Mjesec = table.Column<string>(nullable: true),
                    GodisnjiPlanID = table.Column<int>(nullable: false),
                    VolonterID1 = table.Column<string>(nullable: true),
                    VolonterID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetaljiPlana", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetaljiPlana_GodisnjiPlan_GodisnjiPlanID",
                        column: x => x.GodisnjiPlanID,
                        principalTable: "GodisnjiPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DetaljiPlana_Volonter_VolonterID1",
                        column: x => x.VolonterID1,
                        principalTable: "Volonter",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Najava",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stanje = table.Column<string>(nullable: true),
                    Mjesto = table.Column<string>(nullable: true),
                    VrijemeOd = table.Column<int>(nullable: false),
                    VrijemeDo = table.Column<int>(nullable: false),
                    Mentori = table.Column<string>(nullable: true),
                    Napomena = table.Column<string>(nullable: true),
                    Datum = table.Column<DateTime>(nullable: false),
                    VolonterID1 = table.Column<string>(nullable: true),
                    VolonterID = table.Column<int>(nullable: false),
                    GradID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Najava", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Najava_Grad_GradID",
                        column: x => x.GradID,
                        principalTable: "Grad",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Najava_Volonter_VolonterID1",
                        column: x => x.VolonterID1,
                        principalTable: "Volonter",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Obavijest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naslov = table.Column<string>(nullable: true),
                    Sadrzaj = table.Column<string>(nullable: true),
                    SekcijaID = table.Column<int>(nullable: false),
                    VolonterID1 = table.Column<string>(nullable: true),
                    VolonterID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obavijest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Obavijest_Sekcija_SekcijaID",
                        column: x => x.SekcijaID,
                        principalTable: "Sekcija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Obavijest_Volonter_VolonterID1",
                        column: x => x.VolonterID1,
                        principalTable: "Volonter",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Uplata",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iznos = table.Column<int>(nullable: false),
                    Mjesec = table.Column<string>(nullable: true),
                    Napomena = table.Column<string>(nullable: true),
                    VolonterID1 = table.Column<string>(nullable: true),
                    VolonterID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uplata", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uplata_Volonter_VolonterID1",
                        column: x => x.VolonterID1,
                        principalTable: "Volonter",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Izvještaj",
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
                    VolonterID1 = table.Column<string>(nullable: true),
                    VolonterID = table.Column<int>(nullable: false),
                    NajavaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Izvještaj", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Izvještaj_Najava_NajavaID",
                        column: x => x.NajavaID,
                        principalTable: "Najava",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Izvještaj_Volonter_VolonterID1",
                        column: x => x.VolonterID1,
                        principalTable: "Volonter",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admin_GradID",
                table: "Admin",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Admin_SkolaID",
                table: "Admin",
                column: "SkolaID");

            migrationBuilder.CreateIndex(
                name: "IX_Admin_SpolID",
                table: "Admin",
                column: "SpolID");

            migrationBuilder.CreateIndex(
                name: "IX_DetaljiPlana_GodisnjiPlanID",
                table: "DetaljiPlana",
                column: "GodisnjiPlanID");

            migrationBuilder.CreateIndex(
                name: "IX_DetaljiPlana_VolonterID1",
                table: "DetaljiPlana",
                column: "VolonterID1");

            migrationBuilder.CreateIndex(
                name: "IX_Izvještaj_NajavaID",
                table: "Izvještaj",
                column: "NajavaID");

            migrationBuilder.CreateIndex(
                name: "IX_Izvještaj_VolonterID1",
                table: "Izvještaj",
                column: "VolonterID1");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniLink_AdminID1",
                table: "KorisniLink",
                column: "AdminID1");

            migrationBuilder.CreateIndex(
                name: "IX_Najava_GradID",
                table: "Najava",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Najava_VolonterID1",
                table: "Najava",
                column: "VolonterID1");

            migrationBuilder.CreateIndex(
                name: "IX_Obavijest_SekcijaID",
                table: "Obavijest",
                column: "SekcijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Obavijest_VolonterID1",
                table: "Obavijest",
                column: "VolonterID1");

            migrationBuilder.CreateIndex(
                name: "IX_Skola_TipSkoleID",
                table: "Skola",
                column: "TipSkoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Ucenici_SkolaID",
                table: "Ucenici",
                column: "SkolaID");

            migrationBuilder.CreateIndex(
                name: "IX_Uplata_VolonterID1",
                table: "Uplata",
                column: "VolonterID1");

            migrationBuilder.CreateIndex(
                name: "IX_Volonter_GradID",
                table: "Volonter",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Volonter_SkolaID",
                table: "Volonter",
                column: "SkolaID");

            migrationBuilder.CreateIndex(
                name: "IX_Volonter_SpolID",
                table: "Volonter",
                column: "SpolID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetaljiPlana");

            migrationBuilder.DropTable(
                name: "Izvještaj");

            migrationBuilder.DropTable(
                name: "KorisniLink");

            migrationBuilder.DropTable(
                name: "Obavijest");

            migrationBuilder.DropTable(
                name: "Ucenici");

            migrationBuilder.DropTable(
                name: "Uplata");

            migrationBuilder.DropTable(
                name: "GodisnjiPlan");

            migrationBuilder.DropTable(
                name: "Najava");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Sekcija");

            migrationBuilder.DropTable(
                name: "Volonter");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "Skola");

            migrationBuilder.DropTable(
                name: "Spol");

            migrationBuilder.DropTable(
                name: "TipSkole");

            migrationBuilder.DropColumn(
                name: "Ime",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Prezime",
                table: "AspNetUsers");
        }
    }
}
