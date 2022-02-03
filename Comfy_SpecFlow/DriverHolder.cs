using System;
using Xunit;
using OpenQA.Selenium;

    namespace Comfy_SpecFlow
    {
        public partial class UnitTest1
        {
            public class DriverHolder
            {
                public static IWebDriver driver { get; set; }
            }
        }
    }
