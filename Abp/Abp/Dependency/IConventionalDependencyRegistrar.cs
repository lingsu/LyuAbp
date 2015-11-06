namespace Abp.Dependency
{
    /// <summary>
    /// 约定注册依赖关系。
    /// </summary>
    /// <remarks>
    /// Implement this interface and register to <see cref="IocManager.AddConventionalRegistrar"/> method to be able
    /// to register classes by your own conventions.
    /// </remarks>
    public interface IConventionalDependencyRegistrar
    {
        /// <summary>
        /// Registers types of given assembly by convention.
        /// </summary>
        /// <param name="context">Registration context</param>
        void RegisterAssembly(IConventionalRegistrationContext context);
    }
}