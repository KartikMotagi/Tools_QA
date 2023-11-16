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
    public class Textbox_TestData : Setup_File
    {
        [Test, Category("Elements"), Order(1)]
        public void Textbox_Details()
        {
            Textbox text = new Textbox(_driver);
            text.Scroll();
            text.Text("Roy John", "Roy@gmail.com", "New Jersey" , "UK");
        }
    }
}
