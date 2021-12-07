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
    public class SpecFlowFeature1Steps
    {
        public static String test_url = "https://lambdatest.github.io/sample-todo-app/";

        IWebDriver driver;

        [Given(@"that I am on the Lambda Test Sample App")]
        public void GivenThatIAmOnTheLambdaTestSampleApp()
        {
            driver = new ChromeDriver();
            driver.Url = test_url;
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(2000);
        }

    }
}
