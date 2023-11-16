using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_QA.Config_File;

namespace Tools_QA.Objects.Elements
{
    public class Button : Main_File
    {
        public Button(IWebDriver _driver)
        {
            driver = _driver;
            PageFactory.InitElements(driver, this);
        }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//span[@class='text'  and contains(text(),'Buttons')]")] private IWebElement Buttons;

        [CacheLookup]
        [FindsBy(How = How.Id, Using = ("doubleClickBtn"))] private IWebElement Dobule_Click;

        [CacheLookup]
        [FindsBy(How = How.Id, Using = ("rightClickBtn"))] private IWebElement Right_Click;

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = ("//button[text()='Click Me']"))] private IWebElement Click_Me;


        public void Double_Btn()
        {
            Buttons.Click();
            Thread.Sleep(2000);

            Actions action = new Actions(driver);
            action.DoubleClick(Dobule_Click);
            action.Build().Perform();
            Thread.Sleep(2000);

            action.ContextClick(Right_Click);
            action.Build().Perform();

            Scroll();

            Click_Me.Click();
            Thread.Sleep(2000);

        }

        public void Scroll()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,250)");
            Thread.Sleep(2000);
        }

    }

    
}
