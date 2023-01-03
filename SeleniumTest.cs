using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.ObjectModel;
using System.IO;
namespace GoogleSearch
{
    public class Tests
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            //getting the drivers folder dynamically
            string path = "Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName";

            driver = new ChromeDriver(path + @"\drivers\");

            // driver = new FirefoxDriver(path + @"\drivers\");
        }
        [Test]
        public void searchGoogle()
        {
            driver.Navigate().GoToUrl("http://www.google.com");

            var searchText = driver.FindElement(By.ClassName("gLFyf"));
            searchText.SendKeys("Climate");
            searchText.SendKeys(Keys.Enter);
            
            //finding the element containing the search results
            IWebElement resultsPanel = driver.FindElement(By.Id("search"));

            //getting a list of the search results
            ReadOnlyCollection<IWebElement> searchResults = resultsPanel.FindElements(By.XPath(".//a"));

            // iterating through the list of search results and printing each one to the console
            foreach (IWebElement result in searchResults)
            {
                Console.WriteLine(result.Text);
            }
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}