using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Events;
using System.Collections.ObjectModel;

namespace Tools_QA.WithoutPOM
{
    [TestFixture]
    public class Dropdown
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/text-box";
        }

        [Test]
        public void Test1()
        {
            driver.FindElement(By.XPath("//span[@class='text' and contains(text(),'Web Tables')]")).Click();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//select[@aria-label='rows per page']")).Click();

            ReadOnlyCollection<IWebElement> web = driver.FindElements(By.XPath("//option[contains(text(),'rows')]"));
            Console.WriteLine("Number of rows: "+web.Count());

           foreach(IWebElement i in web) 
           {
                Console.WriteLine(i.Text);
           }
            

            //IWebElement ele1 = driver.FindElement(By.XPath("//select[@aria-label='rows per page']//child::option[3]"));
            //ele1.Click();
            //Thread.Sleep(10000);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
