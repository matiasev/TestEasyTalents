using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EasyTalentsData.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InformacaoBancariaTipoContaCorrente",
                table: "Talent");

            migrationBuilder.DropColumn(
                name: "InformacaoBancariaTipoContaPoupanca",
                table: "Talent");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Talent",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Talent");

            migrationBuilder.AddColumn<bool>(
                name: "InformacaoBancariaTipoContaCorrente",
                table: "Talent",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "InformacaoBancariaTipoContaPoupanca",
                table: "Talent",
                nullable: false,
                defaultValue: false);
        }
    }
}
