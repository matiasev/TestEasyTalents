﻿// <auto-generated />
using EasyTalentsData.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EasyTalentsData.Migrations
{
    [DbContext(typeof(EasyTalentsContext))]
    [Migration("20170911012528_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EasyTalentsData.Models.Talent", b =>
                {
                    b.Property<int>("TalentID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BancoInformacao");

                    b.Property<string>("Cidade");

                    b.Property<string>("ConhecimentoAndroid");

                    b.Property<string>("ConhecimentoAngularJs");

                    b.Property<string>("ConhecimentoAspNetMvc");

                    b.Property<string>("ConhecimentoBootstrap");

                    b.Property<string>("ConhecimentoC");

                    b.Property<string>("ConhecimentoCake");

                    b.Property<string>("ConhecimentoCplusplus");

                    b.Property<string>("ConhecimentoCss");

                    b.Property<string>("ConhecimentoDjango");

                    b.Property<string>("ConhecimentoHtml");

                    b.Property<string>("ConhecimentoIllustrator");

                    b.Property<string>("ConhecimentoIonic");

                    b.Property<string>("ConhecimentoIos");

                    b.Property<string>("ConhecimentoJava");

                    b.Property<string>("ConhecimentoJquery");

                    b.Property<string>("ConhecimentoMajento");

                    b.Property<string>("ConhecimentoMySql");

                    b.Property<string>("ConhecimentoMySqlServer");

                    b.Property<string>("ConhecimentoPhotoshop");

                    b.Property<string>("ConhecimentoPhp");

                    b.Property<string>("ConhecimentoPhyton");

                    b.Property<string>("ConhecimentoRuby");

                    b.Property<string>("ConhecimentoSalesforce");

                    b.Property<string>("ConhecimentoSeo");

                    b.Property<string>("ConhecimentoWordpress");

                    b.Property<bool>("DisponibilidadeAcimaOitoHorasDia");

                    b.Property<bool>("DisponibilidadeApenasFinaisSemana");

                    b.Property<bool>("DisponibilidadeQuatroHorasDia");

                    b.Property<bool>("DisponibilidadeQuatroSeisHorasDia");

                    b.Property<bool>("DisponibilidadeSeisOitoHorasDia");

                    b.Property<string>("Email");

                    b.Property<string>("Estado");

                    b.Property<bool>("HorasDisponiveisComercial");

                    b.Property<bool>("HorasDisponiveisMadrugada");

                    b.Property<bool>("HorasDisponiveisManha");

                    b.Property<bool>("HorasDisponiveisNoite");

                    b.Property<bool>("HorasDisponiveisTarde");

                    b.Property<int>("InformacaoBancariaAgencia");

                    b.Property<string>("InformacaoBancariaBanco");

                    b.Property<long>("InformacaoBancariaCpf");

                    b.Property<string>("InformacaoBancariaNome");

                    b.Property<int>("InformacaoBancariaNumeroConta");

                    b.Property<string>("InformacaoBancariaTipo");

                    b.Property<bool>("InformacaoBancariaTipoContaCorrente");

                    b.Property<bool>("InformacaoBancariaTipoContaPoupanca");

                    b.Property<string>("LinkCrud");

                    b.Property<string>("Linkedin");

                    b.Property<string>("Nome");

                    b.Property<string>("Outros");

                    b.Property<string>("Portfolio");

                    b.Property<int>("PretensaoSalarialHora");

                    b.Property<string>("Skype");

                    b.Property<int>("Telefone");

                    b.HasKey("TalentID");

                    b.ToTable("Talent");
                });
#pragma warning restore 612, 618
        }
    }
}
