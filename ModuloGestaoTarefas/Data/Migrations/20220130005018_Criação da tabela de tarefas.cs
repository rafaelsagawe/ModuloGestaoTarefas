using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuloGestaoTarefas.Data.Migrations
{
    public partial class Criaçãodatabeladetarefas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarefa",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(nullable: false),
                    concluido = table.Column<bool>(nullable: false),
                    usuario = table.Column<string>(nullable: true),
                    dataCriacao = table.Column<DateTime>(nullable: false),
                    dataAlteracao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefa", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarefa");
        }
    }
}
