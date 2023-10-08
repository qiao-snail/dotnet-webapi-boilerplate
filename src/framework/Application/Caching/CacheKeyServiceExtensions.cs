﻿using FSH.Framework.Domain.Entities;

namespace FSH.Framework.Application.Caching;

public static class CacheKeyServiceExtensions
{
    public static string GetCacheKey<TEntity>(this ICacheKeyService cacheKeyService, object id, bool includeTenantId = true)
    where TEntity : IEntity =>
        cacheKeyService.GetCacheKey(typeof(TEntity).Name, id, includeTenantId);
}