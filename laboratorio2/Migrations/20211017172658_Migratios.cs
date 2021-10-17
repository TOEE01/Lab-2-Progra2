﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace laboratorio2.Migrations
{
    public partial class Migratios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "almacenPersonas",
                columns: table => new
                {
                    IdPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePersona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EdadPersona = table.Column<int>(type: "int", nullable: false),
                    DescripcionPersona = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_almacenPersonas", x => x.IdPersona);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "almacenPersonas");
        }
    }
}
