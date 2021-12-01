using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class izmjenazaobavijest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Obavijest_Volonter_VolonterID",
                table: "Obavijest");

            migrationBuilder.DropIndex(
                name: "IX_Obavijest_VolonterID",
                table: "Obavijest");

            migrationBuilder.DropColumn(
                name: "VolonterID",
                table: "Obavijest");

            migrationBuilder.AddColumn<string>(
                name: "AdminID",
                table: "Obavijest",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Obavijest_AdminID",
                table: "Obavijest",
                column: "AdminID");

            migrationBuilder.AddForeignKey(
                name: "FK_Obavijest_Admin_AdminID",
                table: "Obavijest",
                column: "AdminID",
                principalTable: "Admin",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Obavijest_Admin_AdminID",
                table: "Obavijest");

            migrationBuilder.DropIndex(
                name: "IX_Obavijest_AdminID",
                table: "Obavijest");

            migrationBuilder.DropColumn(
                name: "AdminID",
                table: "Obavijest");

            migrationBuilder.AddColumn<string>(
                name: "VolonterID",
                table: "Obavijest",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Obavijest_VolonterID",
                table: "Obavijest",
                column: "VolonterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Obavijest_Volonter_VolonterID",
                table: "Obavijest",
                column: "VolonterID",
                principalTable: "Volonter",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
