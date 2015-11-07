namespace Abp.MultiTenancy
{
    /// <summary>
    /// 实现对空对象模式 <see cref="ITenantIdResolver"/>.
    /// </summary>
    public class NullTenantIdResolver : ITenantIdResolver
    {
        /// <summary>
        /// Singleton instance.
        /// </summary>
        public static NullTenantIdResolver Instance { get { return SingletonInstance; } }
        private static readonly NullTenantIdResolver SingletonInstance = new NullTenantIdResolver();

        public int? TenantId { get { return null; } }
    }
}