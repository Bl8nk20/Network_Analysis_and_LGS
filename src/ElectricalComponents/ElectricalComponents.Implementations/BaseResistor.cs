using Network_Analysis_and_LGS.ElectricalComponents.Interfaces;
using Network_Analysis_and_LGS.ElectricalComponents.Enums;
using Network_Analysis_and_LGS.ElectricalComponents.Validator;

namespace Network_Analysis_and_LGS.ElectricalComponents.Implementations;

public class BaseResistor : Interfaces.IBaseResistor
{
    private readonly IValidator _validator = new ResistanceValidator();

    double _resistance { get; set; }
    Enums.SignificantFigures[] _firsttwoBands 
    { get;
      set{
        if (_validator.Validate(value)){
            _firsttwoBands = value;
        }
        else
        {
            throw new ArgumentException("Invalid value for first two bands");
        }
    }
    }
    Enums.Multiplier _thirdBand 
    { get;
      set{
        if (_validator.Validate(value)){
            _thirdBand = value;
        }
        else
        {
            throw new ArgumentException("Invalid value for third band");
        }
    }
    }
    Enums.Tolerance _fourthBand 
    { get;
      set{
        if (_validator.Validate(value)){
            _fourthBand = value;
        }
        else
        {
            throw new ArgumentException("Invalid value for fourth band");
        }
    }
    } 
    Enums.AllowedVoltage _fifthBand 
    { get;
      set{
        if (_validator.Validate(value)){
            _fifthBand = value;
        }
        else
        {
            throw new ArgumentException("Invalid value for fifth band");
        }
    }
    }
    Enums.TempCoefficient _sixthBand 
    { get;
      set {
        if (_validator.Validate(value)){
            _sixthBand = value;
        }
        else
        {
            throw new ArgumentException("Invalid value for sixth band");
        }
    }
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

    public BaseResistor(string AlphanumericalCode)
    {
    }

    public BaseResistor(double resistance)
    {
        _resistance = resistance;
    }

    #region Public Methods
    public double CalculateResistanceAlphaNumerical(string alphanumericalCode){
        throw new NotImplementedException();
    }

    public double CalculateResistanceColorCode(Enums.SignificantFigures[] firsttwoBands,
                                                    Enums.Multiplier thirdBand, 
                                                    Enums.Tolerance fourthBand, 
                                                    Enums.AllowedVoltage fifthBand = Enums.AllowedVoltage.NoColor, 
                                                    Enums.TempCoefficient sixthBand = Enums.TempCoefficient.Grey){
        throw new NotImplementedException();
    }

    #endregion

    #region Private Methods
    private void calculateResistanceAlphaNumerical(string alphanumericalCode){

    }
    #endregion
}