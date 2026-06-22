using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExploration.ProjectEulerSolutions {
    internal class Problem5 {
        public Problem5(int stepSize) {
            Solve(stepSize);
        }

        public void Solve(int step) {
            bool result = false;

            for (int i = step; i < 1000000000000; i += step) {
                for (int j = 1; j < step; j++) {
                    if (i % j != 0) { 
                        result = false;
                        break;
                    } else {
                        result = true;
                    }
                }

                if (result) {
                    Console.WriteLine($"The smallest evenly divisible number is {i}");
                    break;
                }
            }
        }
    }
}