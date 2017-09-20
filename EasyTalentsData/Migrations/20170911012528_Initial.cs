using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EasyTalentsData.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Talent",
                columns: table => new
                {
                    TalentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BancoInformacao = table.Column<string>(type: "nvarchar(max)", nullable: true, maxLength: 15),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false, maxLength: 15),
                    ConhecimentoAndroid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConhecimentoAngularJs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConhecimentoAspNetMvc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConhecimentoBootstrap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConhecimentoC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConhecimentoCake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConhecimentoCplusplus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConhecimentoCss = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConhecimentoDjango = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConhecimentoHtml = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConhecimentoIllustrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConhecimentoIonic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConhecimentoIos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConhecimentoJava = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConhecimentoJquery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConhecimentoMajento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConhecimentoMySql = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConhecimentoMySqlServer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConhecimentoPhotoshop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConhecimentoPhp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConhecimentoPhyton = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConhecimentoRuby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConhecimentoSalesforce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConhecimentoSeo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConhecimentoWordpress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisponibilidadeAcimaOitoHorasDia = table.Column<bool>(type: "bit", nullable: false),
                    DisponibilidadeApenasFinaisSemana = table.Column<bool>(type: "bit", nullable: false),
                    DisponibilidadeQuatroHorasDia = table.Column<bool>(type: "bit", nullable: false),
                    DisponibilidadeQuatroSeisHorasDia = table.Column<bool>(type: "bit", nullable: false),
                    DisponibilidadeSeisOitoHorasDia = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true, maxLength: 10),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true, maxLength: 10),
                    HorasDisponiveisComercial = table.Column<bool>(type: "bit", nullable: false),
                    HorasDisponiveisMadrugada = table.Column<bool>(type: "bit", nullable: false),
                    HorasDisponiveisManha = table.Column<bool>(type: "bit", nullable: false),
                    HorasDisponiveisNoite = table.Column<bool>(type: "bit", nullable: false),
                    HorasDisponiveisTarde = table.Column<bool>(type: "bit", nullable: false),
                    InformacaoBancariaAgencia = table.Column<int>(type: "int", nullable: false, maxLength: 15),
                    InformacaoBancariaBanco = table.Column<string>(type: "nvarchar(max)", nullable: true, maxLength: 15),
                    InformacaoBancariaCpf = table.Column<long>(type: "bigint", nullable: false, maxLength: 15),
                    InformacaoBancariaNome = table.Column<string>(type: "nvarchar(max)", nullable: true, maxLength: 10),
                    InformacaoBancariaNumeroConta = table.Column<int>(type: "int", nullable: false, maxLength: 10),
                    InformacaoBancariaTipo = table.Column<string>(type: "nvarchar(max)", nullable: true, maxLength: 10),
                    InformacaoBancariaTipoContaCorrente = table.Column<bool>(type: "bit", nullable: true),
                    InformacaoBancariaTipoContaPoupanca = table.Column<bool>(type: "bit", nullable: true),
                    LinkCrud = table.Column<string>(type: "nvarchar(max)", nullable: true, maxLength: 15),
                    Linkedin = table.Column<string>(type: "nvarchar(max)", nullable: true, maxLength: 15),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false, maxLength: 15),
                    Outros = table.Column<string>(type: "nvarchar(max)", nullable: true, maxLength: 30),
                    Portfolio = table.Column<string>(type: "nvarchar(max)", nullable: true, maxLength: 15),
                    PretensaoSalarialHora = table.Column<int>(type: "int", nullable: false, maxLength: 3),
                    Skype = table.Column<string>(type: "nvarchar(max)", nullable: false, maxLength: 15),
                    Telefone = table.Column<int>(type: "int", nullable: false, maxLength: 15)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talent", x => x.TalentID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Talent");
        }
    }
}
