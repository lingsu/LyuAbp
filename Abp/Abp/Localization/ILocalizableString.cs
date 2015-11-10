using System.Globalization;

namespace Abp.Localization
{
    /// <summary>
    ///表示可在需要时被本地化字符串。
    /// </summary>
    public interface ILocalizableString
    {
        /// <summary>
        /// Localizes the string in current culture.
        /// </summary>
        /// <returns>Localized string</returns>
        string Localize();

        /// <summary>
        /// Localizes the string in given culture.
        /// </summary>
        /// <param name="culture">culture</param>
        /// <returns>Localized string</returns>
        string Localize(CultureInfo culture);
    }
}