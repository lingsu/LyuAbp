using Abp.Collections;

namespace Abp.Configuration.Startup
{
    /// <summary>
    /// 用于配置导航
    /// </summary>
    public interface INavigationConfiguration
    {
        /// <summary>
        /// List of navigation providers.
        /// </summary>
        ITypeList<NavigationProvider> Providers { get; }
    }
}