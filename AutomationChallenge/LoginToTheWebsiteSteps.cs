using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;


namespace AutomationChallenge
{
    [Binding]
    public class LoginToTheWebsiteSteps
    {
        [Given(@"I am on ToDoMvc anjularjs website")]
        public void GivenIAmOnToDoMvcWebsite()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("http://todomvc.com/examples/angularjs/#/");

            driver.FindElement(By.Id("new-todo")).SendKeys("Create Automation Project");

         
            Console.WriteLine("Iam on ToDOMvc Website");
        }
                    
        [When(@"I have entered a task")]
        public void WhenIPressLogin()
        {
            Console.WriteLine("Entered a task");
        }
        
        [Then(@"the entered task should be added to the Todo list")]
        public void ThenIShouldBeAbleToLoginToTheWebsite()
        {
            Console.WriteLine("Task has been added to the ToDo list");
        }
    }
}
