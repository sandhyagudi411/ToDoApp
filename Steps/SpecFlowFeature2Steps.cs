using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ToDoApp
{
    [Binding]
    public class SpecFlowFeature2Steps
    {
        public static String test_url = "https://techcrunch.com/";

        IWebDriver driver;

        [Given(@"that I am on the Tech Crunch Website")]
        public void GivenThatIAmOnTheTechCrunchWebsite()
        {
            driver = new ChromeDriver();
            driver.Url = test_url;
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(2000);
        }

        [Then(@"User should be able to view Login Link")]
        public void ThenUserShouldBeAbleToViewLoginLink()
        {
            driver.FindElement(By.XPath("(//*[@id='google_esf'])"));
            System.Threading.Thread.Sleep(5000);
        }

        [When(@"User clicks on Login Link")]
        public void WhenUserClicksOnLoginLink()
        {
            driver.FindElement(By.XPath("(//a[text()='Login'])"));
            System.Threading.Thread.Sleep(4000);
            //driver.FindElement(By.XPath("//*[@id='root']/div/div/header/div/div[2]/div/div[1]/a")).Click();
            driver.FindElement(By.XPath("(//a[text()='Login'])")).Click();
            System.Threading.Thread.Sleep(2000);
        }

        [Then(@"User should be able to view create account link")]
        public void ThenUserShouldBeAbleToViewCreateAccountLink()
        {
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//*[@id='createacc'])"));
            System.Threading.Thread.Sleep(2000);
        }



    }
}
