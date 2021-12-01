using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class changesforadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admin_Grad_GradID",
                table: "Admin");

            migrationBuilder.DropForeignKey(
                name: "FK_Admin_Skola_SkolaID",
                table: "Admin");

            migrationBuilder.DropForeignKey(
                name: "FK_Admin_Spol_SpolID",
                table: "Admin");

            migrationBuilder.DropForeignKey(
                name: "FK_Volonter_Grad_GradID",
                table: "Volonter");

            migrationBuilder.DropForeignKey(
                name: "FK_Volonter_Spol_SpolID",
                table: "Volonter");

            migrationBuilder.DropIndex(
                name: "IX_Volonter_GradID",
                table: "Volonter");

            migrationBuilder.DropIndex(
                name: "IX_Volonter_SpolID",
                table: "Volonter");

            migrationBuilder.DropIndex(
                name: "IX_Admin_GradID",
                table: "Admin");

            migrationBuilder.DropIndex(
                name: "IX_Admin_SkolaID",
                table: "Admin");

            migrationBuilder.DropIndex(
                name: "IX_Admin_SpolID",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "GradID",
                table: "Volonter");

            migrationBuilder.DropColumn(
                name: "SpolID",
                table: "Volonter");

            migrationBuilder.DropColumn(
                name: "GradID",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "SkolaID",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "SpolID",
                table: "Admin");

            migrationBuilder.AddColumn<int>(
                name: "GradID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpolID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_GradID",
                table: "AspNetUsers",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SpolID",
                table: "AspNetUsers",
                column: "SpolID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Grad_GradID",
                table: "AspNetUsers",
                column: "GradID",
                principalTable: "Grad",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Spol_SpolID",
                table: "AspNetUsers",
                column: "SpolID",
                principalTable: "Spol",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Grad_GradID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Spol_SpolID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_GradID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SpolID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GradID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SpolID",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "GradID",
                table: "Volonter",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpolID",
                table: "Volonter",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GradID",
                table: "Admin",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SkolaID",
                table: "Admin",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpolID",
                table: "Admin",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Volonter_GradID",
                table: "Volonter",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Volonter_SpolID",
                table: "Volonter",
                column: "SpolID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Admin_Grad_GradID",
                table: "Admin",
                column: "GradID",
                principalTable: "Grad",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Admin_Skola_SkolaID",
                table: "Admin",
                column: "SkolaID",
                principalTable: "Skola",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Admin_Spol_SpolID",
                table: "Admin",
                column: "SpolID",
                principalTable: "Spol",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Volonter_Grad_GradID",
                table: "Volonter",
                column: "GradID",
                principalTable: "Grad",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Volonter_Spol_SpolID",
                table: "Volonter",
                column: "SpolID",
                principalTable: "Spol",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
