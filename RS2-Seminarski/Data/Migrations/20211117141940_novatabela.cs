using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class novatabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stanje",
                table: "Najava");

            migrationBuilder.AddColumn<int>(
                name: "StanjeID",
                table: "Najava",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StanjeID",
                table: "Izvještaj",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Stanje",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stanje", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Najava_StanjeID",
                table: "Najava",
                column: "StanjeID");

            migrationBuilder.CreateIndex(
                name: "IX_Izvještaj_StanjeID",
                table: "Izvještaj",
                column: "StanjeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Izvještaj_Stanje_StanjeID",
                table: "Izvještaj",
                column: "StanjeID",
                principalTable: "Stanje",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Najava_Stanje_StanjeID",
                table: "Najava",
                column: "StanjeID",
                principalTable: "Stanje",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Izvještaj_Stanje_StanjeID",
                table: "Izvještaj");

            migrationBuilder.DropForeignKey(
                name: "FK_Najava_Stanje_StanjeID",
                table: "Najava");

            migrationBuilder.DropTable(
                name: "Stanje");

            migrationBuilder.DropIndex(
                name: "IX_Najava_StanjeID",
                table: "Najava");

            migrationBuilder.DropIndex(
                name: "IX_Izvještaj_StanjeID",
                table: "Izvještaj");

            migrationBuilder.DropColumn(
                name: "StanjeID",
                table: "Najava");

            migrationBuilder.DropColumn(
                name: "StanjeID",
                table: "Izvještaj");

            migrationBuilder.AddColumn<string>(
                name: "Stanje",
                table: "Najava",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
