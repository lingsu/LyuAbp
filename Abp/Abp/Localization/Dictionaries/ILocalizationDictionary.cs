using System.Collections.Generic;
using System.Globalization;

namespace Abp.Localization.Dictionaries
{
    /// <summary>
    /// 表示一个用来寻找一个本地化的字符串字典.
    /// </summary>
    public interface ILocalizationDictionary
    {
        /// <summary>
        /// 区域信息.
        /// </summary>
        CultureInfo CultureInfo { get; }

        /// <summary>
        /// Gets/sets a string for this dictionary with given name (key).
        /// </summary>
        /// <param name="name">Name to get/set</param>
        string this[string name] { get; set; }

        /// <summary>
        /// Gets a <see cref="LocalizedString"/> for given <paramref name="name"/>.
        /// </summary>
        /// <param name="name">Name (key) to get localized string</param>
        /// <returns>The localized string or null if not found in this dictionary</returns>
        LocalizedString GetOrNull(string name);

        /// <summary>
        /// Gets a list of all strings in this dictionary.
        /// </summary>
        /// <returns>List of all <see cref="LocalizedString"/> object</returns>
        IReadOnlyList<LocalizedString> GetAllStrings();
    }
}