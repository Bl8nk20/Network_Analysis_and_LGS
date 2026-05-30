using Network_Analysis_and_LGS.ElectricalComponents.Models;
using Network_Analysis_and_LGS.Graph.Models;

namespace Network_Analysis_and_LGS.CircuitBuilder;

public interface ICircuitBuilder
{
    public ICircuitBuilder AddResistor(IBaseComponent resistor);
    public ICircuitBuilder ConnectComponents(IBaseComponent componentA, IBaseComponent componentB);
    public ICircuit Build();
}