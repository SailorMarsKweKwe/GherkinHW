using OpenQA;
using OpenQA.Selenium;
using Comfy_SpecFlow;
using TechTalk.SpecFlow;

namespace Comfy_SpecFlow
{
    [Binding]
    public class FilterTests:BaseTest
    {
        [Given(@"User on the homepage")]
        public void GivenUserOnTheHomepage()
        {
            DriverHolder.driver = StartDriverWithURL("http://dnepr.i-mne.com/");
        }

        [When(@"User click on demanded category of products")]
        public void WhenUserClickOnDemandedCategoryOfProducts()
        {
            IWebElement enterButtonElement = DriverHolder.driver.FindElement(By.XPath("//a[contains(text(),'Вход')]"));
            enterButtonElement.Click();
        }
    }
}