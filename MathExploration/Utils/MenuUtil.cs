using System.Globalization;

namespace MathExploration.Utils {
    internal class MenuUtil {
        private static ErrorUtil Error;

        public MenuUtil() {
            Error = new ErrorUtil();
        }

        public void SetStage(List<string> menu) {
            Console.Clear();
            foreach (string s in menu) Console.WriteLine(s);
        }

        public bool ReturnPrompt() {
            Console.WriteLine("\n\nPlease press enter to return to the previous menu. Any other key will allow you to run another calculation.");
            return Console.ReadKey().Key == ConsoleKey.Enter;
        }

        public string ReadInput(bool isSingleKey = false) {
            Console.WriteLine();

            if (isSingleKey) {
                return Console.ReadKey().KeyChar.ToString();
            } else {
                return Console.ReadLine();
            }
        }
        public decimal ConvertToDecimal(string input) {
            try {
                return decimal.Parse(input);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public int[] ParseChoices<T>(string choiceString) {
            string[] choice = choiceString.Split(' ');
            int limit = Enum.GetNames(typeof(T)).Length;
            int[] choices = new int[2];

            try {
                choices[0] = int.Parse(choice[0]) - 1;
                choices[1] = int.Parse(choice[1]) - 1;

                foreach (int c in choices) {
                    if (c >= limit || c < 0) {
                        Error.InvalidNumericalInput();
                    }
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }

            return choices;
        }

        public void ListEnums<T>() {
            TextInfo info = CultureInfo.CurrentCulture.TextInfo;
            int i = 1;

            foreach (var e in Enum.GetValues(typeof(T))) {
                Console.WriteLine($"{i}. {info.ToTitleCase(e.ToString().ToLower())}");
                i++;
            }
        }

        public void WaitForInput() {
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
