using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class NewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetaljiPlana_Volonter_VolonterID1",
                table: "DetaljiPlana");

            migrationBuilder.DropForeignKey(
                name: "FK_Izvještaj_Volonter_VolonterID1",
                table: "Izvještaj");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisniLink_Admin_AdminID1",
                table: "KorisniLink");

            migrationBuilder.DropForeignKey(
                name: "FK_Najava_Volonter_VolonterID1",
                table: "Najava");

            migrationBuilder.DropForeignKey(
                name: "FK_Obavijest_Volonter_VolonterID1",
                table: "Obavijest");

            migrationBuilder.DropForeignKey(
                name: "FK_Uplata_Volonter_VolonterID1",
                table: "Uplata");

            migrationBuilder.DropIndex(
                name: "IX_Uplata_VolonterID1",
                table: "Uplata");

            migrationBuilder.DropIndex(
                name: "IX_Obavijest_VolonterID1",
                table: "Obavijest");

            migrationBuilder.DropIndex(
                name: "IX_Najava_VolonterID1",
                table: "Najava");

            migrationBuilder.DropIndex(
                name: "IX_KorisniLink_AdminID1",
                table: "KorisniLink");

            migrationBuilder.DropIndex(
                name: "IX_Izvještaj_VolonterID1",
                table: "Izvještaj");

            migrationBuilder.DropIndex(
                name: "IX_DetaljiPlana_VolonterID1",
                table: "DetaljiPlana");

            migrationBuilder.DropColumn(
                name: "Mjesec",
                table: "Uplata");

            migrationBuilder.DropColumn(
                name: "VolonterID1",
                table: "Uplata");

            migrationBuilder.DropColumn(
                name: "VolonterID1",
                table: "Obavijest");

            migrationBuilder.DropColumn(
                name: "VolonterID1",
                table: "Najava");

            migrationBuilder.DropColumn(
                name: "AdminID1",
                table: "KorisniLink");

            migrationBuilder.DropColumn(
                name: "VolonterID1",
                table: "Izvještaj");

            migrationBuilder.DropColumn(
                name: "VolonterID1",
                table: "DetaljiPlana");

            migrationBuilder.AlterColumn<string>(
                name: "VolonterID",
                table: "Uplata",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "MjesecID",
                table: "Uplata",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "VolonterID",
                table: "Obavijest",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "VolonterID",
                table: "Najava",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "AdminID",
                table: "KorisniLink",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "VolonterID",
                table: "Izvještaj",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "VolonterID",
                table: "DetaljiPlana",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Mjesec",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mjesec", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Uplata_MjesecID",
                table: "Uplata",
                column: "MjesecID");

            migrationBuilder.CreateIndex(
                name: "IX_Uplata_VolonterID",
                table: "Uplata",
                column: "VolonterID");

            migrationBuilder.CreateIndex(
                name: "IX_Obavijest_VolonterID",
                table: "Obavijest",
                column: "VolonterID");

            migrationBuilder.CreateIndex(
                name: "IX_Najava_VolonterID",
                table: "Najava",
                column: "VolonterID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniLink_AdminID",
                table: "KorisniLink",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_Izvještaj_VolonterID",
                table: "Izvještaj",
                column: "VolonterID");

            migrationBuilder.CreateIndex(
                name: "IX_DetaljiPlana_VolonterID",
                table: "DetaljiPlana",
                column: "VolonterID");

            migrationBuilder.AddForeignKey(
                name: "FK_DetaljiPlana_Volonter_VolonterID",
                table: "DetaljiPlana",
                column: "VolonterID",
                principalTable: "Volonter",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Izvještaj_Volonter_VolonterID",
                table: "Izvještaj",
                column: "VolonterID",
                principalTable: "Volonter",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisniLink_Admin_AdminID",
                table: "KorisniLink",
                column: "AdminID",
                principalTable: "Admin",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Najava_Volonter_VolonterID",
                table: "Najava",
                column: "VolonterID",
                principalTable: "Volonter",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Obavijest_Volonter_VolonterID",
                table: "Obavijest",
                column: "VolonterID",
                principalTable: "Volonter",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Uplata_Mjesec_MjesecID",
                table: "Uplata",
                column: "MjesecID",
                principalTable: "Mjesec",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Uplata_Volonter_VolonterID",
                table: "Uplata",
                column: "VolonterID",
                principalTable: "Volonter",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetaljiPlana_Volonter_VolonterID",
                table: "DetaljiPlana");

            migrationBuilder.DropForeignKey(
                name: "FK_Izvještaj_Volonter_VolonterID",
                table: "Izvještaj");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisniLink_Admin_AdminID",
                table: "KorisniLink");

            migrationBuilder.DropForeignKey(
                name: "FK_Najava_Volonter_VolonterID",
                table: "Najava");

            migrationBuilder.DropForeignKey(
                name: "FK_Obavijest_Volonter_VolonterID",
                table: "Obavijest");

            migrationBuilder.DropForeignKey(
                name: "FK_Uplata_Mjesec_MjesecID",
                table: "Uplata");

            migrationBuilder.DropForeignKey(
                name: "FK_Uplata_Volonter_VolonterID",
                table: "Uplata");

            migrationBuilder.DropTable(
                name: "Mjesec");

            migrationBuilder.DropIndex(
                name: "IX_Uplata_MjesecID",
                table: "Uplata");

            migrationBuilder.DropIndex(
                name: "IX_Uplata_VolonterID",
                table: "Uplata");

            migrationBuilder.DropIndex(
                name: "IX_Obavijest_VolonterID",
                table: "Obavijest");

            migrationBuilder.DropIndex(
                name: "IX_Najava_VolonterID",
                table: "Najava");

            migrationBuilder.DropIndex(
                name: "IX_KorisniLink_AdminID",
                table: "KorisniLink");

            migrationBuilder.DropIndex(
                name: "IX_Izvještaj_VolonterID",
                table: "Izvještaj");

            migrationBuilder.DropIndex(
                name: "IX_DetaljiPlana_VolonterID",
                table: "DetaljiPlana");

            migrationBuilder.DropColumn(
                name: "MjesecID",
                table: "Uplata");

            migrationBuilder.AlterColumn<int>(
                name: "VolonterID",
                table: "Uplata",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mjesec",
                table: "Uplata",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VolonterID1",
                table: "Uplata",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VolonterID",
                table: "Obavijest",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VolonterID1",
                table: "Obavijest",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VolonterID",
                table: "Najava",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VolonterID1",
                table: "Najava",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdminID",
                table: "KorisniLink",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdminID1",
                table: "KorisniLink",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VolonterID",
                table: "Izvještaj",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VolonterID1",
                table: "Izvještaj",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VolonterID",
                table: "DetaljiPlana",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VolonterID1",
                table: "DetaljiPlana",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Uplata_VolonterID1",
                table: "Uplata",
                column: "VolonterID1");

            migrationBuilder.CreateIndex(
                name: "IX_Obavijest_VolonterID1",
                table: "Obavijest",
                column: "VolonterID1");

            migrationBuilder.CreateIndex(
                name: "IX_Najava_VolonterID1",
                table: "Najava",
                column: "VolonterID1");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniLink_AdminID1",
                table: "KorisniLink",
                column: "AdminID1");

            migrationBuilder.CreateIndex(
                name: "IX_Izvještaj_VolonterID1",
                table: "Izvještaj",
                column: "VolonterID1");

            migrationBuilder.CreateIndex(
                name: "IX_DetaljiPlana_VolonterID1",
                table: "DetaljiPlana",
                column: "VolonterID1");

            migrationBuilder.AddForeignKey(
                name: "FK_DetaljiPlana_Volonter_VolonterID1",
                table: "DetaljiPlana",
                column: "VolonterID1",
                principalTable: "Volonter",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Izvještaj_Volonter_VolonterID1",
                table: "Izvještaj",
                column: "VolonterID1",
                principalTable: "Volonter",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisniLink_Admin_AdminID1",
                table: "KorisniLink",
                column: "AdminID1",
                principalTable: "Admin",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Najava_Volonter_VolonterID1",
                table: "Najava",
                column: "VolonterID1",
                principalTable: "Volonter",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Obavijest_Volonter_VolonterID1",
                table: "Obavijest",
                column: "VolonterID1",
                principalTable: "Volonter",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Uplata_Volonter_VolonterID1",
                table: "Uplata",
                column: "VolonterID1",
                principalTable: "Volonter",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
