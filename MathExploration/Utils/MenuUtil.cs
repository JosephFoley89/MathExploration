namespace MathExploration.Utils {
    internal class MenuUtil {
        public void SetStage(List<string> menu) {
            Console.Clear();
            foreach (string s in menu) Console.WriteLine(s);
        }

        public bool ReturnPrompt() {
            Console.WriteLine("\n\nPlease press enter to return to the previous menu. Any other key will allow you to run another calculation.");
            return Console.ReadKey().Key == ConsoleKey.Enter;
        }

        public string ReadInput() {
            return Console.ReadLine();
        }
    }
}
