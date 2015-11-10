using System.Collections.Generic;

namespace Abp.Application.Navigation
{
    /// <summary>
    /// 声明通用接口的类的有菜单项。
    /// </summary>
    public interface IHasMenuItemDefinitions
    {
        /// <summary>
        /// List of menu items.
        /// </summary>
        IList<MenuItemDefinition> Items { get; }
    }
}