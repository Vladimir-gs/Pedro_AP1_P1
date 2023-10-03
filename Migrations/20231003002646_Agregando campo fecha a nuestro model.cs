using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pedro_AP1_P1.Migrations
{
    /// <inheritdoc />
    public partial class Agregandocampofechaanuestromodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "Aportes",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "Aportes");
        }
    }
}
