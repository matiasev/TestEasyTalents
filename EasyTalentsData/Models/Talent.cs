using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyTalentsData.Models
{
    public class Talent
    {
        public int TalentID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DataCadastro { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Skype { get; set; }
        public int Telefone { get; set; }
        public string Linkedin { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Portfolio { get; set; }

        public bool DisponibilidadeQuatroHorasDia { get; set; }
        public bool DisponibilidadeQuatroSeisHorasDia { get; set; }
        public bool DisponibilidadeSeisOitoHorasDia { get; set; }
        public bool DisponibilidadeAcimaOitoHorasDia { get; set; }
        public bool DisponibilidadeApenasFinaisSemana { get; set; }

        public bool HorasDisponiveisManha { get; set; }
        public bool HorasDisponiveisTarde { get; set; }
        public bool HorasDisponiveisNoite { get; set; }
        public bool HorasDisponiveisMadrugada { get; set; }
        public bool HorasDisponiveisComercial { get; set; }

        public int PretensaoSalarialHora { get; set; }
        public string BancoInformacao { get; set; }
        public string InformacaoBancariaNome { get; set; }
        public Int64 InformacaoBancariaCpf { get; set; }
        public string InformacaoBancariaBanco { get; set; }
        public int InformacaoBancariaAgencia { get; set; }
        public string InformacaoBancariaTipo { get; set; }
        public int InformacaoBancariaNumeroConta { get; set; }

        public string ConhecimentoIonic { get; set; }
        public string ConhecimentoAndroid { get; set; }
        public string ConhecimentoIos { get; set; }
        public string ConhecimentoHtml { get; set; }
        public string ConhecimentoCss { get; set; }
        public string ConhecimentoBootstrap { get; set; }
        public string ConhecimentoJquery { get; set; }
        public string ConhecimentoAngularJs { get; set; }
        public string ConhecimentoJava { get; set; }
        public string ConhecimentoAspNetMvc { get; set; }
        public string ConhecimentoC { get; set; }
        public string ConhecimentoCplusplus { get; set; }
        public string ConhecimentoCake { get; set; }
        public string ConhecimentoDjango { get; set; }
        public string ConhecimentoMajento { get; set; }
        public string ConhecimentoPhp { get; set; }
        public string ConhecimentoWordpress { get; set; }
        public string ConhecimentoPhyton { get; set; }
        public string ConhecimentoRuby { get; set; }
        public string ConhecimentoMySqlServer { get; set; }
        public string ConhecimentoMySql { get; set; }
        public string ConhecimentoSalesforce { get; set; }
        public string ConhecimentoPhotoshop { get; set; }
        public string ConhecimentoIllustrator { get; set; }
        public string ConhecimentoSeo { get; set; }
        public string Outros { get; set; }

        public string LinkCrud { get; set; }
    }
}
