using System;
using Castle.Core.Internal;

namespace Abp.Application.Navigation
{
    /// <summary>
    ///定义扩展方法 <see cref="IHasMenuItemDefinitions"/>.
    /// </summary>
    public static class HasMenuItemDefinitionsExtensions
    {
        /// <summary>
        ///通过唯一名字搜索并得到 <see cref="MenuItemDefinition"/> 
        ///如果不能找到，抛出异常。
        /// </summary>
        /// <param name="source">来源对象</param>
        /// <param name="name">Unique name of the source</param>
        public static MenuItemDefinition GetItemByName(this IHasMenuItemDefinitions source, string name)
        {
            var item = GetItemByNameOrNull(source, name);
            if (item == null)
            {
                throw new ArgumentException("There is no source item with given name: " + name, "name");
            }

            return item;
        }

        /// <summary>
        /// 通过唯一名字搜索所有菜单项（递归）在源代码中得到一个 <see cref="MenuItemDefinition"/> .
        /// 如果不能找到，返回空值
        /// </summary>
        /// <param name="source">来源对象</param>
        /// <param name="name">Unique name of the source</param>
        public static MenuItemDefinition GetItemByNameOrNull(this IHasMenuItemDefinitions source, string name)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            if (source.Items.IsNullOrEmpty())
            {
                return null;
            }

            foreach (var subItem in source.Items)
            {
                if (subItem.Name == name)
                {
                    return subItem;
                }

                var subItemSearchResult = GetItemByNameOrNull(subItem, name);
                if (subItemSearchResult != null)
                {
                    return subItemSearchResult;
                }
            }

            return null;
        }
    }
}