using Network_Analysis_and_LGS.ElectricalComponents.Models;
using Network_Analysis_and_LGS.Graph.Models;
using Network_Analysis_and_LGS.Graph;

namespace Network_Analysis_and_LGS.CircuitBuilder;

public class CircuitBuilder : ICircuitBuilder
{
    private readonly IGraphBuilder<INetworkNode> _graphBuilder;

    public CircuitBuilder(){
        _graphBuilder = new GraphBuilder<INetworkNode>();
    }

    public ICircuitBuilder AddNode(INetworkNode node){
        _graphBuilder.AddNode(node);
        return this;
    }

    public ICircuitBuilder AddComponent(ICircuitComponent component, 
                                        INetworkNode node1, 
                                        INetworkNode node2){
        _graphBuilder.AddEdge(node1, node2, component);
        return this;
    }

    public ICircuit Build(){
        var _graph = _graphBuilder.Build();
        return new Circuit(_graph);
    }
}