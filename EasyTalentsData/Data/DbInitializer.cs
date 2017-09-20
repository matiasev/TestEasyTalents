using EasyTalentsData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyTalentsData.Data
{
    public class DbInitializer
    {
        public static void Initialize(EasyTalentsContext context)
        {
            context.Database.EnsureCreated();

            if (context.Talents.Any())
            {
                return;
            }

            var Talents = new Talent[]
            {
                new Talent{ DataCadastro=DateTime.Parse("15-09-2017"), Email="talent@email.com", Nome="Talent", Skype="talent", Telefone=99999999, Linkedin="talent", Cidade="Marilia", Estado="São Paulo", Portfolio="talent.com", DisponibilidadeAcimaOitoHorasDia=true, DisponibilidadeApenasFinaisSemana=false, DisponibilidadeQuatroHorasDia=true, DisponibilidadeQuatroSeisHorasDia=false, DisponibilidadeSeisOitoHorasDia=true, HorasDisponiveisComercial=true, HorasDisponiveisMadrugada=true, HorasDisponiveisManha=false, HorasDisponiveisNoite=true, HorasDisponiveisTarde=false, PretensaoSalarialHora=13, BancoInformacao="Banco", InformacaoBancariaNome="Itau", InformacaoBancariaCpf=11122233301, InformacaoBancariaBanco="Itau", InformacaoBancariaAgencia=1221, InformacaoBancariaTipo="C", InformacaoBancariaNumeroConta=123454, ConhecimentoIonic="1", ConhecimentoAndroid="1", ConhecimentoIos="1", ConhecimentoHtml="1", ConhecimentoCss="3", ConhecimentoBootstrap="5", ConhecimentoJquery="2", ConhecimentoAngularJs="3", ConhecimentoJava="5",ConhecimentoAspNetMvc="3", ConhecimentoC="4", ConhecimentoCplusplus="5", ConhecimentoCake="5", ConhecimentoDjango="5", ConhecimentoMajento="4", ConhecimentoPhp="5", ConhecimentoWordpress="5", ConhecimentoPhyton="1", ConhecimentoRuby="1", ConhecimentoMySqlServer="2", ConhecimentoMySql="1", ConhecimentoSalesforce="2", ConhecimentoPhotoshop="5", ConhecimentoIllustrator="4", ConhecimentoSeo="3", LinkCrud="talent.com", Outros="Nenhum"},

                 new Talent{ DataCadastro=DateTime.Parse("14-09-2017"), Email ="talent2@email.com", Nome="Talent2", Skype="talent2", Telefone=99998888, Linkedin="talent2", Cidade="Santos", Estado="São Paulo", Portfolio="talent2.com", DisponibilidadeAcimaOitoHorasDia=false, DisponibilidadeApenasFinaisSemana=true, DisponibilidadeQuatroHorasDia=false, DisponibilidadeQuatroSeisHorasDia=true, DisponibilidadeSeisOitoHorasDia=false, HorasDisponiveisComercial=true, HorasDisponiveisMadrugada=false, HorasDisponiveisManha=true, HorasDisponiveisNoite=true, HorasDisponiveisTarde=true, PretensaoSalarialHora=33, BancoInformacao="Banco2", InformacaoBancariaNome="Bradesco", InformacaoBancariaCpf=111434334233301, InformacaoBancariaBanco="Bradesco", InformacaoBancariaAgencia=4433, InformacaoBancariaTipo="P", InformacaoBancariaNumeroConta=321454, ConhecimentoIonic="1", ConhecimentoAndroid="1", ConhecimentoIos="1", ConhecimentoHtml="1", ConhecimentoCss="3", ConhecimentoBootstrap="5", ConhecimentoJquery="2", ConhecimentoAngularJs="3", ConhecimentoJava="5",ConhecimentoAspNetMvc="3", ConhecimentoC="4", ConhecimentoCplusplus="5", ConhecimentoCake="5", ConhecimentoDjango="5", ConhecimentoMajento="4", ConhecimentoPhp="5", ConhecimentoWordpress="5", ConhecimentoPhyton="1", ConhecimentoRuby="1", ConhecimentoMySqlServer="2", ConhecimentoMySql="1", ConhecimentoSalesforce="2", ConhecimentoPhotoshop="5", ConhecimentoIllustrator="4", ConhecimentoSeo="3", LinkCrud="talent2.com", Outros="Nenhum2"}
            };

            foreach (Talent t in Talents)
            {
                context.Talents.Add(t);
            }

            context.SaveChanges();
        }
    }
}
