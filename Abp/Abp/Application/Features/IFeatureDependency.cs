using System.Threading.Tasks;

namespace Abp.Application.Features
{
    /// <summary>
    /// 定义特征依赖.
    /// </summary>
    public interface IFeatureDependency
    {
        /// <summary>
        /// Checks depended features and returns true if dependencies are satisfied.
        /// </summary>
        Task<bool> IsSatisfiedAsync(IFeatureDependencyContext context);
    }
}