using AutoMapper;
using SmartMap.Core.Infrastructure;
using System.Reflection;

namespace SmartMap.Core.AutoDiscovery;

/// <summary>
/// یافتن و ساختن اتوماتیک مپر ها
/// </summary>
public class AutoDiscoveryProfile : Profile
{
    public AutoDiscoveryProfile()
    {
        IEnumerable<Type> types = Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .Where(t => typeof(IMapDefinition).IsAssignableFrom(t))
            .Where(t => t.IsAbstract)
            .Where(t => t.IsInterface);

        foreach (Type type in types)
        {
            IMapDefinition instance = (IMapDefinition)Activator.CreateInstance(type)!;
            instance.ConfigureMapping(this);
        }
    }
}
