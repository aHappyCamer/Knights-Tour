using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_KnightsTour
{
    public partial class Calculation
    {
        public List<int> StoreAveragesPerRun(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                listOfRuns.Add(list[i]);
            }
            return listOfRuns;
        }
        public double CalculateAverage(List<int> list)
        {
            return Avg = Math.Round((double)list.Average(), 2);
        }

        public double CalculateVariance()
        {
            double sumOfSquares = listOfRuns.Sum(r => Math.Pow(r - Avg, 2));
            return Variance = sumOfSquares / (listOfRuns.Count() - 1);
        }

        public double CalculateStdDev()
        {
            return StdDev = Math.Round(Math.Sqrt(CalculateVariance()), 2);
        }

    }
}
