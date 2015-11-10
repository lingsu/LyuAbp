using System;
using System.Collections.Generic;
using System.Transactions;

namespace Abp.Domain.Uow
{
    /// <summary>
    /// 用于获取/设置工作单元默认选项
    /// </summary>
    public interface IUnitOfWorkDefaultOptions
    {
        /// <summary>
        /// 作用域选项
        /// </summary>
        TransactionScopeOption Scope { get; set; }

        /// <summary>
        /// 如果工作单元是事务性的。
        /// Default: true.
        /// </summary>
        bool IsTransactional { get; set; }

        /// <summary>
        /// 获取/设置为工作单元的超时值。
        /// </summary>
        TimeSpan? Timeout { get; set; }

        /// <summary>
        /// 获取/设置事务隔离级别。
        /// This is used if <see cref="IsTransactional"/> is true.
        /// </summary>
        IsolationLevel? IsolationLevel { get; set; }

        /// <summary>
        /// 获取所有数据过滤器配置的列表。
        /// </summary>
        IReadOnlyList<DataFilterConfiguration> Filters { get; }

        /// <summary>
        /// 注册一个数据过滤器到工作单元系统。
        /// </summary>
        /// <param name="filterName">Name of the filter.</param>
        /// <param name="isEnabledByDefault">Is filter enabled by default.</param>
        void RegisterFilter(string filterName, bool isEnabledByDefault);

        /// <summary>
        /// 覆盖数据过滤器定义。
        /// </summary>
        /// <param name="filterName">Name of the filter.</param>
        /// <param name="isEnabledByDefault">Is filter enabled by default.</param>
        void OverrideFilter(string filterName, bool isEnabledByDefault);
    }
}