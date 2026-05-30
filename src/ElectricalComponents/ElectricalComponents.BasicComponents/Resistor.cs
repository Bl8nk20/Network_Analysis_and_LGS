using Network_Analysis_and_LGS.AbstractLayer;
using Network_Analysis_and_LGS.AbstractLayer.Enums;
using Network_Analysis_and_LGS.ElectricalComponents.Enums;
using Network_Analysis_and_LGS.ElectricalComponents.Validators;

namespace Network_Analysis_and_LGS.ElectricalComponents.BasicComponents;

public class Resistor : IResistor
{
    private readonly IValidator _validator;
    private double _resistance = 0.0;
    private SignificantFigures[] _firsttwoBands = Array.Empty<SignificantFigures>();
    private Multiplier _thirdBand = Multiplier.Black;
    private Tolerance _fourthBand = Tolerance.Brown;
    private AllowedVoltage _fifthBand = AllowedVoltage.NoColor;
    private TempCoefficient _sixthBand = TempCoefficient.Grey;

    public string ID { get; }
    public ComponentType Type => ComponentType.Resistor;

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

    public double Resistance
    {
        get => _resistance;
        set => _resistance = ValidateOrThrow<double>(value, "Resistance value invalid");
    }

    public Resistor(IValidator validator)
    {
        _validator = validator;
        ID = Guid.NewGuid().ToString();
    }

    public Resistor(IValidator validator, double resistance) : this(validator)
    {
        _resistance = resistance;
    }

    public Resistor(IValidator validator,
                        SignificantFigures[] firsttwoBands,
                        Multiplier thirdBand,
                        Tolerance fourthBand,
                        AllowedVoltage fifthBand = AllowedVoltage.NoColor,
                        TempCoefficient sixthBand = TempCoefficient.Grey) : this(validator)
    {
        _firsttwoBands = firsttwoBands;
        _thirdBand = thirdBand;
        _fourthBand = fourthBand;
        _fifthBand = fifthBand;
        _sixthBand = sixthBand;
    }

    public double GetResistance() => _resistance;

    private T ValidateOrThrow<T>(T value, string message)
    {
        if (!_validator.Validate(value))
            throw new ArgumentException(message);
        return value;
    }
}