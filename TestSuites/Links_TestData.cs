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
    public  class Links_TestData : Setup_File
    {
        [Test, Category("Elements"), Order(5)]
        public void LinkData()
        {
            Link link = new Link(_driver);
            link.Links();
        }
    }
}
