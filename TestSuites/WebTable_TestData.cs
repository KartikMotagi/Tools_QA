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
    public class WebTable_TestData : Setup_File
    {
        [Test, Category("Elements"), Order(4)]
        public void Web_Tables()
        {
            WebTable table = new WebTable(_driver);
            table.W_Table();
            table.Action_Handle("John", "Roy", "John@gmail.com", "24", "200000", "Tester");
            table.Scroll();
            table.Select_Dropdown();
        }
    }
}
