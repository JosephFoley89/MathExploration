using MathExploration.Data.Models;

namespace MathExploration.Data.Menus {
    internal class MainMenu : MenuModel {
        private static CalculationMenu calculationMenu;
        private static ConversionMenu conversionMenu;
        private static ProjectEulerMenu projectEulerMenu;

        private string selection = string.Empty;
        private static List<string> menuText = new List<string>() {
            "1. Calculations",
            "2. Conversions",
            "3. Project Euler",
            "0. Exit application"
        };

        public MainMenu() : base(menuText, "Main Menu") {
            ReadSelection();
        }

        public void ReadSelection() {
            selection = Menu.ReadInput(true);

            switch (selection) {
                case "1":
                    calculationMenu = new CalculationMenu();
                    break;
                case "2":
                    conversionMenu = new ConversionMenu();
                    break;
                case "3":
                    projectEulerMenu = new ProjectEulerMenu();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
