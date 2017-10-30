using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
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
        [When(@"I click on radio button against the below items")]
        public void WhenIClickOnRadioButtonAgainstTheBelowItems(Table table)
        {
            //reach (var row in table.Rows)
            //
                //*[@id="todo-list"]/li[1]/div/input
                //*[@id="todo-list"]/li[1]/div/label
                
                IWebElement element = driver.FindElement(By.XPath("//*[@id='todo-list']/li[1]/div/input"));
                element.Click();

            //}
        }

       [Then(@"I should see these items are appeared under completed")]
        public void ThenIShouldSeeTheseItemsAreAppearedUnderCompleted()
        {
            
        }
        
        [Then(@"the count before Items left should match with active items")]
        public void ThenTheCountBeforeItemsLeftShouldMatchWithActiveItems()
        {
   
            IWebElement element = driver.FindElement(By.XPath("//*[@id='filters']/li[2]/a"));
            element.Click();
            Thread.Sleep(1000 / 2);

        }
        [Then(@"the items left, All, Ative, Completed labels are displayed")]
        public void ThenISeeTheItemsLeftAllAtiveCompletedLabel()
        {
            //IWebElement element = driver.FindElement(By.LinkText("Completed"));
            //Console.WriteLine(element.Text);

            IWebElement element = driver.FindElement(By.XPath("//*[@id='filters']/li[3]/a"));
            element.Click();
            Thread.Sleep(1000 / 2);

            By completedItems = By.XPath("//input[contains(@ng-model,'todo.completed')]");

           IReadOnlyList<IWebElement> l = driver.FindElements(completedItems);
            Console.WriteLine("There are " + l.Count + "Completed Items in the list");
            // int count =driver.FindElements(By.XPath("")).Count;
        }

        [Then(@"the All label is selected by default")]
        public void ThenTheAllLabelIsSelected()
        {
     
           IWebElement element = driver.FindElement(By.XPath("//*[@id='filters']/li[1]/a"));
           element.Click();
           Thread.Sleep(1000 / 2);
        }


    }
}
