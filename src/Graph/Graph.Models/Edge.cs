using Network_Analysis_and_LGS.AbstractLayer.Interfaces;

namespace Network_Analysis_and_LGS.Graph.Models;

public class Edge<T> : IEdge<T>
{
    public INode<T> NodeA { get; set; }
    public INode<T> NodeB { get; set; }
    public ICircuitComponent? Component { get; set; }

    public Edge(INode<T> nodeA, INode<T> nodeB, ICircuitComponent? component = null)
    {
        NodeA = nodeA;
        NodeB = nodeB;
        Component = component;
    }

    public override string ToString()
    {
        var componentInfo = Component != null
            ? $" [{Component.Type}]"
            : "";
        return $"Edge: between {NodeA} and {NodeB}{componentInfo}";
    }
}