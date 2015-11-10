﻿using Abp.MultiTenancy;

namespace Abp.Runtime.Session
{
    /// <summary>
    /// 一些有用的会话信息。
    /// </summary>
    public interface IAbpSession
    {
        /// <summary>
        /// Gets current UserId or null.
        /// </summary>
        long? UserId { get; }

        /// <summary>
        /// Gets current TenantId or null.
        /// </summary>
        int? TenantId { get; }

        /// <summary>
        /// Gets current multi-tenancy side.
        /// </summary>
        MultiTenancySides MultiTenancySide { get; }

        /// <summary>
        /// UserId of the impersonator.
        /// This is filled if a user is performing actions behalf of the <see cref="UserId"/>.
        /// </summary>
        long? ImpersonatorUserId { get; }

        /// <summary>
        /// TenantId of the impersonator.
        /// This is filled if a user with <see cref="ImpersonatorUserId"/> performing actions behalf of the <see cref="UserId"/>.
        /// </summary>
        int? ImpersonatorTenantId { get; }
    }
}