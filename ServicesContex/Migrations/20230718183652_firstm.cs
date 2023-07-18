using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServicesContex.Migrations
{
    /// <inheritdoc />
    public partial class firstm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonaId = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NivelEstrato = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonaId);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServicioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NommbreServicio = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DescripcionServicio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServicioId);
                });

            migrationBuilder.CreateTable(
                name: "Detalles",
                columns: table => new
                {
                    DetalleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServicioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServicesServicioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonaId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonsPersonaId = table.Column<string>(type: "nvarchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalles", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_Detalles_Persons_PersonsPersonaId",
                        column: x => x.PersonsPersonaId,
                        principalTable: "Persons",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Detalles_Services_ServicesServicioId",
                        column: x => x.ServicesServicioId,
                        principalTable: "Services",
                        principalColumn: "ServicioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonaId", "Apellidos", "Direccion", "Email", "NivelEstrato", "Nombres" },
                values: new object[,]
                {
                    { "123456789", "Forero", "Bogota", "Iotled@yopmail.com", 0, "Juan David" },
                    { "765390123", "Ramirez", "Bogota", "Iotled@yopmail.com", 0, "Juan Carlos" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ServicioId", "DescripcionServicio", "FechaCreacion", "NommbreServicio" },
                values: new object[,]
                {
                    { new Guid("0e3d96c2-0aac-4176-b551-389845fe5e37"), "Sin Descripcion", new DateTime(2023, 7, 18, 13, 36, 51, 860, DateTimeKind.Local).AddTicks(6632), "Telefonia ETB" },
                    { new Guid("7e51c224-a766-4d5a-a84a-dd850fdd21f2"), "Sin Descripcion", new DateTime(2023, 7, 18, 13, 36, 51, 860, DateTimeKind.Local).AddTicks(6646), "Telefonia Claro" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_PersonsPersonaId",
                table: "Detalles",
                column: "PersonsPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_ServicesServicioId",
                table: "Detalles",
                column: "ServicesServicioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalles");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
