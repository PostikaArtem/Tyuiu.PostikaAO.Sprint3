using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PostikaAO.Sprint3.Task4.V16.Lib;

namespace Tyuiu.PostikaAO.Sprint3.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            DataService ds = new DataService();
            int start = -1;
            int stop = 1;
            double res = Math.Round(ds.Calculate(start, stop), 3);
            double wait = 0.71;

            Assert.AreEqual(wait, res);


        }
    }
}
