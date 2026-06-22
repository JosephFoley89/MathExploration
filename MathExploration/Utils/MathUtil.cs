using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExploration.Utils {
    internal class MathUtil {
        private List<decimal> fibonacci = new List<decimal> {
            1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89
        };

        public MathUtil() {
            GenerateFibonacciSequence(100000);
        }

        private void GenerateFibonacciSequence(decimal limit) {
            decimal nextInSequence = fibonacci[fibonacci.Count - 1] + fibonacci[fibonacci.Count - 2];

            if (nextInSequence < limit) {
                fibonacci.Add(nextInSequence);
                GenerateFibonacciSequence(limit);
            }
        }

        public List<decimal> GetFibonacciSequence() {
            return fibonacci;
        }
    }
}