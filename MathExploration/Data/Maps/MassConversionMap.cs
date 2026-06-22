using MathExploration.Data.Enums;

namespace MathExploration.Data.Maps {
    internal class MassConversionMap {
        private static readonly Dictionary<Enums.MassUnit, Decimal> GramConversions = new Dictionary<MassUnit, decimal> {
            { MassUnit.PICOGRAM, 1e-12m },
            { MassUnit.NANOGRAM, 1e-9m },
            { MassUnit.MICROGRAM, 1e-6m },
            { MassUnit.MILLIGRAM, 1e-3m },
            { MassUnit.GRAM, 1m },
            { MassUnit.KILOGRAM, 1e3m },
            { MassUnit.TONNE, 1e6m },
            { MassUnit.MEGATONNE, 1e12m },
            { MassUnit.GIGATONNE, 1e15m },
            { MassUnit.OUNCE, 28.34952m },
            { MassUnit.POUND, 453.59237m },
            { MassUnit.TON, 907184.74m }
        };

        public decimal GetConversionInGrams(MassUnit unit) {
            return GramConversions[unit];
        }
    }
}
