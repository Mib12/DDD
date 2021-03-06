﻿using System.Collections.Generic;

namespace DDD.Core.Domain
{
    public interface IRepository<TDomainEntity>
        where TDomainEntity : DomainEntity
    {
        #region Methods

        TDomainEntity Find(params ComparableValueObject[] identityComponents);

        void Save(TDomainEntity aggregate);

        void SaveAll(IEnumerable<TDomainEntity> aggregates);

        #endregion Methods
    }
}
