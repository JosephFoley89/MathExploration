namespace MathExploration.ProjectEulerSolutions {
    internal class Problem6 {
        public Problem6(int limit) {
            Solve(limit);
        }

        public void Solve(int limit) {
            int sumOfSquares = 0;
            int squareOfSums = 0;

            for (int i = 1; i <= limit; i++) {
                sumOfSquares += i * i;
                squareOfSums += i;
            }

            squareOfSums *= squareOfSums;
            Console.WriteLine($"The difference between the sum of the squares and the square of the sums is {squareOfSums - sumOfSquares}");
        }
    }
}
