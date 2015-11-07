using System;
using Abp.Configuration.Startup;
using Abp.Dependency;
using Abp.Dependency.Installers;
using Abp.Modules;

namespace Abp
{
    /// <summary>
    ///这是主类，它负责启动整个ABP系统。
    ///准备依赖注入，并注册启动所需的核心部件。
    ///它必须被实例化和初始化（见<see cref="Initialize"/>）首先在应用程序中。
    /// </summary>
    public class AbpBootstrapper : IDisposable
    {
        /// <summary>
        /// Gets IIocManager object used by this class.
        /// </summary>
        public IIocManager IocManager { get; private set; }

        /// <summary>
        /// Is this object disposed before?
        /// </summary>
        protected bool IsDisposed;

        private IAbpModuleManager _moduleManager;

        /// <summary>
        /// Creates a new <see cref="AbpBootstrapper"/> instance.
        /// </summary>
        public AbpBootstrapper()
            : this(Dependency.IocManager.Instance)
        {

        }

        /// <summary>
        /// Creates a new <see cref="AbpBootstrapper"/> instance.
        /// </summary>
        /// <param name="iocManager">IIocManager that is used to bootstrap the ABP system</param>
        public AbpBootstrapper(IIocManager iocManager)
        {
            IocManager = iocManager;
        }

        /// <summary>
        /// Initializes the ABP system.
        /// </summary>
        public virtual void Initialize()
        {
            IocManager.IocContainer.Install(new AbpCoreInstaller());

            IocManager.Resolve<AbpStartupConfiguration>().Initialize();

            _moduleManager = IocManager.Resolve<IAbpModuleManager>();
            _moduleManager.InitializeModules();
        }

        /// <summary>
        /// Disposes the ABP system.
        /// </summary>
        public virtual void Dispose()
        {
            if (IsDisposed)
            {
                return;
            }

            IsDisposed = true;

            if (_moduleManager != null)
            {
                _moduleManager.ShutdownModules();
            }
        }
    }
}