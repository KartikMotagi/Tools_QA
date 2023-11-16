using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools_QA.Config_File;
using Tools_QA.Objects.Elements;

namespace Tools_QA.TestSuites
{
    [TestFixture]
    [Parallelizable]
    public class Frame_TestData : Setup_File
    {
        [Test, Category("Elements"), Order(6)]
        public void F1()
        {
            Frames f = new Frames(_driver);
            f.Handle_Frame();
        }
    }
}
