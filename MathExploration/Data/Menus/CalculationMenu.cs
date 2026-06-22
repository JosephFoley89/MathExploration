using MathExploration.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExploration.Data.Menus {
    internal class CalculationMenu : MenuModel {
        private static DataMassMenu dataMassMenu;
        private static CollatzMenu collatzMenu;

        private string selection = string.Empty;
        private static List<string> menuText = new List<string>() {
            "1. Calculate the weight of stored data",
            "2. Calculate the Collatz Conjecture",
            "9. Main menu",
            "0. Exit application"
        };

        public CalculationMenu() : base(menuText, "Calculation Menu") {
            ReadSelection();
        }

        public void ReadSelection() {
            selection = Menu.ReadInput(true);

            switch (selection) {
                case "1":
                    dataMassMenu = new DataMassMenu();
                    dataMassMenu.CalculateMassOfStoredData();
                    break;
                case "2":
                    collatzMenu = new CollatzMenu();
                    collatzMenu.CalculateCollatz();
                    break;
                case "3":
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
            }

            selection = Menu.ReadInput(true);
        }
    }
}
