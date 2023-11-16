using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_QA.Class_Files.Elements;
using Tools_QA.Config_File;

namespace Tools_QA.Test_Data_Files
{
    [TestFixture]
    [Parallelizable]
    public class Checkbox_TestData : Setup_File
    {
        [Test, Category("Elements"), Order(2)]

        public void Checkbox_Details() 
        {
            Checkbox check = new Checkbox(_driver);
            check.Waiting();
            check.Check();
        }
    }
}
