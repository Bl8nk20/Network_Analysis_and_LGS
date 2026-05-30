using Network_Analysis_and_LGS.AbstractLayer.Interfaces;

namespace Network_Analysis_and_LGS.Graph.Models;

public interface IEdge<T>
{
    public INode<T> NodeA { get; set; }
    public INode<T> NodeB { get; set; }
    public ICircuitComponent? Component { get; set; }
    public string ToString();
}