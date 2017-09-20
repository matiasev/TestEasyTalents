using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyTalentsTest
{
    public class Adicionar: Base
    {
        [Test]
        public void AdicionarTalent()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            driver.FindElementByName("email").SendKeys("julio@gmail.com");
            driver.FindElementByName("nome").SendKeys("julio");
            driver.FindElementByName("skype").SendKeys("juliosilva");
            driver.FindElementByName("telefone").SendKeys("99999999");
            driver.FindElementByName("linkedin").SendKeys("julioSilva");
            driver.FindElementByName("cidade").SendKeys("Marilia");
            driver.FindElementByName("estado").SendKeys("São Paulo");
            driver.FindElementByName("portfolio").SendKeys("julio.com");
            driver.FindElementByName("disponibilidadeQuatroHorasDia").Click();
            driver.FindElementByName("disponibilidadeQuatroSeisHorasDia").Click();
            driver.FindElementByName("disponibilidadeSeisOitoHorasDia").Click();
            driver.FindElementByName("disponibilidadeAcimaOitoHorasDia").Click();
            driver.FindElementByName("disponibilidadeApenasFinaisSemana").Click();
            driver.FindElementByName("horasDisponiveisManha").Click();
            driver.FindElementByName("horasDisponiveisTarde").Click();
            driver.FindElementByName("horasDisponiveisNoite").Click();
            driver.FindElementByName("horasDisponiveisMadrugada").Click();
            driver.FindElementByName("horasDisponiveisComercial").Click();
            driver.FindElementByName("pretensaoSalarialHora").SendKeys("20");
            driver.FindElementByName("bancoInformacao").SendKeys("Paypal");
            driver.FindElementByName("informacaoBancariaNome").SendKeys("Julio Silva");
            driver.FindElementByName("informacaoBancariaCpf").SendKeys("11122233300");
            driver.FindElementByName("informacaoBancariaBanco").SendKeys("Itau");
            driver.FindElementByName("informacaoBancariaAgencia").SendKeys("1221");
            driver.FindElementByName("informacaoBancariaTipo").SendKeys("P");
            driver.FindElementByName("informacaoBancariaNumeroConta").SendKeys("223340");
            
            driver.FindElementByCssSelector(@"input[name='conhecimentoIonic'][value='2']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoAndroid'][value='3']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoIos'][value='2']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoHtml'][value='1']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoCss'][value='4']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoBootstrap'][value='5']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoJquery'][value='3']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoAngularJs'][value='5']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoJava'][value='1']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoAspNetMvc'][value='2']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoC'][value='4']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoCplusplus'][value='2']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoCake'][value='5']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoDjango'][value='3']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoMajento'][value='3']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoPhp'][value='2']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoWordpress'][value='4']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoPhyton'][value='1']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoRuby'][value='1']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoMySqlServer'][value='3']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoMySql'][value='5']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoSalesforce'][value='3']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoPhotoshop'][value='1']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoIllustrator'][value='3']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoSeo'][value='4']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoIonic'][value='1']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoIonic'][value='2']").Click();

            driver.FindElementByName("outros").SendKeys("NodeJs");
            driver.FindElementByName("linkCrud").SendKeys("julio.com.br");

            driver.FindElementByClassName("btn-primary").Click();

            wait.Until(x => x.SwitchTo().Alert());

            driver.SwitchTo().Alert().Accept();

            Console.WriteLine("Executed Test");
        }
    }
}
  