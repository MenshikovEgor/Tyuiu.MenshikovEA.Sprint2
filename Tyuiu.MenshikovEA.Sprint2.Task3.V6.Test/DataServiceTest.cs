using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint2.Task3.V6.Lib;

namespace Tyuiu.MenshikovEA.Sprint2.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = -12;

            double y = ds.Calculate(x);

            Assert.AreEqual(-131.917, y);
        }
    }
}
