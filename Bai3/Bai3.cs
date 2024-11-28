using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Bai3
    {
        public int Hieu(int a, int b)
        {
            return a - b;
        }

        [Test]
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 0)]
        [TestCase(5, 2, 3)]
        [TestCase(10, 2, 8)]
        [TestCase(100, 10, 90)]
        [TestCase(-1, 1, 2)]
        [TestCase(-5, -5, 0)]
        [TestCase(10, 3, 7)]
        [TestCase(11, 9, 2)]
        [TestCase(int.MaxValue, -1, int.MaxValue - 1)]
        [TestCase(int.MinValue, 1, int.MinValue + 1)]
        public void TinhTong(int a, int b, int c)
        {
            var result = Hieu(a, b);
            Assert.That(result, Is.EqualTo(c));
        }
    }
}
