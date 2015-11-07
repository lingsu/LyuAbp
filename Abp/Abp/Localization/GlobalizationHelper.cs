using System.Globalization;

namespace Abp.Localization
{
    public static class GlobalizationHelper
    {
        public static bool IsValidCultureCode(string cultureCode)
        {
            try
            {
                CultureInfo.GetCultureInfo(cultureCode);
                return true;
            }
            catch (CultureNotFoundException)
            {
                return false;
            }
        }
    }
}