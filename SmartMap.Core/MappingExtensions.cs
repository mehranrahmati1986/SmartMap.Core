﻿using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace SmartMap.Core;

public static class MappingExtensions
{
    public static TEntity ToEntity<TEntity>(this object source)
    {
        ArgumentNullException.ThrowIfNull(source);

        IMapper mapper = GetMapper();
        return mapper.Map<TEntity>(source);
    }

    public static TDestination ToDto<TDestination>(this object entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        IMapper mapper = GetMapper();
        return mapper.Map<TDestination>(entity);
    }

    private static IMapper GetMapper()
    {
        return ServiceLocator.Instance.GetRequiredService<IMapper>();
    }
}
