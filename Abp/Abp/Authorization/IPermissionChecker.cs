using System.Threading.Tasks;

namespace Abp.Authorization
{
    /// <summary>
    /// 用于为用户的权限。
    /// </summary>
    public interface IPermissionChecker
    {
        /// <summary>
        /// 检查如果当前用户被授予的权限。
        /// </summary>
        /// <param name="permissionName">Name of the permission</param>
        Task<bool> IsGrantedAsync(string permissionName);

        /// <summary>
        /// 检查如果用户授予权限.
        /// </summary>
        /// <param name="userId">Id of the user to check</param>
        /// <param name="permissionName">Name of the permission</param>
        Task<bool> IsGrantedAsync(long userId, string permissionName);
    }
}