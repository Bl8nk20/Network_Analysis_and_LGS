using Microsoft.Extensions.DependencyInjection;

namespace Network_Analysis_and_LGS.CircuitAnalysis.Extensions;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Registriert alle CircuitAnalysis Services
    /// </summary>
    public static IServiceCollection AddCircuitAnalysis(this IServiceCollection services)
    {
        services.AddScoped<ICircuitBuilder, CircuitBuilder>();

        return services;
    }
}