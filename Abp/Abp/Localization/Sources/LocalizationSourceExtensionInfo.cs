using Abp.Localization.Dictionaries;

namespace Abp.Localization.Sources
{
    /// <summary>
    /// 用于存储本地化源扩展信息。
    /// </summary>
    public class LocalizationSourceExtensionInfo
    {
        /// <summary>
        /// Source name.
        /// </summary>
        public string SourceName { get; private set; }

        /// <summary>
        /// 扩展字典.
        /// </summary>
        public ILocalizationDictionaryProvider DictionaryProvider { get; private set; }

        /// <summary>
        /// Creates a new <see cref="LocalizationSourceExtensionInfo"/> object.
        /// </summary>
        /// <param name="sourceName">Source name</param>
        /// <param name="dictionaryProvider">Extension dictionaries</param>
        public LocalizationSourceExtensionInfo(string sourceName, ILocalizationDictionaryProvider dictionaryProvider)
        {
            SourceName = sourceName;
            DictionaryProvider = dictionaryProvider;
        }
    }
}