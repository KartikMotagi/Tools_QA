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
    public class Frames : Main_File
    {
        public Frames(IWebDriver _driver )
        {
            driver = _driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[local-name()='svg' and @viewBox= '0 0 448 512']")] private IWebElement Element;

        [FindsBy(How = How.XPath, Using = "//*[local-name()='svg' and @viewBox= '0 0 14 16']")] private IWebElement Menu;

        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'text')] [contains(text(),'Frames')][1]")] private IWebElement Frames_Menu;

        [FindsBy(How = How.XPath, Using = "//div[@id='framesWrapper']//child::div")] private IWebElement Texts1;

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'This is a sample page')]")] private IWebElement Texts;

        [FindsBy(How = How.XPath, Using = "//iframe[@id='frame1']")] private IWebElement Frame1;

        public void Handle_Frame()
        {
                Element.Click();
                Thread.Sleep(2000);

                Menu.Click();
                Scroll();

                Frames_Menu.Click();
                Thread.Sleep(2000);

                driver.SwitchTo().Frame(Frame1);

                Console.WriteLine(Texts.Text);

                driver.SwitchTo().DefaultContent();

                Console.WriteLine(Texts1.Text);

                Scroll();
            
        }

        public void Scroll()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,250)");
            Thread.Sleep(2000);
        }
    }
}
