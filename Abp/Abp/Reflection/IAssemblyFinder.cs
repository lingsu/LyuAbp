using System.Collections.Generic;
using System.Reflection;

namespace Abp.Reflection
{
    /// <summary>
    /// 该接口用于获取所有组件
    /// 如ABP模块
    /// </summary>
    public interface IAssemblyFinder
    {
        /// <summary>
        /// This method should return all assemblies used by application.
        /// </summary>
        /// <returns>List of assemblies</returns>
        List<Assembly> GetAllAssemblies();
    }
}