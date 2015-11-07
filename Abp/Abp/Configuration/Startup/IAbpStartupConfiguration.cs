using Abp.Dependency;

namespace Abp.Configuration.Startup
{
    /// <summary>
    ///用于在启动时配置ABP和模块。
    /// </summary>
    public interface IAbpStartupConfiguration : IDictionaryBasedConfig
    {
        /// <summary>
        /// Gets the IOC manager associated with this configuration.
        /// </summary>
        IIocManager IocManager { get; }

        ///// <summary>
        ///// Used to set localization configuration.
        ///// </summary>
        //ILocalizationConfiguration Localization { get; }

        ///// <summary>
        ///// Used to configure navigation.
        ///// </summary>
        //INavigationConfiguration Navigation { get; }

        ///// <summary>
        ///// Used to configure <see cref="IEventBus"/>.
        ///// </summary>
        //IEventBusConfiguration EventBus { get; }

        ///// <summary>
        ///// Used to configure auditing.
        ///// </summary>
        //IAuditingConfiguration Auditing { get; }

        ///// <summary>
        ///// Used to configure caching.
        ///// </summary>
        //ICachingConfiguration Caching { get; }

        ///// <summary>
        ///// Used to configure multi-tenancy.
        ///// </summary>
        //IMultiTenancyConfig MultiTenancy { get; }

        ///// <summary>
        ///// Used to configure authorization.
        ///// </summary>
        //IAuthorizationConfiguration Authorization { get; }

        ///// <summary>
        ///// Used to configure settings.
        ///// </summary>
        //ISettingsConfiguration Settings { get; }

        /// <summary>
        /// Gets/sets default connection string used by ORM module.
        /// It can be name of a connection string in application's config file or can be full connection string.
        /// </summary>
        string DefaultNameOrConnectionString { get; set; }

        ///// <summary>
        ///// Used to configure modules.
        ///// Modules can write extension methods to <see cref="IModuleConfigurations"/> to add module specific configurations.
        ///// </summary>
        //IModuleConfigurations Modules { get; }

        ///// <summary>
        ///// Used to configure unit of work defaults.
        ///// </summary>
        //IUnitOfWorkDefaultOptions UnitOfWork { get; }

        ///// <summary>
        ///// Used to configure features.
        ///// </summary>
        //IFeatureConfiguration Features { get; }
    }
}