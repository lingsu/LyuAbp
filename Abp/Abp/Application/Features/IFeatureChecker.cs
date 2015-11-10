using System.Threading.Tasks;

namespace Abp.Application.Features
{
    /// <summary>
    /// 这种接口应该被用来获得的值
    /// </summary>
    public interface IFeatureChecker
    {
        /// <summary>
        /// Gets value of a feature by it's name.
        /// This is a shortcut for <see cref="GetValueAsync(int, string)"/> that uses <see cref="IAbpSession.TenantId"/> as tenantId.
        /// So, this method should be used only if TenantId can be obtained from the session.
        /// </summary>
        /// <param name="name">Unique feature name</param>
        /// <returns>Feature's current value</returns>
        Task<string> GetValueAsync(string name);

        /// <summary>
        /// Gets value of a feature for a tenant by the feature name.
        /// </summary>
        /// <param name="tenantId">Tenant's Id</param>
        /// <param name="name">Unique feature name</param>
        /// <returns>Feature's current value</returns>
        Task<string> GetValueAsync(int tenantId, string name);
    }
}