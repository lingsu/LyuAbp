using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Abp.Application.Features;
using Abp.Localization;
using Abp.MultiTenancy;

namespace Abp.Authorization
{
    /// <summary>
    ///表示一个权限。
    ///权限是用来限制未经授权的用户访问应用程序的功能。
    /// </summary>
    public sealed class Permission
    {
        /// <summary>
        ///如果此权限有上级。
        ///如果设置，此权限只能被上级授予。
        /// </summary>
        public Permission Parent { get; private set; }

        /// <summary>
        ///权限的唯一名称。
        ///这是授予权限的密钥名。
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        ///权限的显示名称。
        ///这可以用来显示许可给用户。
        /// </summary>
        public ILocalizableString DisplayName { get; set; }

        /// <summary>
        ///简要说明对这一权限。
        /// </summary>
        public ILocalizableString Description { get; set; }

        /// <summary>
        ///默认情况下授予此权限。
        /// Default value: false.
        /// </summary>
        public bool IsGrantedByDefault { get; set; }

        /// <summary>
        /// 哪一方可以使用此权限。
        /// </summary>
        public MultiTenancySides MultiTenancySides { get; set; }

        /// <summary>
        /// 此权限依赖特性（S）。
        /// </summary>
        public IFeatureDependency FeatureDependency { get; set; }

        /// <summary>
        /// 子权限列表。只能被授予如果父被授予一个子权限。
        /// </summary>
        public IReadOnlyList<Permission> Children
        {
            get { return _children.ToImmutableList(); }
        }
        private readonly List<Permission> _children;

        /// <summary>
        /// Creates a new Permission.
        /// </summary>
        /// <param name="name">Unique name of the permission</param>
        /// <param name="displayName">Display name of the permission</param>
        /// <param name="isGrantedByDefault">Is this permission granted by default. Default value: false.</param>
        /// <param name="description">A brief description for this permission</param>
        /// <param name="multiTenancySides">Which side can use this permission</param>
        /// <param name="featureDependency">Depended feature(s) of this permission</param>
        public Permission(
            string name,
            ILocalizableString displayName = null,
            bool isGrantedByDefault = false,
            ILocalizableString description = null,
            MultiTenancySides multiTenancySides = MultiTenancySides.Host | MultiTenancySides.Tenant,
            IFeatureDependency featureDependency = null)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }

            Name = name;
            DisplayName = displayName;
            IsGrantedByDefault = isGrantedByDefault;
            Description = description;
            MultiTenancySides = multiTenancySides;
            FeatureDependency = featureDependency;

            _children = new List<Permission>();
        }

        /// <summary>
        ///添加一个子权限。
        ///只能被授予如果父被授予一个子权限。
        /// </summary>
        /// <returns>Returns newly created child permission</returns>
        public Permission CreateChildPermission(
            string name,
            ILocalizableString displayName = null,
            bool isGrantedByDefault = false,
            ILocalizableString description = null,
            MultiTenancySides multiTenancySides = MultiTenancySides.Host | MultiTenancySides.Tenant,
            IFeatureDependency featureDependency = null)
        {
            var permission = new Permission(name, displayName, isGrantedByDefault, description, multiTenancySides, featureDependency) { Parent = this };
            _children.Add(permission);
            return permission;
        }

        public override string ToString()
        {
            return string.Format("[Permission: {0}]", Name);
        }
    }
}