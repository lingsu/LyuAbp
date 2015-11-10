using Abp.Dependency;

namespace Abp.Authorization
{
    /// <summary>
    ///定义应用程序的权限。
    ///实现它来定义你的模块权限。
    /// </summary>
    public abstract class AuthorizationProvider : ITransientDependency
    {
        /// <summary>
        /// 在应用程序启动时会调用此方法一次，允许定义权限。
        /// </summary>
        /// <param name="context">Permission definition context</param>
        public abstract void SetPermissions(IPermissionDefinitionContext context);
    }
}