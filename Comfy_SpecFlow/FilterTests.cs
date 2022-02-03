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
            UnitTest1.DriverHolder.driver = StartDriverWithURL("");
        }

        [When(@"User click on demanded category of products")]
        public void WhenUserClickOnDemandedCategoryOfProducts()
        {
            ScenarioContext.StepIsPending();
        }
    }
}