using MathExploration.Data.Enums;

namespace MathExploration.Data.Maps {
    internal class MassConversionMap {
        private static readonly Dictionary<Enums.MassEnum, Decimal> GramConversions = new Dictionary<MassEnum, decimal> {
            { MassEnum.PICOGRAM, 1e-12m },
            { MassEnum.NANOGRAM, 1e-9m },
            { MassEnum.MICROGRAM, 1e-6m },
            { MassEnum.MILLIGRAM, 1e-3m },
            { MassEnum.GRAM, 1m },
            { MassEnum.KILOGRAM, 1e3m },
            { MassEnum.TONNE, 1e6m },
            { MassEnum.MEGATONNE, 1e12m },
            { MassEnum.GIGATONNE, 1e15m },
            { MassEnum.OUNCE, 28.34952m },
            { MassEnum.POUND, 453.59237m }
        };

        public decimal GetConversionInGrams(MassEnum unit) {
            return GramConversions[unit];
        }
    }
}
