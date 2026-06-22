using MathExploration.Data.Models;

namespace MathExploration.Data.Menus {
    internal class ConversionMenu : MenuModel {
        private static MassConversionMenu massConversionMenu;
        private static DataConversionMenu dataConversionMenu;
        private static MainMenu mainMenu;
        private string selection = string.Empty;

        private static List<string> menuText = new List<string> {
            "1. Mass Conversion",
            "2. Data Conversion",
            "9. Main Menu",
            "0. Exit Application"
        };

        public ConversionMenu() : base(menuText, "Conversions") {
            ReadSelection();
        }

        public void ReadSelection() {
            selection = Menu.ReadInput(true);

            switch (selection) {
                case "1":
                    massConversionMenu = new MassConversionMenu();
                    massConversionMenu.ConvertMass();
                    break;
                case "2":
                    dataConversionMenu = new DataConversionMenu();
                    dataConversionMenu.ConvertData();
                    break;
                case "9":
                    mainMenu = new MainMenu();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
