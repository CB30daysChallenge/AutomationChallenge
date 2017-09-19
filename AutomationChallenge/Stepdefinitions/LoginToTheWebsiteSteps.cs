using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace AutomationChallenge
{
    [Binding]
    public class LoginToTheWebsiteSteps
    {
        IWebDriver driver = Hooks.driver;
        [Given(@"I am on ToDoMvc website")]
        public void GivenIAmOnToDoMvcWebsite()
        {
            Console.WriteLine("I am Todo MVC site");
        }

        [When(@"I have entered an (.*) to the list")]
        public void WhenIHaveEnteredAnToTheList(string name, Table table)
        {

            //var values = table.CreateInstance<ToDoItems>();
                       
            foreach (var row in table.Rows)
            {
                IWebElement element = driver.FindElement(By.Id("new-todo"));
                element.SendKeys(row[0]);
                Thread.Sleep(1000/2);
                element.SendKeys(Keys.Enter);
                Thread.Sleep(1000/2);
            }
         }

        [Then(@"I should see the radio button infront of the added items")]
        public void ThenIShouldBeAbleToLoginToTheWebsite()
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='todo-list']/li[1]/div/input"));
            element.Click();
            //*[@id="todo-list"]/li[1]/div/input

        }
        [Then(@"the count before Items left should match with active items")]
        public void ThenTheCountBeforeItemsLeftShouldMatchWithActiveItems()
        {
            //*[@id="filters"]/li[2]/a

            IWebElement element = driver.FindElement(By.XPath("//*[@id='filters']/li[2]/a"));
            element.Click();

        }
        [Then(@"the items left, All, Ative, Completed labels are displayed")]
        public void ThenISeeTheItemsLeftAllAtiveCompletedLabel()
        {
            //IWebElement element = driver.FindElement(By.LinkText("Completed"));
            //Console.WriteLine(element.Text);

            IWebElement element = driver.FindElement(By.XPath("//*[@id='filters']/li[3]/a"));
            element.Click();

            // int count =driver.FindElements(By.XPath("")).Count;
        }   

        [Then(@"the All label is selected")]
        public void ThenTheAllLabelIsSelected()
        {
            //*[@id="filters"]/li[1]/a
           IWebElement element = driver.FindElement(By.XPath("//*[@id='filters']/li[1]/a"));
           element.Click();
        }


    }
}
