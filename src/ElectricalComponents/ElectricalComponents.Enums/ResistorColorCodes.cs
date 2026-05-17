namespace Network_Analysis_and_LGS.ElectricalComponents.Enums
{
    /// <summary>
    /// This enum is used to determine the temperature coefficient of a resistor based on the color code of the sixth band.
    /// </summary>
    public enum TempCoefficient{
        Black = 250,
        Brown = 100,
        Red = 50,
        Orange = 15,
        Yellow = 25,
        Green = 20,
        Blue = 10,
        Violet = 5,
        Grey = 1
    }

    /// <summary>
    /// This enum is used to determine the maximum voltage of a resistor based on the color code of the fifth band.
    /// </summary>
    public enum AllowedVoltage{
        Brown = 100,
        Red = 200,
        Orange = 300,
        Yellow = 400,
        Green = 500,
        Blue = 600,
        Violet = 700,
        Grey = 800,
        White = 900,
        Gold = 1000,
        Silver = 2000,
        NoColor = 500
    }

    /// <summary>
    /// This enum is used to determine the significant figures of a resistor based on the color code of the first two bands.
    /// </summary>
    public enum SignificantFigures{
        Black = 0,
        Brown = 1,
        Red = 2,
        Orange = 3,
        Yellow = 4,
        Green = 5,
        Blue = 6,
        Violet = 7,
        Grey = 8,
        White = 9
    }

    /// <summary>
    /// This enum is used to determine the tolerance of a resistor based on the color code of the fourth band.
    /// </summary>
    public struct Tolerance{
        public const double Brown = 1;
        public const double Red = 2;
        public const double Green = 0.5;
        public const double Blue = 0.25;
        public const double Violet = 0.1;
        public const double Gold = 5;
        public const double Silver = 10;
        public const double NoColor = 20;
    }

    ///
    /// <summary>
    /// This enum is used to determine the multiplier of a resistor based on the color code of the third band.
    /// </summary>
    public struct Multiplier{
        public const double Black = 1;
        public const double Brown = 10;
        public const double Red = 100;
        public const double Orange = 1000;
        public const double Yellow = 10_000;
        public const double Green = 100_000;
        public const double Blue = 1_000_000; 
        public const double Violet = 10_000_000;
        public const double Grey = 100_000_000;
        public const double White = 1_000_000_000;
        public const double Gold = 0.1;
        public const double Silver = 0.01;
    }
}