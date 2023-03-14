using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace selenium
{
    [TestClass]
    public class UnitTest
    {
        private IWebDriver test_driver;
        [TestMethod]
        public void TestSite()
        {
            test_driver = new ChromeDriver();
            test_driver.Navigate().GoToUrl("https://dpsnoida.co.in/");
            Assert.IsTrue(test_driver.Title.Contains("DPS Noida"));
            test_driver.Quit();
        }
    }
}
