using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_QA.Config_File;

namespace Tools_QA.Class_Files.Elements
{
    public class Radiobutton : Main_File
    {
        public Radiobutton(IWebDriver _driver) 
        {
            driver= _driver;
            PageFactory.InitElements(driver, this);
        }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//span[@class='text' and contains(text(),'Radio Button')]")] private IWebElement Radio_Element;

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//label[@for='yesRadio']")] private IWebElement Yes;

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//label[@for='impressiveRadio']")] private IWebElement Impressive;

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//label[@for='noRadio']")] private IWebElement No;
        public void Waiting()
        {
            Thread.Sleep(3000);
        }
        public void Radio()
        {
            Radio_Element.Click();
            Waiting();

            Yes.Click();
            Waiting();

            Impressive.Click();
            Waiting();

            No.Click();
            Waiting();
        }
    }
}
