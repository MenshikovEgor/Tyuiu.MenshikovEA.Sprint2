using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint2.Task0.V28.Lib;

namespace Tyuiu.MenshikovEA.Sprint2.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            int x = 111;
            int y = 735;

            bool[] wait = new bool[6] { false, false, false, false, false, false};

            DataService ds = new DataService();

            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            CollectionAssert.AreEqual(res, wait);
        }
    }
}
