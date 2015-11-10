﻿using System.Collections.Generic;

namespace Abp.Application.Navigation
{
    /// <summary>
    ///表示在一个项目 <see cref="UserMenu"/>.
    /// </summary>
    public class UserMenuItem
    {
        /// <summary>
        /// Unique name of the menu item in the application. 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Icon of the menu item if exists.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Display name of the menu item.
        /// </summary>
        public string DisplayName { get; private set; }

        /// <summary>
        /// The Display order of the menu. Optional.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// The URL to navigate when this menu item is selected.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// A custom object related to this menu item.
        /// </summary>
        public object CustomData { get; set; }

        /// <summary>
        /// Sub items of this menu item.
        /// </summary>
        public IList<UserMenuItem> Items { get; private set; }

        /// <summary>
        /// Creates a new <see cref="UserMenuItem"/> object.
        /// </summary>
        public UserMenuItem()
        {

        }

        /// <summary>
        /// Creates a new <see cref="UserMenuItem"/> object from given <see cref="MenuItemDefinition"/>.
        /// </summary>
        internal UserMenuItem(MenuItemDefinition menuItemDefinition)
        {
            Name = menuItemDefinition.Name;
            Icon = menuItemDefinition.Icon;
            DisplayName = menuItemDefinition.DisplayName.Localize();
            Order = menuItemDefinition.Order;
            Url = menuItemDefinition.Url;
            CustomData = menuItemDefinition.CustomData;
            Items = new List<UserMenuItem>();
        }
    }
}