using System;
using System.Globalization;

namespace Helpers
{
    public static class DateHelpers
    {
        public static string ConvertDateToGovukDate(string unformattedDate)
        {
            var formattedDate = DateTime.Parse(unformattedDate.ToString(CultureInfo.DefaultThreadCurrentUICulture));
            
            return formattedDate.ToString("dd MMMM yyyy");
        }
    }
}