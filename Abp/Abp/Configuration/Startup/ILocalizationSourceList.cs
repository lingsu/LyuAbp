using System.Collections.Generic;
using Abp.Localization.Sources;

namespace Abp.Configuration.Startup
{
    /// <summary>
    ///定义一个专门列表来存储 <see cref="ILocalizationSource"/> 对象.
    /// </summary>
    public interface ILocalizationSourceList : IList<ILocalizationSource>
    {
        /// <summary>
        /// Extensions for dictionay based localization sources.
        /// </summary>
        IList<LocalizationSourceExtensionInfo> Extensions { get; }
    }
}