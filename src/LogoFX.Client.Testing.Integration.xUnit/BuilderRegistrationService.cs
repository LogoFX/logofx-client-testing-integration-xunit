﻿using Attest.Testing.Contracts;
using Attest.Testing.xUnit;
using Solid.Patterns.Builder;

namespace LogoFX.Client.Testing.Integration.xUnit
{
    /// <summary>
    /// Represents builder registration service for xUnit.net-based integration tests.
    /// </summary>
    /// <seealso cref="StepsBase" />
    /// <seealso cref="IBuilderRegistrationService" />
    public sealed class BuilderRegistrationService : StepsBase, IBuilderRegistrationService
    {
        void IBuilderRegistrationService.RegisterBuilder<TService>(IBuilder<TService> builder)
        {
            RegisterBuilderProduct(builder);
        }
    }
}