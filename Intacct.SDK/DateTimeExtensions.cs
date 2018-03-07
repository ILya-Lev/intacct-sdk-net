using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Intacct.SDK
{
    public static class DateTimeExtensions
    {
	    public static string ToStringByInvariantCulture(this DateTime dt, string format)
	    {
		    return dt.ToString(format, CultureInfo.InvariantCulture);
	    }

	    public static string ToStringByInvariantCulture(this DateTime? dt, string format)
	    {
		    return dt?.ToString(format, CultureInfo.InvariantCulture);
	    }
    }
}
