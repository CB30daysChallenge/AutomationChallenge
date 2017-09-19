using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutomationChallenge
{
    [Binding]
    public class Hooks
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void SetupBrowser()
        {
            driver = new ChromeDriver();

             Console.WriteLine("setting up browser");
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://todomvc.com/examples/angularjs/#/");
           
        }
        [AfterScenario]
        public void Cleanup()
        {
            //driver.Close();
            Console.WriteLine("Cleaning up");
        }
    }
}
