using Microsoft.Extensions.DependencyInjection;
using Network_Analysis_and_LGS.AbstractLayer.Enums;
using Network_Analysis_and_LGS.AbstractLayer.Interfaces;
using Network_Analysis_and_LGS.ElectricalComponents.Extensions;
using Network_Analysis_and_LGS.CircuitAnalysis.Extensions;
using Network_Analysis_and_LGS.CircuitAnalysis;

var services = new ServiceCollection();

services
    .AddElectricalComponents()      // Validator & Factory als Singleton
    .AddCircuitAnalysis();          // CircuitBuilder als Scoped

var serviceProvider = services.BuildServiceProvider();

// CircuitBuilder abrufen
var builder = serviceProvider.GetRequiredService<ICircuitBuilder>();

var node1 = new NetworkNode("N1");
var node2 = new NetworkNode("N2");
var node3 = new NetworkNode("N3");
var node4 = new NetworkNode("N4");

var circuit = builder
    .AddNode(node1)
    .AddNode(node2)
    .AddNode(node3)
    .AddNode(node4)
    .AddComponent(node1, node2, ComponentType.Resistor, new() { { "resistance", 100.0 } })
    .AddComponent(node1, node2, ComponentType.Resistor, new() { { "resistance", 100.0 } })
    .AddComponent(node2, node3, ComponentType.Resistor, new() { { "resistance", 50.0 } })
    .AddComponent(node4, node1, ComponentType.Resistor, new() { { "resistance", 200.0 } })
    .AddComponent(node3, node4, ComponentType.Resistor, new() { { "resistance", 150.0 } })
    .Build();


// Output
Console.WriteLine($"Circuit hat {circuit.Nodes.Count} Knoten");
Console.WriteLine($"Circuit hat {circuit.Edges.Count} Kanten");

var equivalentR = circuit.GetEquivalentResistance(node1, node2);
Console.WriteLine($"Äquivalenter Widerstand zwischen {node1} und {node2}: {equivalentR}Ω");