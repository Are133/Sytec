using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrearEmpresasSytec.Migrations
{
    public partial class dosmigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdSoporte",
                table: "Empresas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdSoporte",
                table: "Empresas",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
