using MathExploration.Converters.Mass;

namespace MathExploration.Calculations {
    internal class DataMassCalculator {
        private MassUnitConverter MassConverter = new MassUnitConverter();
        private const decimal BITMASS = 1e-18M;
        private decimal calculatedMass;

        public void Calculate(decimal n) {
            calculatedMass = n * BITMASS;
            Console.WriteLine($"The calculated mass of the {n} bits of data is {calculatedMass} grams.");
        }
    }
}
