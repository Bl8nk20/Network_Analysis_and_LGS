namespace Network_Analysis_and_LGS.ElectricalComponents.Validators;

public class ResistanceValidator : IValidator
{
    public bool Validate(object value)
    {
        if (value is double doubleValue)
        {
            return doubleValue >= 0;
        }

        return false;
    }
}