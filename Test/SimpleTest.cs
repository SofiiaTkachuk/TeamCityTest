using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test
{
    [TestFixture]
    public static class SimpleTest
    {
        [TestCase]
        public static void OpenGoogle()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("user-data-dir=/path/to/your/custom/profile");
            options.AddArguments("start-maximized");
            IWebDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://www.google.com.ua/");
            driver.Close();
        }
    }
}