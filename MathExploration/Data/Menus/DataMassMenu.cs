using MathExploration.Calculations;
using MathExploration.Data.Models;

namespace MathExploration.Data.Menus {
    internal class DataMassMenu : MenuModel {
        private static List<string> menuText = new List<string>() {
            "Please input the number of bits you would like to calculate the mass for."
        };

        public DataMassMenu() : base(menuText, "Data Mass Conversion") {
            Menu.SetStage(menuText);
        }

        public void CalculateMassOfStoredData() {
            DataMassCalculator calculator = new DataMassCalculator();
            string input = Menu.ReadInput();

            if (Decimal.TryParse(input, out decimal bits)) {
                calculator.Calculate(bits);
            } else {
                Error.InvalidNumericalInput();
                CalculateMassOfStoredData();
            }

            if (Menu.ReturnPrompt()) {
                MainMenu = new MainMenu();
            } else {
                CalculateMassOfStoredData();
            }
        }
    }
}
