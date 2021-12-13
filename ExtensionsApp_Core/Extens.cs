using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsApp_Core
{
    public static class Extens
    {
        public static string UsdToTry(this double _money)
        {
            //dolar tl kuru
            double rate = 13;
            //hesaplama işlemi
            double result = _money * rate;
            //geriye string formatlı yazı dönüşü
            return string.Format("{0} dolar, {1} ediyor.", _money, result.ToString("C2", CultureInfo.CreateSpecificCulture("tr-TR")));
        }

        public static string GetEnumDisplayName(this Enum userType)
        {
            var type = userType.GetType().GetMember(userType.ToString()).First().GetCustomAttribute<DisplayAttribute>().Name;
            return type;
        }
    }
}
