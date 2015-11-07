namespace Abp.MultiTenancy
{
    /// <summary>
    ///用于获取当前租户ID。
    ///此接口可以实现获得租客的身份证，如果用户没有登录。
    ///例如它可以从子域解析TenantId
    /// </summary>
    public interface ITenantIdResolver
    {
        /// <summary>
        /// Gets current TenantId or null.
        /// </summary>
        int? TenantId { get; }
    }
}