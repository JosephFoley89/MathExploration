using MathExploration.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExploration.ProjectEulerSolutions {
    internal class Problem2 {
        private MathUtil util;

        private List<decimal> evenFibonacci = new List<decimal>() {
            2, 8, 34,
        };

        public Problem2(decimal limit, decimal nextInSequence) {
            util = new MathUtil();
            Solve(limit, nextInSequence);
        }

        public void Solve(decimal limit, decimal nextInSequence) {
            List<decimal> fibonacci = util.GetFibonacciSequence();

            if (nextInSequence < limit) {
                fibonacci.Add(nextInSequence);
                
                if (nextInSequence % 2 == 0) {
                    evenFibonacci.Add(nextInSequence);
                }

                nextInSequence = fibonacci[fibonacci.Count - 1] + fibonacci[fibonacci.Count - 2];
                Solve(limit, nextInSequence);
            } else {
                Console.WriteLine(evenFibonacci.Sum());
            }
        }
    }
}