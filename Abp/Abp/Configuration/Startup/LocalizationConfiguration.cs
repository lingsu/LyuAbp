﻿using System.Collections.Generic;
using Abp.Localization;

namespace Abp.Configuration.Startup
{
    /// <summary>
    /// 用于本地化配置。
    /// </summary>
    internal class LocalizationConfiguration : ILocalizationConfiguration
    {
        /// <inheritdoc/>
        public IList<LanguageInfo> Languages { get; private set; }

        /// <inheritdoc/>
        public ILocalizationSourceList Sources { get; private set; }

        /// <inheritdoc/>
        public bool IsEnabled { get; set; }

        /// <inheritdoc/>
        public bool ReturnGivenTextIfNotFound { get; set; }

        /// <inheritdoc/>
        public bool WrapGivenTextIfNotFound { get; set; }

        public LocalizationConfiguration()
        {
            Languages = new List<LanguageInfo>();
            Sources = new LocalizationSourceList();

            IsEnabled = true;
            ReturnGivenTextIfNotFound = true;
            WrapGivenTextIfNotFound = true;
        }
    }
}