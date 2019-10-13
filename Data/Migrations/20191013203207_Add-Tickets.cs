using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketsLC.Data.Migrations
{
    public partial class AddTickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Menssagem",
                table: "Tickets",
                newName: "Menssage");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Tickets",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "IdDestinatario",
                table: "Tickets",
                newName: "DestinatarioId");

            migrationBuilder.RenameColumn(
                name: "IdCategoria",
                table: "Tickets",
                newName: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Tickets",
                newName: "IdUsuario");

            migrationBuilder.RenameColumn(
                name: "Menssage",
                table: "Tickets",
                newName: "Menssagem");

            migrationBuilder.RenameColumn(
                name: "DestinatarioId",
                table: "Tickets",
                newName: "IdDestinatario");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "Tickets",
                newName: "IdCategoria");
        }
    }
}
