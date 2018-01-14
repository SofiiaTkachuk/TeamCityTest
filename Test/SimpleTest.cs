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
    public class SimpleTest
    {
        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            //FirefoxProfile fp = new FirefoxProfile();
            //fp.SetPreference("browser.startup.homepage", "about:blank");
            //fp.SetPreference("startup.homepage_welcome_url", "about:blank");
            //fp.SetPreference("startup.homepage_welcome_url.additional", "about:blank");
            IWebDriver driver = new ChromeDriver();
        }

        [TestCase]
        public void OpenGoogle()
        {
            driver.Url = "https://www.google.com.ua/";
        }

        [TearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}