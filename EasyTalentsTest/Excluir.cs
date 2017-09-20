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
    public class Excluir: Base
    {
        [Test]
        public void ExcluirTalent()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            driver.FindElementByClassName("lista").Click();

            wait.Until(x => x.FindElement(By.ClassName("btn-danger")));

            driver.FindElementByClassName("btn-danger").Click();

            wait.Until(x => x.SwitchTo().Alert());

            driver.SwitchTo().Alert().Accept();

            Console.WriteLine("Executed Test");
        }
    }
}
