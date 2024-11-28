using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Bai2
    {
        public Class tich;
        [SetUp]
        public void SetUp()
        {
            tich = new Class();
        }
        [Test]
        [TestCase(10, 10, 100)]
        [TestCase(5.5f, 5, 27.5f)]
        [TestCase(4, 3.5f, 14)]
        [TestCase(2.2, 1.2, 2.42)] 
        [TestCase(float.MaxValue, 1, float.MaxValue)] 
        [TestCase(int.MinValue, 1, int.MinValue)] 
        [TestCase(double.MaxValue, 1, double.MinValue)] 
        [TestCase(0, 0, 0)]
       
        public void TinhTich(object a, object b, object c)
        {
            var kq = tich.Tich(a, b);
            Assert.That(kq, Is.EqualTo(c));
        }
        public class Class
        {
            public object Tich(object a, object b) 
            {
                if (a == null || b == null || string.IsNullOrEmpty(a.ToString()) || string.IsNullOrEmpty(b.ToString()))
                {
                    throw new Exception("Không được để trống A hoặc B");
                }
                if (int.TryParse(a.ToString(), out int soA) && int.TryParse(b.ToString(), out int soB))
                {
                    return soA * soB;
                }
                throw new Exception("A hoặc B không phải là số nguyên");
            }
        }
    }
}

