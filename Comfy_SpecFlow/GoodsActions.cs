using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Xunit;
using OpenQA.Selenium.Interactions;


namespace Comfy_SpecFlow
{
    [Binding]
    public class GoodsActions
    {
        // По сценарию чтения комментариев.
        [When(@"user click on '(.*)' link")]
        public void WhenUserClickOnLink(string p0)
        {
            ScenarioContext.StepIsPending();
        }
        [When(@"user scroll to the '(.*)' link")]
        public void WhenUserScrollToTheLink(string p0)
        {
            var element = DriverHolder.driver.FindElement(By.XPath("//p[7]"));
            Actions actions = new Actions(DriverHolder.driver);
            actions.MoveToElement(element).Perform();
        }
        [Then(@"user sees the comments")]
        public void ThenUserSeesTheComments()
        {
            IWebElement textElement = DriverHolder.driver.FindElement(By.XPath("//em"));
            string actual = textElement.Text;
            Assert.Equal("Отзывы", actual);
        }

         // По сценарию чтения интересной информации.
        [When(@"user type '(.*)' in the search box")]
        public void WhenUserTypeInTheSearchBox(string p0)
        {
            ScenarioContext.StepIsPending();
        }

        [When(@"user press '(.*)' button")]
        public void WhenUserPressButton(string enter)
        {
            ScenarioContext.StepIsPending();
        }

        [When(@"user click on the first product")]
        public void WhenUserClickOnTheFirstProduct()
        {
            ScenarioContext.StepIsPending();
        }

        [Then(@"user see the '(.*)' text")]
        public void ThenUserSeeTheText(string p0)
        {
            ScenarioContext.StepIsPending();
        }
        
        // По сценарию добавления в корзину.
        [When(@"user click '(.*)' linked text")]
        public void WhenUserClickLinkedText(string p0)
        {
            ScenarioContext.StepIsPending();
        }

        [When(@"user click on '(.*)' button under ginger jam")]
        public void WhenUserClickOnButtonUnderGingerJam(string купить)
        {
            ScenarioContext.StepIsPending();
        }

        [When(@"user click on '(.*)' button under artichoke jam")]
        public void WhenUserClickOnButtonUnderArtichokeJam(string купить)
        {
            ScenarioContext.StepIsPending();
        }

        [Then(@"user see the shopping cart popup")]
        public void ThenUserSeeTheShoppingCartPopup()
        {
            ScenarioContext.StepIsPending();
        }
        
        // По сценарию удаления из корзины.
        [When(@"user hover mouse over the first product in the cart")]
        public void WhenUserHoverMouseOverTheFirstProductInTheCart()
        {
            ScenarioContext.StepIsPending();
        }

        [When(@"user click the delete icon of the first product in the cart")]
        public void WhenUserClickTheDeleteIconOfTheFirstProductInTheCart()
        {
            ScenarioContext.StepIsPending();
        }

        [When(@"user hover mouse over the second product in the cart")]
        public void WhenUserHoverMouseOverTheSecondProductInTheCart()
        {
            ScenarioContext.StepIsPending();
        }

        [When(@"user click the delete icon of the second product in the cart")]
        public void WhenUserClickTheDeleteIconOfTheSecondProductInTheCart()
        {
            ScenarioContext.StepIsPending();
        }

        [Then(@"user see the empty shopping cart")]
        public void ThenUserSeeTheEmptyShoppingCart()
        {
            ScenarioContext.StepIsPending();
        }
    }
}