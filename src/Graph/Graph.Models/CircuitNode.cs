using Network_Analysis_and_LGS.Graph.Interfaces;

namespace Network_Analysis_and_LGS.Graph.Implementations;

public class CircuitNode : ICircuitNode
{
    public string ID { get; }
    public List<CircuitEdge> ConnectedEdges { get; }

    public CircuitNode(string id)
    {
        ID = id;
        ConnectedEdges = new List<CircuitEdge>();
    }

    public override string ToString()
    {
        return $"CircuitNode: {ID} with {ConnectedEdges.Count} connected edges";
    }
}