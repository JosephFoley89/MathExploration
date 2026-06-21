using MathExploration.Data.Menus;
using MathExploration.Utils;

namespace MathExploration.Data.Models {
    internal class MenuModel {
        public ErrorUtil Error;
        public MenuUtil Menu;
        public List<string> MenuText;

        public MenuModel(List<string> menuText, string menuTitle) {
            Error = new ErrorUtil();
            Menu = new MenuUtil();
            MenuText = menuText;

            Menu.SetStage(MenuText);
            Console.Title = menuTitle;
        }
    }
}
