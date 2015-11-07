namespace Abp.Runtime.Security
{
    /// <summary>
    /// 用于获取ABP特定声明类型的名称。
    /// </summary>
    public static class AbpClaimTypes
    {
        /// <summary>
        /// TenantId.
        /// </summary>
        public const string TenantId = "http://www.aspnetboilerplate.com/identity/claims/tenantId";

        /// <summary>
        /// ImpersonatorUserId.
        /// </summary>
        public const string ImpersonatorUserId = "http://www.aspnetboilerplate.com/identity/claims/impersonatorUserId";

        /// <summary>
        /// ImpersonatorTenantId
        /// </summary>
        public const string ImpersonatorTenantId = "http://www.aspnetboilerplate.com/identity/claims/impersonatorTenantId";
    }
}