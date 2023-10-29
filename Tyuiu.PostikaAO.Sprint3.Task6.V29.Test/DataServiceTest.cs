using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PostikaAO.Sprint3.Task6.V29.Lib;

namespace Tyuiu.PostikaAO.Sprint3.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 10;
            int stopValue = 15;

            double res = ds.GetSumTheDivisors(startValue, stopValue);
            double wait = 120;

            Assert.AreEqual(wait, res);


        }
    }
}
