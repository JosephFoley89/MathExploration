using MathExploration.Data.Enums;
using MathExploration.Data.Maps;
namespace MathExploration.Converters.Mass {
    internal class MassUnitConverter {
        private static readonly MassConversionMap map = new MassConversionMap();

        public (decimal, MassEnum) Convert(MassEnum originalUnit, MassEnum desiredUnit, decimal d) {
            decimal massInGrams = map.GetConversionInGrams(originalUnit) * d;
            decimal conversion = massInGrams / map.GetConversionInGrams(desiredUnit);
            return (conversion, desiredUnit);
        }
    }
}
