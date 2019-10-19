using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketsLC.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tipos_Categoria_CategoriaId",
                table: "Tipos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipos",
                table: "Tipos");

            migrationBuilder.RenameTable(
                name: "Tipos",
                newName: "Tipo");

            migrationBuilder.RenameIndex(
                name: "IX_Tipos_CategoriaId",
                table: "Tipo",
                newName: "IX_Tipo_CategoriaId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Categoria",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Categoria",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Tipo",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipo",
                table: "Tipo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tipo_Categoria_CategoriaId",
                table: "Tipo",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tipo_Categoria_CategoriaId",
                table: "Tipo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipo",
                table: "Tipo");

            migrationBuilder.RenameTable(
                name: "Tipo",
                newName: "Tipos");

            migrationBuilder.RenameIndex(
                name: "IX_Tipo_CategoriaId",
                table: "Tipos",
                newName: "IX_Tipos_CategoriaId");

            migrationBuilder.AlterColumn<int>(
                name: "Nome",
                table: "Categoria",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Descricao",
                table: "Categoria",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Tipos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipos",
                table: "Tipos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tipos_Categoria_CategoriaId",
                table: "Tipos",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
