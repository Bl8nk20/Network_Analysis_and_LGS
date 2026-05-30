using Network_Analysis_and_LGS.ElectricalComponents.Models;
using Network_Analysis_and_LGS.Graph.Models;

namespace Network_Analysis_and_LGS.CircuitBuilder;

public class Circuit : ICircuit
{
    public IReadOnlyCollection<INode<IBaseComponent>> Nodes => _circuitGraph.Nodes;
    public IReadOnlyCollection<IEdge<IBaseComponent>> Edges => _circuitGraph.Edges;
    private readonly IGraph<IBaseComponent> _circuitGraph;

    public Circuit(IGraph<IBaseComponent> circuitGraph)
    {
        _circuitGraph = circuitGraph;
    }
    public IEnumerable<INode<IBaseComponent>> GetNeighbors(INode<IBaseComponent> node)
    {
        return _circuitGraph.GetNeighbors(node);
    }

    public double CalculateTotalResistance()
    {
        // Implementation for calculating total resistance
        throw new NotImplementedException();
    }

    public bool isSolveable()
    {
        // Implementation for checking if the circuit is solveable
        throw new NotImplementedException();
    }
}