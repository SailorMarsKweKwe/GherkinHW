using OpenQA;
using OpenQA.Selenium;
using Comfy_SpecFlow;
using TechTalk.SpecFlow;
using Xunit;

namespace Comfy_SpecFlow
{
    [Binding]
    public class UsingAccountTests:BaseTest
    {
        [Given(@"user on the homepage")]
        public void GivenUserOnTheHomepage()
        {
            DriverHolder.driver = StartDriverWithURL("http://dnepr.i-mne.com/");
        }

        [When(@"user click on enterence button")]
        public void WhenUserClickOnEnterenceButton()
        {
            IWebElement enterBtn = DriverHolder.driver.FindElement(By.XPath("//a[contains(text(),'Вход')]"));
            enterBtn.Click();
        }
        // Отработка сценария регистрации.
        [When(@"user click on registration button")]
        public void GivenUserClickOnRegistrationButton()
        {
            IWebElement registrationBtn = DriverHolder.driver.FindElement(By.LinkText("Регистрация"));
            registrationBtn.Click();
        }

        [When(@"user enter the '(.*)' in name field")]
        public void WhenUserEnterTheInNameField(string p0)
        {
            IWebElement nameElement = DriverHolder.driver.FindElement(By.Id("customer_firstname"));
            nameElement.SendKeys("Example");
        }

        [When(@"user enter the '(.*)' in surname field")]
        public void WhenUserEnterTheInSurnameField(string p0)
        {
            IWebElement surnameElement = DriverHolder.driver.FindElement(By.Id("customer_lastname"));
            surnameElement.SendKeys("ExampleSecond");
        }

        [When(@"user enter the '(.*)' in phonenumber field")]
        public void WhenUserEnterTheInPhonenumberField(string p0)
        {
            IWebElement phoneElement = DriverHolder.driver.FindElement(By.Id("phone_mobile"));
            phoneElement.SendKeys("+380931111112");
        }

        [When(@"user enter the '(.*)' in email field")]
        public void WhenUserEnterTheInEmailField(string p0)
        {
            IWebElement emailElement = DriverHolder.driver.FindElement(By.Id("email"));
            emailElement.SendKeys("exampletest1@ua.fm");
        }

        [When(@"user enter the '(.*)' in password field")]
        public void WhenUserEnterTheInPasswordField(string p0)
        {
            IWebElement passwordElement = DriverHolder.driver.FindElement(By.Id("passwd"));
            passwordElement.SendKeys("Example55&");
        }

        [When(@"user click on registration confirmation button")]
        public void WhenUserClickOnRegistrationConfirmationButton()
        {
            IWebElement submittBtn = DriverHolder.driver.FindElement(By.Id("submitAccount"));
            submittBtn.Click();
        }


        [When(@"user click on his name link in the upper right corner")]
        public void WhenUserClickOnHisNameLinkInTheUpperRightCorner()
        {
            IWebElement accountElement = DriverHolder.driver.FindElement(By.LinkText("Example ExampleSecond"));
            accountElement.Click();
        }

        [Then(@"user sees the account page")]
        public void ThenUserSeesTheAccountPage()
        {
            IWebElement accountTextElement = DriverHolder.driver.FindElement(By.XPath("//main/div/div/p"));
            string actual = accountTextElement.Text;
            Assert.Equal("Example, добро пожаловать в ваш профиль на сайте И-МНЕ Днепр!", actual);
        }

        // Отработка сценария авторизации.
        [When(@"user enter the '(.*)' in the email field")]
        public void WhenUserEnterTheInTheEmailField(string p0)
        {
            IWebElement emailFieldElement = DriverHolder.driver.FindElement(By.Id("email_ajax"));
            emailFieldElement.SendKeys("exampletest@ua.fm");
        }


        [When(@"user enter the '(.*)' in the password field")]
        public void WhenUserEnterTheInThePasswordField(string p0)
        {
            IWebElement passwordFieldElement = DriverHolder.driver.FindElement(By.Id("passwd_ajax"));
            passwordFieldElement.SendKeys("Example55&");
        }

        [When(@"user click on confirmation button")]
        public void WhenUserClickOnConfirmationButton()
        {
            IWebElement submittElement = DriverHolder.driver.FindElement(By.Id("SubmitLogin_ajax"));
            submittElement.Click();
        }

        [When(@"user click on his name linked text in the upper right corner")]
        public void WhenUserClickOnHisNameLinkedTextInTheUpperRightCorner()
        {
            IWebElement accountElement = DriverHolder.driver.FindElement(By.LinkText("Example ExampleSecond"));
            accountElement.Click(); 
        }

        [Then(@"user see the account page")]
        public void ThenUserSeeTheAccountPage()
        {
            IWebElement accountTextElement = DriverHolder.driver.FindElement(By.XPath("//div/span[2]"));
            string actual = accountTextElement.Text;
            Assert.Equal("Мой аккаунт", actual);
        }
        
        // Сценарий добавления нового адреса в аккаунт
        [When(@"user input the '(.*)' in the email field")]
        public void WhenUserInputTheInTheEmailField(string p0)
        {
            ScenarioContext.StepIsPending();
        }
    }
}