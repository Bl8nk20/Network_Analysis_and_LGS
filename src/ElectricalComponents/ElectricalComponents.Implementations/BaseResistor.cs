using Network_Analysis_and_LGS.ElectricalComponents.Interfaces;
using Network_Analysis_and_LGS.ElectricalComponents.Enums;
using Network_Analysis_and_LGS.ElectricalComponents.Validator;

namespace Network_Analysis_and_LGS.ElectricalComponents.Implementations;

public class BaseResistor : Interfaces.IBaseResistor
{
    private readonly IValidator _validator = new ResistanceValidator();

    double _resistance { get; set; }
    Enums.SignificantFigures[] _firsttwoBands 
    { 
        get;
        set
        {
           _firsttwoBands = _validator.Validate(value) ? value : throw new ArgumentException("Invalid value for first two bands"); 
        } 
    }
    Enums.Multiplier _thirdBand 
    { 
        get;
        set
        {
            _thirdBand = _validator.Validate(value) ? value : throw new ArgumentException("Invalid value for third band");
        }
    }
    Enums.Tolerance _fourthBand 
    { 
        get;
        set
        {
            _fourthBand = _validator.Validate(value) ? value : throw new ArgumentException("Invalid value for fourth band");
        }
    }
    
    Enums.AllowedVoltage _fifthBand 
    { 
        get;
        set
        {
            _fifthBand = _validator.Validate(value) ? value : throw new ArgumentException("Invalid value for fifth band");
        }
    }
    Enums.TempCoefficient _sixthBand 
    { 
        get;
        set
        {
            _sixthBand = _validator.Validate(value) ? value : throw new ArgumentException("Invalid value for sixth band");
        }
    }

    public BaseResistor()
    {

    }

    public BaseResistor(string AlphanumericalCode)
    {
    }

    public BaseResistor(double resistance)
    {
        _resistance = resistance;
    }

    public BaseResistor(Enums.SignificantFigures[] firsttwoBands,
                        Enums.Multiplier thirdBand, 
                        Enums.Tolerance fourthBand, 
                        Enums.AllowedVoltage fifthBand = Enums.AllowedVoltage.NoColor, 
                        Enums.TempCoefficient sixthBand = Enums.TempCoefficient.Grey)
    {
        _firsttwoBands = firsttwoBands;
        _thirdBand = thirdBand;
        _fourthBand = fourthBand;
        _fifthBand = fifthBand;
        _sixthBand = sixthBand;
    }

    #region Private Methods
    private void calculateResistanceAlphaNumerical(string alphanumericalCode){

    }
    #endregion
}