using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace YouTube_Project.StepDefinitions
{
    [Binding]
    public class YouTubeSearchStepDefinitions
    {
        IWebDriver.webDriver = new ChromeDriver(@"C:\Users\SAMUEL\Documents\ChromeDriver");

        [Given(@"I open the browser")]
        public void GivenIOpenTheBrowser()
        {
            WebDriver = new ChromeDriver(@"C:\Users\SAMUEL\Documents\ChromeDriver");
            driver.Manage().Window.Maximize();

            Thread.Sleep(2000);
            
        }

        [When(@"I then enter the URL")]
        public void WhenIThenEnterTheURL()
        {
            WebDriver.Navigate().GoToUrl("https://www.youtube.com/");

           Thread.Sleep(3000);

        }

        [Then(@"I search for Testers Talk")]
        public void ThenISearchForTestersTalk()
        {
            WebDriver.FindElement(By.XPath(//*[@id="search"])). Sendkeys("Testers Talk");
            WebDriver.FindElement(By.XPath(//*[@id="search"])). Sendkeys("Keys.Enter");
                           
            driver.Quit();
        }
    }
}
