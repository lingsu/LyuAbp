﻿using Abp.Application.Features;
using Abp.Localization;
using Abp.MultiTenancy;

namespace Abp.Authorization
{
    /// <summary>
    /// 此上下文用于对 <see cref="AuthorizationProvider.SetPermissions"/> 方法.
    /// </summary>
    public interface IPermissionDefinitionContext
    {
        /// <summary>
        /// Creates a new permission under this group.
        /// </summary>
        /// <param name="name">Unique name of the permission</param>
        /// <param name="displayName">Display name of the permission</param>
        /// <param name="isGrantedByDefault">Is this permission granted by default. Default value: false.</param>
        /// <param name="description">A brief description for this permission</param>
        /// <param name="multiTenancySides">Which side can use this permission</param>
        /// <param name="featureDependency">Depended feature(s) of this permission</param>
        /// <returns>New created permission</returns>
        Permission CreatePermission(
            string name,
            ILocalizableString displayName,
            bool isGrantedByDefault = false,
            ILocalizableString description = null,
            MultiTenancySides multiTenancySides = MultiTenancySides.Host | MultiTenancySides.Tenant,
            IFeatureDependency featureDependency = null
            );

        /// <summary>
        /// Gets a permission with given name or null if can not find.
        /// </summary>
        /// <param name="name">Unique name of the permission</param>
        /// <returns>Permission object or null</returns>
        Permission GetPermissionOrNull(string name);
    }
}