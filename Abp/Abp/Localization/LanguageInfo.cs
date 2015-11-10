namespace Abp.Localization
{
    /// <summary>
    /// 代表可用语言。
    /// </summary>
    public class LanguageInfo
    {
        /// <summary>
        ///语言的代号。
        ///它应该是有效的文化代码。
        /// Ex: "en-US" for American English, "tr-TR" for Turkey Turkish.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 语言显示名称。
        /// Ex: "English" for English
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// An icon can be set to display on the UI.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 这是默认的语言?
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Creates a new <see cref="LanguageInfo"/> object.
        /// </summary>
        /// <param name="name">
        /// Code name of the language.
        /// It should be valid culture code.
        /// Ex: "en-US" for American English, "tr-TR" for Turkey Turkish.
        /// </param>
        /// <param name="displayName">
        /// Display name of the language in it's original language.
        /// Ex: "English" for English, "T黵k鏴" for Turkish.
        /// </param>
        /// <param name="icon">An icon can be set to display on the UI</param>
        /// <param name="isDefault">Is this the default language?</param>
        public LanguageInfo(string name, string displayName, string icon = null, bool isDefault = false)
        {
            Name = name;
            DisplayName = displayName;
            Icon = icon;
            IsDefault = isDefault;
        }
    }
}