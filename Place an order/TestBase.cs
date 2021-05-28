using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Place_an_order
{
   public  class TestBase
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        

        }
        [TearDown]
        public void Cleanup()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
