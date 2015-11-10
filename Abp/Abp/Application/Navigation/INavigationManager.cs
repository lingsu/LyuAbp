using System.Collections.Generic;

namespace Abp.Application.Navigation
{
    /// <summary>
    /// 管理应用程序中的导航
    /// </summary>
    public interface INavigationManager
    {
        /// <summary>
        ///在应用程序中定义的所有菜单。
        /// </summary>
        IDictionary<string, MenuDefinition> Menus { get; }

        /// <summary>
        /// 获取应用程序的主菜单。
        /// <see cref="Menus"/>["MainMenu"] 的快捷方式
        /// </summary>
        MenuDefinition MainMenu { get; }
    }
}