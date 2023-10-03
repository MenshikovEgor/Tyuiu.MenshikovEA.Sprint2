using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint2.Task1.V21.Lib;

//a = 696, b = 987, c = 696, d = 155

namespace Tyuiu.MenshikovEA.Sprint2.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();

            int a = 696;
            int b = 987;
            int c = 696;
            int d = 155;

            bool[] wait = new bool[6] { false, false, false, false, true, false };
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            CollectionAssert.AreEqual(res, wait);
        }
    }
}
