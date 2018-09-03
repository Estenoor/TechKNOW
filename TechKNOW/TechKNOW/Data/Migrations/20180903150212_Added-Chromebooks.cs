using Microsoft.EntityFrameworkCore.Migrations;

namespace TechKNOW.Data.Migrations
{
    public partial class AddedChromebooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Repairs_ChromebookModel_ChromebookID",
                table: "Repairs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChromebookModel",
                table: "ChromebookModel");

            migrationBuilder.RenameTable(
                name: "ChromebookModel",
                newName: "Chromebooks");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Chromebooks",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chromebooks",
                table: "Chromebooks",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Repairs_Chromebooks_ChromebookID",
                table: "Repairs",
                column: "ChromebookID",
                principalTable: "Chromebooks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Repairs_Chromebooks_ChromebookID",
                table: "Repairs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chromebooks",
                table: "Chromebooks");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Chromebooks");

            migrationBuilder.RenameTable(
                name: "Chromebooks",
                newName: "ChromebookModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChromebookModel",
                table: "ChromebookModel",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Repairs_ChromebookModel_ChromebookID",
                table: "Repairs",
                column: "ChromebookID",
                principalTable: "ChromebookModel",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
