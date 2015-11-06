using Castle.DynamicProxy;

namespace Abp.Dependency
{
    /// <summary>
    /// 这个类是用来传递配置/选项，同时注册类常规的方式。
    /// </summary>
    public class ConventionalRegistrationConfig : DictionayBasedConfig
    {
        /// <summary>
        /// Install all <see cref="IInterceptor"/> implementations automatically or not.
        /// Default: true. 
        /// </summary>
        public bool InstallInstallers { get; set; }

        /// <summary>
        /// Creates a new <see cref="ConventionalRegistrationConfig"/> object.
        /// </summary>
        public ConventionalRegistrationConfig()
        {
            InstallInstallers = true;
        }
    }
}