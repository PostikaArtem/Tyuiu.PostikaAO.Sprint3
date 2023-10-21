using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PostikaAO.Sprint3.Task2.V22.Lib
{
    public class DataService : ISprint3Task2V22
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multySeries = 1;
            do
            {
                multySeries = multySeries * Math.Pow(3 / (startValue + Math.Pow(value, -1 * startValue)), 2);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(multySeries, 3);

        }
    }
}
