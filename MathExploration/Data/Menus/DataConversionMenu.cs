using MathExploration.Converters;
using MathExploration.Data.Enums;
using MathExploration.Data.Models;

namespace MathExploration.Data.Menus {
    internal class DataConversionMenu : MenuModel {
        private static List<string> menuText = new List<string> {
            "Please choose the unit you're converting from followed by the unit you're converting to separated by a space.",
            "i.e. 1 8 which corresponds with bits and exabytes\n"
        };

        public DataConversionMenu() : base(menuText, "Data Conversion") {

        }

        public void ConvertData() {
            Menu.ListEnums<Enums.DataUnit>();

            int[] choices = Menu.ParseChoices<DataUnit>(Menu.ReadInput());
            var ogUnit = ((DataUnit)choices[0]).ToString().ToLower();
            var newUnit = ((DataUnit)choices[1]).ToString().ToLower();

            DataUnitConverter converter = new DataUnitConverter();
            Console.WriteLine($"Please enter the amount of {ogUnit}s");

            if (Decimal.TryParse(Menu.ReadInput(), out decimal n)) {
                decimal result = converter.Convert((DataUnit)choices[0], (DataUnit)choices[1], n);
                Console.WriteLine($"{n} {ogUnit}s is {result} {newUnit}s");
            } else {
                Error.InvalidNumericalInput();
                ConvertData();
            }

            if (Menu.ReturnPrompt()) {
                MainMenu = new MainMenu();
            } else {
                ConvertData();
            }
        }
    }
}
