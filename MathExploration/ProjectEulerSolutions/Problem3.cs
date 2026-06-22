using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MathExploration.ProjectEulerSolutions {
    internal class Problem3 {
        public Problem3(long limit) {
            Solve(limit);
        }
        public void Solve(long target) {
            List<long> primeFactors = new List<long>();
            int x = 1;

            for (long i = 2; i < Math.Sqrt(target) + 1; i++) {
                if (target % i == 0) {
                    for (long j = 2; j < Math.Sqrt(i) + 1; j++) {
                        if (x % j == 0) {
                            x = 0;
                            break;
                        }

                        x = 1;
                    }

                    if (x == 1) {
                        primeFactors.Add(i);
                    }
                }
            }

            if (primeFactors.Any()) {
                Console.WriteLine("The largest prime factor of {0} is {1}", target, primeFactors.Last());
            }
        }
    }
}