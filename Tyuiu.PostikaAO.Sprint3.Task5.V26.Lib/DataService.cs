using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PostikaAO.Sprint3.Task5.V26.Lib
{
    public class DataService : ISprint3Task5V26
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double s0 = 0;
            double s1 = 0;

            for (int j = startValue1; j <= stopValue1; j++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    s0 = Math.Pow(x, k) + Math.Sin(k);
                    s1 += s0;
                }
            }

            return s1;
        }
    }
}
