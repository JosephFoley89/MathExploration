using MathExploration.Converters.Mass;
using MathExploration.Data.Enums;
using MathExploration.Data.Models;
using System.Security.Principal;

namespace MathExploration.Data.Menus {
    internal class MainMenu : MenuModel {
        private static DataMassMenu dataMassMenu;
        private static MassConversionMenu massConversionMenu;

        private string selection = string.Empty;
        private static List<string> menuText = new List<string>() {
            "1. Calculate the mass of stored data",
            "2. Convert mass",
            "0. Exit application"
        };

        public MainMenu() : base(menuText, "Main Menu") {
            ReadSelection();
        }

        public void ReadSelection() {
            selection = Menu.ReadInput();

            switch (selection) {
                case "1":
                    dataMassMenu = new DataMassMenu();
                    dataMassMenu.CalculateMassOfStoredData();
                    break;
                case "2":
                    massConversionMenu = new MassConversionMenu();
                    ConvertMass();
                    break;
                case "3":

                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Menu.SetStage(menuText);
                    break;
            }
        }

        private void ConvertMass() {
            MassUnitConverter converter = new MassUnitConverter();
            Console.WriteLine("Please select the current unit of weight you're using.");

            int i = 0;

            foreach (var value in Enum.GetValues(typeof(MassEnum))) {
                i++;
                Console.WriteLine($"{i}. {value}");
            }

            if (Menu.ReturnPrompt()) {
                Menu.SetStage(menuText);
                ReadSelection();
            } else {
                ConvertMass();
            }
        }
    }
}
