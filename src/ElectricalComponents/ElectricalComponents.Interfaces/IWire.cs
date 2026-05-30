namespace Network_Analysis_and_LGS.ElectricalComponents.Models
{
    public interface IWire : IBaseComponent
    {
        double GetResistance();
    }
}