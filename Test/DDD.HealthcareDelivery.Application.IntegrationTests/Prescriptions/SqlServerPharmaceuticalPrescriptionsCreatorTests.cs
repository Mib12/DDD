﻿using Xunit;

namespace DDD.HealthcareDelivery.Application.Prescriptions
{
    using Core.Domain;
    using Core.Infrastructure.Serialization;
    using Domain.Prescriptions;
    using Infrastructure.Prescriptions;
    using Infrastructure;

    [Collection("SqlServer")]
    public class SqlServerPharmaceuticalPrescriptionsCreatorTests
        : PharmaceuticalPrescriptionsCreatorTests<SqlServerFixture>
    {

        #region Constructors

        public SqlServerPharmaceuticalPrescriptionsCreatorTests(SqlServerFixture fixture) : base(fixture)
        {
        }

        #endregion Constructors

        #region Methods

        protected override IRepository<PharmaceuticalPrescription> CreateRepository()
        {
            return new PharmaceuticalPrescriptionRepository
            (
                new Domain.Prescriptions.BelgianPharmaceuticalPrescriptionTranslator(),
                new StoredEventTranslator(new GenericDataContractSerializer<IDomainEvent>()),
                new SqlServerHealthcareContextFactory(this.Fixture.ConnectionFactory)
            );
        }

        #endregion Methods

    }
}