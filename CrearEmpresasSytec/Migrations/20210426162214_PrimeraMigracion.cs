using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrearEmpresasSytec.Migrations
{
    public partial class PrimeraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    IdEmpresa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdSoporte = table.Column<Guid>(nullable: false),
                    RFC = table.Column<string>(nullable: true),
                    NombreEmpresa = table.Column<string>(nullable: false),
                    NombreComercil = table.Column<string>(nullable: true),
                    Calle = table.Column<string>(nullable: true),
                    Colonia = table.Column<string>(nullable: true),
                    CP = table.Column<string>(nullable: true),
                    Municipio = table.Column<string>(nullable: true),
                    IdEstados = table.Column<int>(nullable: false),
                    IdPaises = table.Column<int>(nullable: false),
                    Sucursal = table.Column<string>(nullable: true),
                    TEL = table.Column<string>(nullable: true),
                    RegimenFiscal = table.Column<string>(nullable: true),
                    ClaveEPago = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Contraseña = table.Column<string>(nullable: true),
                    Servidor1 = table.Column<string>(nullable: true),
                    Puerto1 = table.Column<string>(nullable: true),
                    Servidro2 = table.Column<string>(nullable: true),
                    Puerto2 = table.Column<string>(nullable: true),
                    HabilitarCifrado = table.Column<string>(nullable: true),
                    RegistroPatronal = table.Column<string>(nullable: true),
                    IdRiesgoPuesto = table.Column<int>(nullable: false),
                    CURP = table.Column<string>(nullable: true),
                    EsEntidadPublica = table.Column<string>(nullable: true),
                    EsEntidadprivada = table.Column<string>(nullable: true),
                    IdSATRegimenFiscal = table.Column<int>(nullable: false),
                    EsAmbieteDePrueba = table.Column<bool>(nullable: false),
                    SNCF = table.Column<bool>(nullable: false),
                    Mensaje = table.Column<string>(nullable: true),
                    Asunto = table.Column<string>(nullable: true),
                    DeSistema = table.Column<bool>(nullable: false),
                    SeguridadClienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.IdEmpresa);
                });

            migrationBuilder.CreateTable(
                name: "Configuraciones",
                columns: table => new
                {
                    IdConfigFacturacion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdEmpresa = table.Column<int>(nullable: false),
                    NombreCertificado = table.Column<string>(nullable: true),
                    Certificado = table.Column<byte[]>(nullable: true),
                    NombreLlavePublica = table.Column<string>(nullable: true),
                    LlavePublica = table.Column<byte[]>(nullable: true),
                    LlavePrivada = table.Column<string>(maxLength: 100, nullable: true),
                    UserPac = table.Column<string>(maxLength: 50, nullable: true),
                    PassPac = table.Column<string>(maxLength: 50, nullable: true),
                    APIKey = table.Column<string>(nullable: true),
                    AmbienteTimbrado = table.Column<int>(nullable: false),
                    PAC = table.Column<int>(nullable: false),
                    VersionCFDI = table.Column<int>(nullable: false),
                    NcMetodoPago = table.Column<string>(maxLength: 2, nullable: true),
                    OpcionEnviarFactura = table.Column<string>(maxLength: 100, nullable: true),
                    OpcionTimbrado = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuraciones", x => x.IdConfigFacturacion);
                    table.ForeignKey(
                        name: "FK_Configuraciones_Empresas_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresas",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Configuraciones_IdEmpresa",
                table: "Configuraciones",
                column: "IdEmpresa",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configuraciones");

            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
