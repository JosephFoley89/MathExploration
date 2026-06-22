using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExploration.ProjectEulerSolutions {
    internal class Problem4 {
        public Problem4() {
            Solve();
        }
        public void Solve() {
            List<int> palindromeProducts = new List<int>();

            for (int i = 100; i < 1000; i++) {
                for (int j = 100; j < 1000; j++) {
                    int product = i * j;
                    string productString = product.ToString();
                    if (productString.SequenceEqual(productString.Reverse())) {
                        palindromeProducts.Add(product);
                    }
                }
            }

            Console.WriteLine("The largest palindrome product of two three-digit numbers is {0}", palindromeProducts.Max());
        }
    }
}
