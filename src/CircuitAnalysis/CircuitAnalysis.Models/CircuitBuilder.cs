using Network_Analysis_and_LGS.AbstractLayer.Enums;
using Network_Analysis_and_LGS.AbstractLayer.Interfaces;
using Network_Analysis_and_LGS.Graph.Models;
using Network_Analysis_and_LGS.Graph;

namespace Network_Analysis_and_LGS.CircuitAnalysis;

public class CircuitBuilder : ICircuitBuilder
{
    private readonly IGraphBuilder<INetworkNode> _graphBuilder;
    private readonly ICircuitComponentFactory _componentFactory;

    public CircuitBuilder(ICircuitComponentFactory componentFactory)
    {
        _graphBuilder = new GraphBuilder<INetworkNode>();
        _componentFactory = componentFactory;
    }

    public ICircuitBuilder AddNode(INetworkNode node)
    {
        _graphBuilder.AddNode(node);
        return this;
    }

    public ICircuitBuilder AddComponent(
        INetworkNode nodeA, 
        INetworkNode nodeB, 
        ComponentType componentType,
        Dictionary<string, object> parameters)
    {
        var component = _componentFactory.CreateComponent(componentType, parameters);
        _graphBuilder.AddEdge(nodeA, nodeB, component);
        return this;
    }

    public ICircuitBuilder AddComponent(
        INetworkNode nodeA,
        INetworkNode nodeB,
        ICircuitComponent component)
    {
        _graphBuilder.AddEdge(nodeA, nodeB, component);
        return this;
    }

    public ICircuit Build()
    {
        var graph = _graphBuilder.Build();
        return new Circuit(graph);
    }
}