using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V113.DOM;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_QA.Config_File;

namespace Tools_QA.Class_Files.Elements
{
    public class Textbox : Main_File
    {
        public Textbox(IWebDriver _driver)
        {
            driver = _driver;
            PageFactory.InitElements(driver, this);
        }

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "userName")] private IWebElement Full_Name;

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "userEmail")] private IWebElement Email;

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "currentAddress")] private IWebElement Current_Address;

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "permanentAddress")] private IWebElement Permanent_Address;

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//button[@id='submit']")] private IWebElement Submit_Button;
        

        public void Scroll()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,250)");
            Thread.Sleep(3000);
        }
        public void Text(String FName, String E_Mail, String C_Address, String P_Address)
        {
                Full_Name.SendKeys(FName);
                Email.SendKeys(E_Mail);
                Current_Address.SendKeys(C_Address);
                Permanent_Address.SendKeys(P_Address);
                Submit_Button.Click();
                Scroll();
                Thread.Sleep(3000);
        }
    }
}
