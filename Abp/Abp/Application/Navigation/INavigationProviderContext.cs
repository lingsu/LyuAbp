namespace Abp.Application.Navigation
{
    /// <summary>
    /// 提供基础设施，设置导航。
    /// </summary>
    public interface INavigationProviderContext
    {
        /// <summary>
        /// Gets a reference to the menu manager.
        /// </summary>
        INavigationManager Manager { get; }
    }
}