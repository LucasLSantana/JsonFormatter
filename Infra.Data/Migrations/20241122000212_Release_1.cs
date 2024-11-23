using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Data.Migrations
{
    public partial class Release_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Data",
                table: "JsonData",
                newName: "Url");

            migrationBuilder.AddColumn<string>(
                name: "JsonGerado",
                table: "JsonData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Metodo",
                table: "JsonData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Response",
                table: "JsonData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JsonGerado",
                table: "JsonData");

            migrationBuilder.DropColumn(
                name: "Metodo",
                table: "JsonData");

            migrationBuilder.DropColumn(
                name: "Response",
                table: "JsonData");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "JsonData",
                newName: "Data");
        }
    }
}
