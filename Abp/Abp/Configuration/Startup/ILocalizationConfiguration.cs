using System.Collections.Generic;
using Abp.Localization;

namespace Abp.Configuration.Startup
{
    /// <summary>
    /// 用于本地化配置。
    /// </summary>
    public interface ILocalizationConfiguration
    {
        /// <summary>
        /// 用于设置可用于该应用程序的语言。
        /// </summary>
        IList<LanguageInfo> Languages { get; }

        /// <summary>
        /// 本地化源列表
        /// </summary>
        ILocalizationSourceList Sources { get; }

        /// <summary>
        ///用于启用/禁用本地化系统。
        /// Default: true.
        /// </summary>
        bool IsEnabled { get; set; }

        /// <summary>
        ///如果设置为true，给定的文本（名称）返回
        ///如果不能在本地化源中找到。防止异常，如果
        ///给定的名称没有在本地化来源限定。
        ///也写一个警告日志。
        ///默认值：true。
        /// </summary>
        bool ReturnGivenTextIfNotFound { get; set; }

        /// <summary>
        /// It returns the given text by wrapping with [ and ] chars
        /// if not found in the localization source.
        /// This is considered only if <see cref="ReturnGivenTextIfNotFound"/> is true.
        /// Default: true.
        /// </summary>
        bool WrapGivenTextIfNotFound { get; set; }
    }
}