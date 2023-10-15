using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint2.Task6.V6.Lib;

namespace Tyuiu.MenshikovEA.Sprint2.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int a = 1;
            int b = 13;
            Assert.AreEqual("Король пик", ds.FindCardNameAndValue(b, a));
        }
    }
}
