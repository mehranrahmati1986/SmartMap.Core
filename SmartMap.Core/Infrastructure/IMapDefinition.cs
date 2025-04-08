using AutoMapper;

namespace SmartMap.Core.Infrastructure;

public interface IMapDefinition
{
    void ConfigureMapping(Profile profile);
}