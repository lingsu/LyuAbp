using System;

namespace Abp.MultiTenancy
{
    /// <summary>
    /// 表示在多租户应用程序方面。
    /// </summary>
    [Flags]
    public enum MultiTenancySides
    {
        /// <summary>
        /// 租户方.
        /// </summary>
        Tenant = 1,

        /// <summary>
        /// 主机（租赁所有者）的一面。
        /// </summary>
        Host = 2
    }
}