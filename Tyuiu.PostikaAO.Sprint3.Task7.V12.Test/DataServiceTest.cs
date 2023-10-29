using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PostikaAO.Sprint3.Task7.V12.Lib;

namespace Tyuiu.PostikaAO.Sprint3.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -1;
            int stopValue = 1;

            int len = stopValue - startValue + 1;

            double[] valieWaitArray;
            valieWaitArray = new double[len];

            valieWaitArray[0] = 0.52;
            valieWaitArray[1] = 4;
            valieWaitArray[2] = -0.75;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valieWaitArray, res);



        }
    }
}
