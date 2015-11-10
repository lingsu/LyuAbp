using System.Collections.Generic;
using Abp.Localization.Sources;

namespace Abp.Configuration.Startup
{
    /// <summary>
    /// 一个专用列表来存储 <see cref="ILocalizationSource"/> .
    /// </summary>
    internal class LocalizationSourceList : List<ILocalizationSource>, ILocalizationSourceList
    {
        public IList<LocalizationSourceExtensionInfo> Extensions { get; private set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public LocalizationSourceList()
        {
            Extensions = new List<LocalizationSourceExtensionInfo>();
        }
    }
}