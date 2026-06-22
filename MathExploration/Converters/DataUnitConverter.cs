using MathExploration.Data.Enums;
using MathExploration.Data.Maps;

namespace MathExploration.Converters {
    internal class DataUnitConverter {
        private static readonly DataConversionMap map = new DataConversionMap();
        public decimal Convert(DataUnit originalUnit, DataUnit desiredUnit, decimal d) {
            decimal massInGrams = map.GetConversionInBits(originalUnit) * d;
            decimal conversion = massInGrams / map.GetConversionInBits(desiredUnit);
            return conversion;
        }
    }
}
