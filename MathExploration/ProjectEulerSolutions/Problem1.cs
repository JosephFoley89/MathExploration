using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExploration.ProjectEulerSolutions {
    internal class Problem1 {
        public Problem1(decimal limit) {
            Solve(limit);
        }

        public void Solve(decimal limit) {
            decimal sum = 0;

            for (decimal i = 1; i < limit; i++) {
                if (i % 3 == 0 || i % 5 == 0) {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
