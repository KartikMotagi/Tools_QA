using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tools_QA.Config_File;

namespace Tools_QA.Class_Files.Elements
{
    public class WebTable : Main_File
    {
        public WebTable(IWebDriver _driver) 
        {
            driver = _driver;
            PageFactory.InitElements(driver, this);
        }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = ("//span[@class='text' and contains(text(),'Web Tables')]"))] private IWebElement Web_Tables;

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = ("//button[@id='addNewRecordButton']"))] private IWebElement Add_Button;

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = ("//input[@id='firstName']"))] private IWebElement FirstName;

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "lastName")] private IWebElement LastName;

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "userEmail")] private IWebElement Email;

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "age")] private IWebElement Age;

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "salary")] private IWebElement Salary;

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "department")] private IWebElement Department;

        [CacheLookup]
        [FindsBy(How = How.Id, Using = "submit")] private IWebElement Submit;

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//select[@aria-label='rows per page']//child::option[1]")] private IWebElement Dropdown;

        public void W_Table()
        {
            Web_Tables.Click();
            Add_Button.Click();
        }

        public void Action_Handle(String F_Name, String L_Name, String E_mail, String Age_Emp, String Salary_Emp, String Depart)
        {
            Actions actions = new Actions(driver);
            actions.KeyDown(Keys.Tab);
            actions.KeyDown(Keys.Tab);

            actions.KeyUp(Keys.Tab);
            actions.KeyUp(Keys.Tab);

            actions.SendKeys(FirstName, F_Name);

            actions.KeyDown(Keys.Tab);
            actions.KeyUp(Keys.Tab);

            actions.SendKeys(LastName, L_Name);

            actions.KeyDown(Keys.Tab);
            actions.KeyUp(Keys.Tab);

            actions.SendKeys(Email, E_mail);

            actions.KeyDown(Keys.Tab);
            actions.KeyUp(Keys.Tab);

            actions.SendKeys(Age, Age_Emp);

            actions.KeyDown(Keys.Tab);
            actions.KeyUp(Keys.Tab);

            actions.SendKeys(Salary, Salary_Emp);

            actions.KeyDown(Keys.Tab);
            actions.KeyUp(Keys.Tab);

            actions.SendKeys(Department, Depart);

            actions.KeyDown(Keys.Tab);
            actions.KeyUp(Keys.Tab);

            actions.MoveToElement(Submit).Click();
            actions.Build().Perform();


        }

        public void Scroll()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,250)");
            Thread.Sleep(2000);
        }

        public void Select_Dropdown()
        {
            Dropdown.Click();
            Thread.Sleep(2000);
        }
    }
}
