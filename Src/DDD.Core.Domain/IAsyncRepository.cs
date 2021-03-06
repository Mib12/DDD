﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace DDD.Core.Domain
{
    public interface IAsyncRepository<TDomainEntity>
        where TDomainEntity : DomainEntity
    {
        #region Methods

        Task<TDomainEntity> FindAsync(params ComparableValueObject[] identityComponents);

        Task SaveAsync(TDomainEntity aggregate);

        Task SaveAllAsync(IEnumerable<TDomainEntity> aggregates);

        #endregion Methods
    }
}
