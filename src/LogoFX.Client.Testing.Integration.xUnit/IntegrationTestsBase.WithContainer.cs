using Attest.Testing.Context;
using Attest.Testing.Core;
using LogoFX.Client.Testing.Shared;
using Solid.Bootstrapping;
using Solid.Core;
using Solid.Practices.IoC;

namespace LogoFX.Client.Testing.Integration.xUnit
{
    /// <summary>
    /// Base class for client integration tests.
    /// </summary>
    /// <typeparam name="TContainer">The type of the ioc container.</typeparam>
    /// <typeparam name="TContainerAdapter">The type of the ioc container adapter.</typeparam>
    /// <typeparam name="TRootObject">The type of the root object.</typeparam>
    /// <typeparam name="TBootstrapper">The type of the bootstrapper.</typeparam>
    /// <seealso cref="Attest.Testing.Integration.xUnit.IntegrationTestsBase{TContainer, TContainerAdapter, TRootObject, TBootstrapper}" />
    public abstract class IntegrationTestsBase<TContainer, TContainerAdapter, TRootObject, TBootstrapper> :
        Attest.Testing.Integration.xUnit.IntegrationTestsBase<TContainer, TContainerAdapter, TRootObject, TBootstrapper>
        where TContainerAdapter : class, IIocContainer, IIocContainerAdapter<TContainer>
        where TRootObject : class
        where TBootstrapper : IInitializable, IHaveContainer<TContainer>, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationTestsBase{TRootObject,TBootstrapper}"/> class.
        /// </summary>
        /// <param name="keyValueDataStore">The key-value data store.</param>
        /// <param name="resolutionStyle">The resolution style.</param>
        protected IntegrationTestsBase(
            IKeyValueDataStore keyValueDataStore,
            InitializationParametersResolutionStyle resolutionStyle = InitializationParametersResolutionStyle.PerRequest)
            : base(
                keyValueDataStore,
                resolutionStyle)
        {
        }

        /// <inheritdoc />
        protected override void SetupOverride()
        {
            base.SetupOverride();
            TestHelper.Setup();
        }
    }
}