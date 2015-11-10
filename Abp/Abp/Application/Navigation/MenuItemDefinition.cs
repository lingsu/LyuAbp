using System;
using System.Collections.Generic;
using Abp.Application.Features;
using Abp.Localization;
using Castle.Core.Internal;

namespace Abp.Application.Navigation
{
    /// <summary>
    /// 表示在一个项目 <see cref="MenuDefinition"/>.
    /// </summary>
    public class MenuItemDefinition : IHasMenuItemDefinitions
    {
        /// <summary>
        /// 在应用程序的菜单项的唯一的名称。
        /// 可用于找到这个菜单项。
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 菜单项的显示名称。必选。
        /// </summary>
        public ILocalizableString DisplayName { get; set; }

        /// <summary>
        /// 菜单的显示顺序。可选。
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Icon of the menu item if exists. Optional.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        ///当该菜单项中选择浏览的网址。可选。
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 一个权限名称。只有拥有该权限的用户可以看到该菜单项的用户。
        /// Optional.
        /// </summary>
        public string RequiredPermissionName { get; set; }

        /// <summary>
        /// A permission name. Only users that has this permission can see this menu item.
        /// Optional.
        /// </summary>
        public IFeatureDependency FeatureDependency { get; set; }

        /// <summary>
        /// 这可以被设置为true，如果只有经过身份验证的用户会看到该菜单项。
        /// </summary>
        public bool RequiresAuthentication { get; set; }

        /// <summary>
        /// 如果该菜单项没有子返回true <see cref="Items"/>.
        /// </summary>
        public bool IsLeaf
        {
            get { return Items.IsNullOrEmpty(); }
        }

        /// <summary>
        /// 可以用来存储与该菜单项的自定义对象。可选。
        /// </summary>
        public object CustomData { get; set; }

        /// <summary>
        /// 这个菜单项的子项。可选.
        /// </summary>
        public virtual IList<MenuItemDefinition> Items { get; private set; }

        /// <summary>
        /// Creates a new <see cref="MenuItemDefinition"/> object.
        /// </summary>
        public MenuItemDefinition(
            string name,
            ILocalizableString displayName,
            string icon = null,
            string url = null,
            bool requiresAuthentication = false,
            string requiredPermissionName = null,
            int order = 0,
            object customData = null,
            IFeatureDependency featureDependency = null)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }

            if (displayName == null)
            {
                throw new ArgumentNullException("displayName");
            }

            Name = name;
            DisplayName = displayName;
            Icon = icon;
            Url = url;
            RequiresAuthentication = requiresAuthentication;
            RequiredPermissionName = requiredPermissionName;
            Order = order;
            CustomData = customData;
            FeatureDependency = featureDependency;

            Items = new List<MenuItemDefinition>();
        }

        /// <summary>
        /// Adds a <see cref="MenuItemDefinition"/> to <see cref="Items"/>.
        /// </summary>
        /// <param name="menuItem"><see cref="MenuItemDefinition"/> to be added</param>
        /// <returns>This <see cref="MenuItemDefinition"/> object</returns>
        public MenuItemDefinition AddItem(MenuItemDefinition menuItem)
        {
            Items.Add(menuItem);
            return this;
        }
    }
}