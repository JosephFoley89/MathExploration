using MathExploration.Converters.Mass;
using MathExploration.Data.Enums;
using MathExploration.Data.Models;

namespace MathExploration.Data.Menus {
    internal class MassConversionMenu : MenuModel {
        private static List<string> menuText = new List<string>() {
            "Please choose the unit you're converting from followed by the unit you're converting to separated by a space.",
            "i.e. 5 11 which corresponds with grams and pounds\n"
        };

        public MassConversionMenu() : base(menuText, "Mass Conversion") {

        }

        public void ConvertMass() {
            MassUnitConverter converter = new MassUnitConverter();
            Menu.ListEnums<MassUnit>();

            int[] choices = Menu.ParseChoices<MassUnit>(Menu.ReadInput());
            var ogUnit = ((MassUnit)choices[0]).ToString().ToLower();
            var newUnit = ((MassUnit)choices[1]).ToString().ToLower();

            Console.WriteLine($"Please enter the amount of {ogUnit}s");

            if (Decimal.TryParse(Menu.ReadInput(), out decimal n)) {
                decimal result = converter.Convert((MassUnit)choices[0], (MassUnit)choices[1], n);
                Console.WriteLine($"{n} {ogUnit}s is {result} {newUnit}s");
            } else {
                Error.InvalidNumericalInput();
                ConvertMass();
            }

            if (Menu.ReturnPrompt()) {
                MainMenu = new MainMenu();
            } else {
                ConvertMass();
            }
        }
    }
}