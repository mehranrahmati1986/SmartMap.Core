using AutoMapper;

namespace SmartMap.Core;

public interface IMapDefinition
{
    void ConfigureMapping(Profile profile);
}