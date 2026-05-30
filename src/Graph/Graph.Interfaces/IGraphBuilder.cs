using Network_Analysis_and_LGS.Graph.Models;

namespace Network_Analysis_and_LGS.Graph;

public interface IGraphBuilder<T>
{
    public Node<T> AddNode(T value);
    public IGraphBuilder<T> AddEdge(T valueA, T valueB);
    public IGraphBuilder<T> AddEdge(T valueA, T valueB, T? value);
    
    public IGraph<T> Build();
}