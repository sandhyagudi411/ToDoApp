using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using TechTalk.SpecFlow;

namespace ToDoApp
{
    [Binding]
    public class SpecFlowScenarioOutlineFeatureSteps
    {
        public static String test_url = "https://www.spotify.com/us/";

        IWebDriver driver;

        [Given(@"user navigates to Spotify Website")]
        public void GivenUserNavigatesToSpotifyWebsite()
        {
            driver = new ChromeDriver();
            driver.Url = test_url;
            System.Threading.Thread.Sleep(2000);
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(2000);
        }

        [When(@"User should be able to view Login button and User clicks on Login button")]
        public void WhenUserShouldBeAbleToViewLoginButtonAndUserClicksOnLoginButton()
        {
            driver.FindElement(By.XPath("(//a[text()='Log in'])"));
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//a[text()='Log in'])")).Click();
            System.Threading.Thread.Sleep(2000);
        }

        [When(@"User enters Username as '(.*)' and Password as '(.*)'")]
        public void WhenUserEntersUsernameAsAndPasswordAs(string arg1, string arg2)
        {
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("(//*[@id='login-username'])")).SendKeys(arg1);
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//*[@id='login-password'])")).SendKeys(arg2);
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//span[@class='control-indicator'])")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//button[@id='login-button'])")).Click();
            System.Threading.Thread.Sleep(2000);

        }
        [Then(@"the login should be successful")]
        public void ThenTheLoginShouldBeSuccessful()
        {
            System.Threading.Thread.Sleep(8000);
            driver.Navigate().Refresh();
            string currURL = this.driver.Url;
            Assert.NotNull(currURL);
            System.Threading.Thread.Sleep(2000);
            driver.Close();
        }








    }
}
