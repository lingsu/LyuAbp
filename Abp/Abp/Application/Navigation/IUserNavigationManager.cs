using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abp.Application.Navigation
{
    /// <summary>
    /// 用户用于管理导航.
    /// </summary>
    public interface IUserNavigationManager
    {
        /// <summary>
        /// Gets a menu specialized for given user.获取一个专门为特定用户菜单
        /// </summary>
        /// <param name="menuName">Unique name of the menu</param>
        /// <param name="userId">User id or null for anonymous users</param>
        Task<UserMenu> GetMenuAsync(string menuName, long? userId);

        /// <summary>
        ///获取所有菜单专门用于给用户.
        /// </summary>
        /// <param name="userId">User id or null for anonymous users</param>
        Task<IReadOnlyList<UserMenu>> GetMenusAsync(long? userId);
    }
}