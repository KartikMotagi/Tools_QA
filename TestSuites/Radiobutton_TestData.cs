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
    public class Radiobutton_TestData : Setup_File
    {
        [Test, Category("Elements"), Order(3)]

        public void RadioButton()
        {
            Radiobutton radio = new Radiobutton(_driver);
            radio.Waiting();
            radio.Radio();
        }
    }
}
