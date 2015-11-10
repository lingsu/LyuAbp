using System;
using System.Collections.Generic;
using Abp.Localization;

namespace Abp.Application.Navigation
{
    /// <summary>
    /// 应用程序的导航菜单。
    /// </summary>
    public class MenuDefinition : IHasMenuItemDefinitions
    {
        /// <summary>
        /// 在应用程序的菜单的唯一名称。必需的.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 菜单的显示名称。必需的.
        /// </summary>
        public ILocalizableString DisplayName { get; set; }

        /// <summary>
        /// 可以用来存储与该菜单自定义对象。可选.
        /// </summary>
        public object CustomData { get; set; }

        /// <summary>
        ///菜单项 (第一级).
        /// </summary>
        public IList<MenuItemDefinition> Items { get; set; }

        /// <summary>
        /// Creates a new <see cref="MenuDefinition"/> object.
        /// </summary>
        /// <param name="name">Unique name of the menu</param>
        /// <param name="displayName">Display name of the menu</param>
        /// <param name="customData">Can be used to store a custom object related to this menu.</param>
        public MenuDefinition(string name, ILocalizableString displayName, object customData = null)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name", "Menu name can not be empty or null.");
            }

            if (displayName == null)
            {
                throw new ArgumentNullException("displayName", "Display name of the menu can not be null.");
            }

            Name = name;
            DisplayName = displayName;
            CustomData = customData;

            Items = new List<MenuItemDefinition>();
        }

        /// <summary>
        /// Adds a <see cref="MenuItemDefinition"/> to <see cref="Items"/>.
        /// </summary>
        /// <param name="menuItem"><see cref="MenuItemDefinition"/> to be added</param>
        /// <returns>This <see cref="MenuDefinition"/> object</returns>
        public MenuDefinition AddItem(MenuItemDefinition menuItem)
        {
            Items.Add(menuItem);
            return this;
        }
    }
}