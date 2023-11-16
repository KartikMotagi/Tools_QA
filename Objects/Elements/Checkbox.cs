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
    public class Checkbox : Main_File
    {
        public Checkbox(IWebDriver _driver) 
        {
            driver = _driver;
            PageFactory.InitElements(driver, this);
        }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'text')] [contains(text(),'Check Box')]")] private IWebElement Check_Box_Element;

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//*[local-name()='svg' and @class= 'rct-icon rct-icon-uncheck']")] private IWebElement Checked_Home;

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//button[@title='Toggle']")] private IWebElement Home_Expandable;

        public void Waiting()
        {
            Thread.Sleep(3000);
        }

        public void Check() 
        {
            Check_Box_Element.Click();
            Waiting();

            Checked_Home.Click();
            Waiting();

            Home_Expandable.Click();
            Waiting();       
        }
    }
}
