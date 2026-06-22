using MathExploration.Data.Models;
using MathExploration.ProjectEulerSolutions;

namespace MathExploration.Data.Menus {
    internal class ProjectEulerMenu : MenuModel {
        private MainMenu mainMenu;
        private string selection = string.Empty;

        private static List<string> menuText = new List<string>() {
            "1. Multiples of 3 and 5",
            "2. Even Fibonacci numbers",
            "3. Largest prime factor",
            "4. Largest palindrome product",
            "5. Smallest multiple",
            "6. Sum square difference",
            "9. Main Menu",
            "0. Exit Application"
        };

        public ProjectEulerMenu() : base(menuText, "Project Euler") {
            ReadInput();
        }

        private void ReadInput() {
            selection = Menu.ReadInput(true);
            Console.WriteLine();

            switch(selection) {
                case "1":
                    Console.WriteLine("Please input a number for the limit");
                    Decimal.TryParse(Menu.ReadInput(), out decimal limit);
                    Problem1 problem1 = new Problem1(limit);
                    break;
                case "2":
                    Problem2 problem2 = new Problem2(4000000, 144);
                    break;
                case "3":
                    Problem3 problem3 = new Problem3(600851475143);
                    break;
                case "4":
                    Problem4 problem4 = new Problem4();
                    break;
                case "5":
                    Problem5 problem5 = new Problem5(20);
                    break;
                case "6":
                    Problem6 problem6 = new Problem6(100);
                    break;
                case "9":
                    mainMenu = new MainMenu();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
            }

            Menu.WaitForInput();
            Menu.SetStage(menuText);
            ReadInput();
        }
    }
}
