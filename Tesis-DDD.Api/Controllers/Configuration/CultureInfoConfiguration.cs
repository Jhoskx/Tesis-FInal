using System.Globalization;

namespace Tesis_DDD.Api.Controllers.Configuration
{
    public class CultureInfoConfiguration
    {
        public static void ConfigureCultureInfo(string name = "es-CO", string currencySymbol = "$",
          string numberDecimalSeparator = ",", string numberGroupSeparator = ".")
        {
            var cultureInfo = new CultureInfo(name);
            cultureInfo.NumberFormat.CurrencySymbol = currencySymbol;
            cultureInfo.NumberFormat.NumberDecimalSeparator = numberDecimalSeparator;
            cultureInfo.NumberFormat.NumberGroupSeparator = numberGroupSeparator;

            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
        }
    }
}
