using Attest.Testing.xUnit;
using LogoFX.Client.Testing.Contracts;
using Solid.Patterns.Builder;

namespace LogoFX.Client.Testing.Integration.xUnit
{
    /// <summary>
    /// Represents builder registration service for xUnit.net-based integration tests.
    /// </summary>
    /// <seealso cref="StepsBase" />
    /// <seealso cref="IBuilderRegistrationService" />
    public class BuilderRegistrationService : StepsBase, IBuilderRegistrationService
    {
        void IBuilderRegistrationService.RegisterBuilder<TService>(IBuilder<TService> builder)
        {
            RegisterBuilder(builder);
        }
    }
}
