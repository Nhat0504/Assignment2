﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Bai5
    {
        public Class XPT;
        [SetUp]
        public void SetUp()
        {
            XPT = new Class();
        }
        [Test]
        [TestCase(new object[] { "Nguyen", "Danh", "Lam" }, 0, "Nguyen")]
        [TestCase(new object[] { 1, 2, 3, 4, 5, 6 }, 3, 4)]
        [TestCase(new object[] { 1.1, 2.2, 3.3, 4.4, 5.5 }, 0, 1.1)] 
        [TestCase(new object[] { }, 0, 0)] 
        [TestCase(new object[] { 5, 5, 5, 5, 5, 5 }, 5, 5)]
        [TestCase(new object[] { "Hehe", "Haha", 10, 5, 5.6 }, 1, "Haha")] 
        [TestCase(new object[] { 9, 9, 1, 0, 3 }, 6, 3)] 
        [TestCase(new object[] { 0 }, 0, 0)]
        [TestCase(new object[] { int.MaxValue, int.MinValue, 1, 0 }, 0, int.MaxValue)] 
        [TestCase(new object[] { 0, 1, new object[] { 1, 2, 3 } }, 3, new object[] { 1, 2, 3 })] 
        public void XuatPhanTu1Mang(object[] a, int b, object c)
        {
            var kq = XPT.XuatPhanTu(a, b);
            Assert.That(kq, Is.EqualTo(c));
        }
        public class Class
        {
            public object XuatPhanTu(object[] a, int b)
            {
                if (b < 0 || b > a.Length)
                {
                    throw new Exception($"Phần tử thứ '{b}' nằm ngoài phạm vi của mảng");
                }
                if (a == null || a.Length == 0)
                {
                    throw new Exception("Mảng rỗng");
                }
                return a[b];
            }

        }
    }
}
