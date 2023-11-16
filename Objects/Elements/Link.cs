using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_QA.Config_File;

namespace Tools_QA.Objects.Elements
{
    public  class Link : Main_File
    {
        public Link(IWebDriver _driver)
        {
            driver = _driver;
            PageFactory.InitElements(driver, this);
        }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'text')] [contains(text(),'Links')]")] private IWebElement Link_Element;

        [CacheLookup]
        [FindsBy(How = How.LinkText, Using = "Home")] private IWebElement HomePage;

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//a[@id='dynamicLink']")] private IWebElement FirstPage;

        [CacheLookup]
        [FindsBy(How = How.LinkText, Using = "Created")] private IWebElement Created;

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//p[@id='linkResponse']")] IWebElement Created_Text;

        public void Links()
        {
            Button btn = new Button(driver);
            btn.Scroll();

            Link_Element.Click();

            HomePage.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
            
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(2000);

            FirstPage.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
            
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(2000);

            Created.Click();
            Thread.Sleep(2000);

            Console.WriteLine(Created_Text.Text);
        }
    }
}
