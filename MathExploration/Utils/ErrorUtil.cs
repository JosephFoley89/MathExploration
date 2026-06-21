using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExploration.Utils {
    internal class ErrorUtil {
        public void InvalidNumericalInput() {
            Console.WriteLine("Please input a valid numerical string. Please press any key to continue.");
            Console.ReadLine();
        }
    }
}
