namespace Network_Analysis_and_LGS.ElectricalComponents.Interfaces
{
    interface IBaseResistor : IBaseComponents
    {
        public double CalculateResistanceAlphaNumerical(string alphanumericalCode);
        public double CalculateResistanceColorCode(Enums.SignificantFigures[] firsttwoBands,
                                                    Enums.Multiplier thirdBand, 
                                                    Enums.Tolerance fourthBand, 
                                                    Enums.AllowedVoltage fifthBand = Enums.AllowedVoltage.NoColor, 
                                                    Enums.TempCoefficient sixthBand = Enums.TempCoefficient.Grey);        
    }
}