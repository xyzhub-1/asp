using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    [TestFixture]
    class MyTestCase
    {
        [TestCase]
        public void Add()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(4, math.Add(2, 2));
        }
        [TestCase]
        public void Sub()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(4, math.Sub(8, 4));
        }

    }
}
