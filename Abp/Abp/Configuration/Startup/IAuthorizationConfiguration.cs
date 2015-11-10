using Abp.Authorization;
using Abp.Collections;

namespace Abp.Configuration.Startup
{
    /// <summary>
    /// 用于配置授权制度。
    /// </summary>
    public interface IAuthorizationConfiguration
    {
        /// <summary>
        /// List of authorization providers.
        /// </summary>
        ITypeList<AuthorizationProvider> Providers { get; }
    }
}