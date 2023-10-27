using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace acuk1.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {
        public ChromeDriver WebDriver { get; private set; }

        IWebDriver webDriver= new ChromeDriver(@"C:\\Users\\SAMUEL\\Documents\\Chrome Driver");
        private By password;

        [Given(@"that I open the browser")]
        public void GivenThatIOpenTheBrowser()
        {
            WebDriver = new ChromeDriver(@"C:\\Users\\SAMUEL\\Documents\\Chrome Driver");
        }

        [Then(@"I enter the url link")]
        public void ThenIEnterTheUrlLink()
        {
            webDriver.Manage().Window.Maximize();

            WebDriver .Navigate().GoToUrl("https://qa.advancecareersuk.com");

        }

        [Then(@"I click on login button")]
        public void ThenIClickOnLoginButton()
        {
            var loginbutton = By.XPath("//*[@id=\"navbarNav\"]/ul/li[7]/a");

            WebDriver.FindElement(loginbutton).Click();

            Thread.Sleep(2000);
        }

        [Then(@"I enter Email address of a registered user")]
        public void ThenIEnterEmailAddressOfARegisteredUser()
        {
            var EmailField = By.Id("Email");

           WebDriver.FindElement(EmailField).SendKeys("samadey25@gmail.com");

            Thread.Sleep(2000);
        }

        [Then(@"I enter Password")]
        public void ThenIEnterPassword()
        {
            var passwordField = By.Id("password");

            webDriver.FindElement(password).SendKeys("S@madey22011985");

            Thread.Sleep(2000);
        }

        [Then(@"I click remember me")]
        public void ThenIClickRememberMe()
        {
            var remember = By.XPath("//*[@id=\"remember\"]");

            WebDriver.FindElement(remember).Click();

        }

        [Then(@"I click on Log in")]
        public void ThenIClickOnLogIn()
        {
            var submitbutton = By.XPath("/html/body/div/div/div[1]/div/div/div[3]/form/div[5]/div[2]/button\r\n");
            
            WebDriver.FindElement(submitbutton).Click();

            Thread.Sleep(3000);
        }

        [Then(@"I validate user logged in")]
        public void ThenIValidateUserLoggedIn()
        {
            var logged = By.Id("Test S");

            webDriver.FindElement (logged).Click();
        }

        [Then(@"then I click logout")]
        public void ThenThenIClickLogout()
        {
            var ClickLogout = By.Id("Test S");

             webDriver.FindElement (ClickLogout).Click();

            var Logout = By.XPath("//*[@id=\"logout-form\"]");

            webDriver.FindElement(Logout).Click();

            Task.Delay(2500).Wait();
        }

        [Then(@"I see the website homepage loaded")]
        public void ThenISeeTheWebsiteHomepageLoaded()
        {
            webDriver.Navigate().GoToUrl("https://qa.advancecareersuk.com");

            Task.Delay(2000).Wait();
        }

        [Then(@"I close browser")]
        public void ThenICloseBrowser()
        {
            WebDriver.Close();    
        }
    }
}
