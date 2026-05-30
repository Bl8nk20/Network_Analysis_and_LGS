using Network_Analysis_and_LGS.ElectricalComponents.Enums;
using Network_Analysis_and_LGS.ElectricalComponents.Validators;

namespace Network_Analysis_and_LGS.ElectricalComponents.Models;

public class BaseResistor : IBaseResistor
{
    private readonly IValidator _validator;
    private double _resistance = 0.0;
    private SignificantFigures[] _firsttwoBands = Array.Empty<SignificantFigures>();
    private Multiplier _thirdBand = Multiplier.Black;
    private Tolerance _fourthBand = Tolerance.Brown;
    private AllowedVoltage _fifthBand = AllowedVoltage.NoColor;
    private TempCoefficient _sixthBand = TempCoefficient.Grey;

    public SignificantFigures[] FirstTwoBands
    {
        get => _firsttwoBands;
        set => _firsttwoBands = ValidateOrThrow<SignificantFigures[]>(value, "First two bands invalid");
    }

    public Multiplier ThirdBand
    {
        get => _thirdBand;
        set => _thirdBand = ValidateOrThrow<Multiplier>(value, "Third band invalid");
    }

    public Tolerance FourthBand
    {
        get => _fourthBand;
        set => _fourthBand = ValidateOrThrow<Tolerance>(value, "Fourth band invalid");
    }

    public AllowedVoltage FifthBand
    {
        get => _fifthBand;
        set => _fifthBand = ValidateOrThrow<AllowedVoltage>(value, "Fifth band invalid");
    }

    public TempCoefficient SixthBand
    {
        get => _sixthBand;
        set => _sixthBand = ValidateOrThrow<TempCoefficient>(value, "Sixth band invalid");
    }

    public double Resistance    {
        get => _resistance;
        set => _resistance = ValidateOrThrow<double>(value, "Resistance value invalid");
    }

    public BaseResistor(IValidator validator)
    {
        _validator = validator;
    }

    public BaseResistor(IValidator validator, string alphanumericalCode)
    {
        _validator = validator;
    }

    public BaseResistor(IValidator validator, double resistance)
    {
        _validator = validator;
        _resistance = resistance;
    }

    public BaseResistor(IValidator validator, 
                        Enums.SignificantFigures[] firsttwoBands,
                        Enums.Multiplier thirdBand, 
                        Enums.Tolerance fourthBand, 
                        Enums.AllowedVoltage fifthBand = Enums.AllowedVoltage.NoColor, 
                        Enums.TempCoefficient sixthBand = Enums.TempCoefficient.Grey)
    {
        _validator = validator; 
        _firsttwoBands = firsttwoBands;
        _thirdBand = thirdBand;
        _fourthBand = fourthBand;
        _fifthBand = fifthBand;
        _sixthBand = sixthBand;
    }

    #region Private Methods
        
    private T ValidateOrThrow<T>(T value, string message)
    {
        if (!_validator.Validate(value))
            throw new ArgumentException(message);
        return value;
    }

    #endregion
}