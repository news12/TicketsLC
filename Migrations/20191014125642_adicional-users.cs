using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketsLC.Migrations
{
    public partial class adicionalusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Users",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Empresa",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sobrenome",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tipo",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Empresa",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Sobrenome",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Users");
        }
    }
}
