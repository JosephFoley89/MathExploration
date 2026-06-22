using MathExploration.Data.Enums;

namespace MathExploration.Data.Maps {
    internal class DataConversionMap {
        private Dictionary<DataUnit, decimal> BitConversions = new Dictionary<DataUnit, decimal> {
            { DataUnit.BIT, 1 },
            { DataUnit.BYTE, 8 },
            { DataUnit.KILOBYTE, 8192 },
            { DataUnit.MEGABYTE, 8388608 },
            { DataUnit.GIGABYTE, 8589934592 },
            { DataUnit.TERABYTE, 8796093022208 },
            { DataUnit.PETABYTE, 9007199254740992 },
            { DataUnit.EXABYTE, 9223372036854775808 }
        };

        public decimal GetConversionInBits(DataUnit unit) {
            return BitConversions[unit];
        }
    }
}
