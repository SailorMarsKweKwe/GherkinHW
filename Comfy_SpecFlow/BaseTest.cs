using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Comfy_SpecFlow
{
    public class BaseTest : IDisposable
    {
        public IWebDriver StartDriverWithURL(string url)
        {
            UnitTest1.DriverHolder.driver = new ChromeDriver();
            UnitTest1.DriverHolder.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            UnitTest1.DriverHolder.driver.Manage().Window.Maximize();
            UnitTest1.DriverHolder.driver.Navigate().GoToUrl(url);
            return UnitTest1.DriverHolder.driver;
        }
        public void Dispose()
        {
           UnitTest1.DriverHolder.driver.Quit();
        }
    }
}