namespace Network_Analysis_and_LGS.ElectricalComponents.Enums;

/// <summary>
/// This enum is used to determine the temperature coefficient of a resistor based on the color code of the sixth band.
/// </summary>
public enum TempCoefficient
{
    Black,
    Brown,
    Red,
    Orange,
    Yellow,
    Green,
    Blue,
    Violet,
    Grey
}

/// <summary>
/// This enum is used to determine the maximum voltage of a resistor based on the color code of the fifth band.
/// </summary>
public enum AllowedVoltage
{
    Brown,
    Red,
    Orange,
    Yellow,
    Green,
    Blue,
    Violet,
    Grey,
    White,
    Gold,
    Silver,
    NoColor
}

/// <summary>
/// This enum is used to determine the significant figures of a resistor based on the color code of the first two bands.
/// </summary>
public enum SignificantFigures
{
    Black,
    Brown,
    Red,
    Orange,
    Yellow,
    Green,
    Blue,
    Violet,
    Grey,
    White
}

/// <summary>
/// This enum is used to determine the tolerance of a resistor based on the color code of the fourth band.
/// </summary>
public enum Tolerance
{
    Brown,
    Red,
    Green,
    Blue,
    Violet,
    Gold,
    Silver,
    NoColor
}

/// <summary>
/// This enum is used to determine the multiplier of a resistor based on the color code of the third band.
/// </summary>
public enum Multiplier
{
    Black,
    Brown,
    Red,
    Orange,
    Yellow,
    Green,
    Blue,
    Violet,
    Grey,
    White,
    Gold,
    Silver,
}

public static class ResistorExtensions
{

    public static double GetMultiplierValue(this Multiplier multiplier)
    => multiplier switch
    {
        Multiplier.Black => 1,
        Multiplier.Brown => 10,
        Multiplier.Red => 100,
        Multiplier.Orange => 1000,
        Multiplier.Yellow => 10_000,
        Multiplier.Green => 100_000,
        Multiplier.Blue => 1_000_000,
        Multiplier.Violet => 10_000_000,
        Multiplier.Grey => 100_000_000,
        Multiplier.White => 1_000_000_000,
        Multiplier.Gold => 0.1,
        Multiplier.Silver => 0.01,
        _ => throw new ArgumentOutOfRangeException(nameof(multiplier), multiplier, null)
    };

    public static double GetToleranceValue(this Tolerance tolerance)
    => tolerance switch
    {
        Tolerance.Brown => 1,
        Tolerance.Red => 2,
        Tolerance.Green => 0.5,
        Tolerance.Blue => 0.25,
        Tolerance.Violet => 0.1,
        Tolerance.Gold => 5,
        Tolerance.Silver => 10,
        Tolerance.NoColor => 20,
        _ => throw new ArgumentOutOfRangeException(nameof(tolerance), tolerance, null)
    };

    public static double GetTempCoefficientValue(this TempCoefficient tempCoefficient)
    => tempCoefficient switch
    {
        TempCoefficient.Black => 250,
        TempCoefficient.Brown => 100,
        TempCoefficient.Red => 50,
        TempCoefficient.Orange => 15,
        TempCoefficient.Yellow => 25,
        TempCoefficient.Green => 20,
        TempCoefficient.Blue => 10,
        TempCoefficient.Violet => 5,
        TempCoefficient.Grey => 1,
        _ => throw new ArgumentOutOfRangeException(nameof(tempCoefficient), tempCoefficient, null)
    };

    public static double GetAllowedVoltageValue(this AllowedVoltage allowedVoltage)
    => allowedVoltage switch
    {
        AllowedVoltage.Brown => 100,
        AllowedVoltage.Red => 200,
        AllowedVoltage.Orange => 300,
        AllowedVoltage.Yellow => 400,
        AllowedVoltage.Green => 500,
        AllowedVoltage.Blue => 600,
        AllowedVoltage.Violet => 700,
        AllowedVoltage.Grey => 800,
        AllowedVoltage.White => 900,
        AllowedVoltage.Gold => 1000,
        AllowedVoltage.Silver => 2000,
        AllowedVoltage.NoColor => 500,
        _ => throw new ArgumentOutOfRangeException(nameof(allowedVoltage), allowedVoltage, null)
    };

    public static double GetSignificantFigureValue(this SignificantFigures significantFigure)
    => significantFigure switch
    {
        SignificantFigures.Black => 0,
        SignificantFigures.Brown => 1,
        SignificantFigures.Red => 2,
        SignificantFigures.Orange => 3,
        SignificantFigures.Yellow => 4,
        SignificantFigures.Green => 5,
        SignificantFigures.Blue => 6,
        SignificantFigures.Violet => 7,
        SignificantFigures.Grey => 8,
        SignificantFigures.White => 9,
        _ => throw new ArgumentOutOfRangeException(nameof(significantFigure), significantFigure, null)
    };
}