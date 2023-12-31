﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PostikaAO.Sprint3.Task5.V26.Lib;

namespace Tyuiu.PostikaAO.Sprint3.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = -2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 2;
            int stopValue2 = 2;

            double res = Math.Round(ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2), 3);
            double wait = 7.502;

            Assert.AreEqual(wait, res);


        }
    }
}
