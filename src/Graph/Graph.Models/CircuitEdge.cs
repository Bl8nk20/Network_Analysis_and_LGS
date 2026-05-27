using Network_Analysis_and_LGS.Graph.Interfaces;
using Network_Analysis_and_LGS.ElectricalComponents.Interfaces;

namespace Network_Analysis_and_LGS.Graph.Implementations;

public class CircuitEdge : ICircuitEdge
{
    public IBaseComponent Component { get; }
    public string ID { get; }

    public ICircuitNode NodeA { get; }

    public ICircuitNode NodeB { get; }

    public CircuitEdge(
        IBaseComponent component,
        ICircuitNode nodeA,
        ICircuitNode nodeB)
    {
        Component = component;

        NodeA = nodeA;
        NodeB = nodeB;
    }

    public override string ToString()
    {
        return $"CircuitEdge: {Component.ID} between {NodeA.ID} and {NodeB.ID}";
    }
}