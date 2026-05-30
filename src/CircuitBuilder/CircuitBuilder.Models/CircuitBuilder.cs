using Network_Analysis_and_LGS.ElectricalComponents.Models;
using Network_Analysis_and_LGS.Graph.Models;
using Network_Analysis_and_LGS.Graph;

namespace Network_Analysis_and_LGS.CircuitBuilder;

public class CircuitBuilder : ICircuitBuilder
{
    private readonly IGraphBuilder<IBaseComponent> _circuitGraph;
    
    public CircuitBuilder()
    {
        _circuitGraph = new GraphBuilder<IBaseComponent>();
    }

    public ICircuitBuilder AddResistor(IBaseComponent resistor)
    {
        throw new NotImplementedException();
    }

    public ICircuitBuilder ConnectComponents(IBaseComponent componentA, IBaseComponent componentB)
    {
        throw new NotImplementedException();
    }

    public ICircuit Build()
    {
        throw new NotImplementedException();
    }
}