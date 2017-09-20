using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace EasyTalentsTest
{
    
    public class Base
    {
        protected ChromeDriver driver;

        string page = "http://localhost:62014/";

        public Base()
        {
            driver = new ChromeDriver();
        }

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl(page);

            Console.WriteLine("Opened URL");
        }

        [TearDown]
        public void CleanUp()
        {
            Thread.Sleep(1000);
            driver.Close();

            Console.WriteLine("Closed");
        }
    }
}
