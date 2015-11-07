using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Compilation;
using Abp.Reflection;

namespace Abp.Web
{
    /// <summary>
    /// 该类用于获取Web应用程序的bin文件夹中的所有程序集
    /// </summary>
    public class WebAssemblyFinder : IAssemblyFinder
    {
        /// <summary>
        /// The search option used to find assemblies in bin folder.
        /// </summary>
        public static SearchOption FindAssembliesSearchOption = SearchOption.TopDirectoryOnly;

        /// <summary>
        /// This return all assemblies in bin folder of the web application.
        /// </summary>
        /// <returns>List of assemblies</returns>
        public List<Assembly> GetAllAssemblies()
        {
            var assembliesInBinFolder = new List<Assembly>();

            var allReferencedAssemblies = BuildManager.GetReferencedAssemblies().Cast<Assembly>().ToList();
            var dllFiles = Directory.GetFiles(HttpRuntime.AppDomainAppPath + "bin\\", "*.dll", FindAssembliesSearchOption).ToList();

            foreach (string dllFile in dllFiles)
            {
                var locatedAssembly = allReferencedAssemblies.FirstOrDefault(asm => AssemblyName.ReferenceMatchesDefinition(asm.GetName(), AssemblyName.GetAssemblyName(dllFile)));
                if (locatedAssembly != null)
                {
                    assembliesInBinFolder.Add(locatedAssembly);
                }
            }

            return assembliesInBinFolder;
        }
    }
}