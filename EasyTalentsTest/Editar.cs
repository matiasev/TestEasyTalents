using EasyTalentsTest;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTalentsT
{
    public class Editar: Base
    {
        [Test]
        public void EditarTalent()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            driver.FindElementByClassName("lista").Click();
            
            wait.Until(x => x.FindElement(By.ClassName("btn-primary")));

            driver.FindElementByClassName("btn-primary").Click();

            wait.Until(x => x.FindElement(By.Name("email")));

            driver.FindElementByName("email").Clear();
            driver.FindElementByName("email").SendKeys("pedro@gmail.com");
            driver.FindElementByName("nome").Clear();
            driver.FindElementByName("nome").SendKeys("Pedro");
            driver.FindElementByName("skype").Clear();
            driver.FindElementByName("skype").SendKeys("pedroluiz");
            driver.FindElementByName("telefone").Clear();
            driver.FindElementByName("telefone").SendKeys("88887777");
            driver.FindElementByName("linkedin").Clear();
            driver.FindElementByName("linkedin").SendKeys("pedroluiz");
            driver.FindElementByName("cidade").Clear();
            driver.FindElementByName("cidade").SendKeys("Santos");
            driver.FindElementByName("estado").Clear();
            driver.FindElementByName("estado").SendKeys("São Paulo");
            driver.FindElementByName("portfolio").Clear();
            driver.FindElementByName("portfolio").SendKeys("pedro.com");
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
            driver.FindElementByName("pretensaoSalarialHora").Clear();
            driver.FindElementByName("pretensaoSalarialHora").SendKeys("15");
            driver.FindElementByName("bancoInformacao").Clear();
            driver.FindElementByName("bancoInformacao").SendKeys("Banco");
            driver.FindElementByName("informacaoBancariaNome").Clear();
            driver.FindElementByName("informacaoBancariaNome").SendKeys("Pedro Luiz");
            driver.FindElementByName("informacaoBancariaCpf").Clear();
            driver.FindElementByName("informacaoBancariaCpf").SendKeys("3334445557");
            driver.FindElementByName("informacaoBancariaBanco").Clear();
            driver.FindElementByName("informacaoBancariaBanco").SendKeys("Bradesco");
            driver.FindElementByName("informacaoBancariaAgencia").Clear();
            driver.FindElementByName("informacaoBancariaAgencia").SendKeys("5544");
            driver.FindElementByName("informacaoBancariaTipo").SendKeys("C");
            driver.FindElementByName("informacaoBancariaNumeroConta").Clear();
            driver.FindElementByName("informacaoBancariaNumeroConta").SendKeys("554433");

            driver.FindElementByCssSelector(@"input[name='conhecimentoIonic'][value='1']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoAndroid'][value='2']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoIos'][value='5']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoHtml'][value='4']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoCss'][value='2']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoBootstrap'][value='4']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoJquery'][value='1']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoAngularJs'][value='3']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoJava'][value='2']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoAspNetMvc'][value='5']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoC'][value='1']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoCplusplus'][value='3']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoCake'][value='4']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoDjango'][value='2']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoMajento'][value='4']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoPhp'][value='1']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoWordpress'][value='3']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoPhyton'][value='5']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoRuby'][value='4']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoMySqlServer'][value='2']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoMySql'][value='1']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoSalesforce'][value='4']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoPhotoshop'][value='2']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoIllustrator'][value='5']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoSeo'][value='2']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoIonic'][value='5']").Click();
            driver.FindElementByCssSelector(@"input[name='conhecimentoIonic'][value='3']").Click();

            driver.FindElementByName("outros").Clear();
            driver.FindElementByName("outros").SendKeys("Aurelia");
            driver.FindElementByName("linkCrud").Clear();
            driver.FindElementByName("linkCrud").SendKeys("pedro.com.br");

            driver.FindElementByClassName("btn-primary").Click();

            wait.Until(x => x.SwitchTo().Alert());

            driver.SwitchTo().Alert().Accept();

            Console.WriteLine("Executed Test");
        }
    }
}
