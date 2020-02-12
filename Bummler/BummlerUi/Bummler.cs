using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BummlerUi
{
    public class Bummler
    {
        public string Bummeln()
        {
            double sum = Wurzelsumme(5e8);
            return "Fertig mit Bummeln";
        }

        public async Task<string> BummelnAsync()
        {
            double sum = await Task.Run(() => Wurzelsumme(5e8));
            return "Fertig mit Bummeln";
        }

        public string Troedeln()
        {
            double sum = Wurzelsumme(1e9);
            return "Fertig mit Trödeln";
        }

        public async Task<string> TroedelnAsync()
        {
            double sum = await Task.Run(() => Wurzelsumme(1e9));
            return "Fertig mit Trödeln";
        }

        private double Wurzelsumme(double max)
        {
            double result = 0;

            for (int i = 1; i <= max; i++)
            {
                result += Math.Sqrt(i);
            }

            return result;
        }
    }
}
