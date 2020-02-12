using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BummlerUi
{
    public class StringChecker
    {
        public static bool IsNumeric(string text)
        {
            return Double.TryParse(text, out double zahl);
        }

        public static double? ToDouble(string text)
        {
            if (Double.TryParse(text, out double zahl))
            {
                return zahl;
            }

            return null;
        }
    }
}
