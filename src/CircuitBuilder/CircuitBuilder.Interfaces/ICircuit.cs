using Network_Analysis_and_LGS.ElectricalComponents.Models;
using Network_Analysis_and_LGS.Graph.Models;

namespace Network_Analysis_and_LGS.CircuitBuilder;

public interface ICircuit
{
    public IReadOnlyCollection<INode<IBaseComponent>> Nodes { get; }
    public IReadOnlyCollection<IEdge<IBaseComponent>> Edges { get; }

    public IEnumerable<INode<IBaseComponent>> GetNeighbors(INode<IBaseComponent> node);

    public double CalculateTotalResistance();
    public bool isSolveable();
}