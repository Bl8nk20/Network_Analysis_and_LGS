using Microsoft.Extensions.DependencyInjection;
using Network_Analysis_and_LGS.AbstractLayer.Interfaces;
using Network_Analysis_and_LGS.ElectricalComponents.Factory;
using Network_Analysis_and_LGS.ElectricalComponents.Validators;

namespace Network_Analysis_and_LGS.ElectricalComponents.Extensions;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Registriert alle ElectricalComponents Services
    /// </summary>
    public static IServiceCollection AddElectricalComponents(this IServiceCollection services)
    {
        // Validator als Singleton registrieren
        services.AddSingleton<IValidator, ResistanceValidator>();

        // Factory als Singleton registrieren (erzeugt nur eine Instanz)
        services.AddSingleton<ICircuitComponentFactory, CircuitComponentFactory>();

        return services;
    }
}