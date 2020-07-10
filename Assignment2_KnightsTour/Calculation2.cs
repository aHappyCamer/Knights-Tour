using System.Collections.Generic;

namespace Assignment2_KnightsTour
{
    public partial class Calculation
    {

        // list of averages from each run
        private List<int> listOfRuns = new List<int>();

        // properties
        public double Avg { get; private set; }
        public double Variance { get; private set; }
        public double StdDev { get; private set; }
    }
}
