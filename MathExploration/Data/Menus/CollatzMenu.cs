using MathExploration.Calculations;
using MathExploration.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExploration.Data.Menus {
    internal class CollatzMenu : MenuModel {
        string selection = string.Empty;
        private static List<string> menuText = new List<string> {

        };

        public CollatzMenu() : base(menuText, "Collatz Conjecture") {
        
        }

        public void CalculateCollatz() {
            Console.WriteLine("Enter a number to calculate the Collatz Conjecture:");
            selection = Menu.ReadInput();
            Collatz collatz = new Collatz(Menu.ConvertToDecimal(selection));
            collatz.Solve();
        }
    }
}
