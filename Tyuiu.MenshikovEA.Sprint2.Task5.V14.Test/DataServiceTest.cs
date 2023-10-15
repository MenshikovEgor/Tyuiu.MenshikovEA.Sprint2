using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint2.Task5.V14.Lib;

namespace Tyuiu.MenshikovEA.Sprint2.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int dn = 1;
            int kol = 7;

            Assert.AreEqual(ds.FindDayName(dn, kol), "Воскресенье");
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();

            int dn = 2;
            int kol = 13;

            Assert.AreEqual(ds.FindDayName(dn, kol), "Воскресенье");
        }

        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();

            int dn = 4;
            int kol = 7;

            Assert.AreEqual(ds.FindDayName(dn, kol), "Среда");
        }
    }
}
