using ImageChartsLib;

namespace MathExploration.Calculations {
    internal class Collatz {
        private decimal InitialNumber;
        private List<List<decimal>> collatzSolutions;

        public Collatz(decimal initialNumber) {
            InitialNumber = initialNumber;
            collatzSolutions = new List<List<decimal>>();
        }

        public void Solve() {
            decimal currentNumber = InitialNumber;
            List<decimal> sequence = new List<decimal>() { InitialNumber };

            while (currentNumber != 1) {
                currentNumber = currentNumber % 2 == 0 ? currentNumber / 2 : (currentNumber * 3) + 1;

                sequence.Add(currentNumber);
            }

            Console.WriteLine($"The Collatz sequence for {InitialNumber} is: {string.Join(", ", sequence)}");

            GenerateSolutions();
            GenerateChart();
        }

        private void GenerateSolutions() {
            decimal currentNumber = InitialNumber, startingNumber = InitialNumber;

            for (int i = 0; i < 5; i++) {
                List<decimal> sequence = new List<decimal>() { currentNumber };

                while (currentNumber != 1) {
                    currentNumber = currentNumber % 2 == 0 ? currentNumber / 2 : (currentNumber * 3) + 1;
                    sequence.Add(currentNumber);
                }

                collatzSolutions.Add(sequence);

                startingNumber /= 2;
                currentNumber = (int)startingNumber;
            }
        }

        private void GenerateChart() {
            List<List<decimal>> values = collatzSolutions;
            string path = Path.Combine(Environment.CurrentDirectory, $"CollatzChart-{DateTime.UtcNow:yyMMddHHmmss}.png");
            
            new ImageCharts()
                .cht("lc")
                .chs("800x600")
                .chd(
                    $"a:{string.Join(",", values[0])}|" +
                    $"{string.Join(",", values[1])}|" +
                    $"{string.Join(",", values[2])}|" +
                    $"{string.Join(",", values[3])}|" +
                    $"{string.Join(",", values[4])}"
                )
                .chdlp("b")
                .chtt("Collatz Sequences")
                .chxt("x,y")
                .toFile(path);

            collatzSolutions = new List<List<decimal>>();
        }
    }
}
