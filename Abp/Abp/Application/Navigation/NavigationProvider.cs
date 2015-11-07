using Abp.Dependency;

namespace Abp.Application.Navigation
{
    /// <summary>
    /// 这个接口应该由哪个类别变更实施
    /// 应用程序的导航。
    /// </summary>
    public abstract class NavigationProvider : ITransientDependency
    {
        /// <summary>
        /// Used to set navigation.
        /// </summary>
        /// <param name="context">Navigation context</param>
        public abstract void SetNavigation(INavigationProviderContext context);
    }
}