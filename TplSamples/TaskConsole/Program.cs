using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            double max = 1e9;

            Task<double> t1 = new Task<double>(() => Wurzelsumme(max, cancellationTokenSource), cancellationTokenSource.Token);

            Console.WriteLine($"Task T1: {t1.Status}");

            t1.Start();
            Console.WriteLine($"Task T1: {t1.Status}");

            Thread.Sleep(100);
            cancellationTokenSource.Cancel();

            t1.Wait();
            Console.WriteLine($"Task T1: {t1.Status}");

            double result = t1.Result;
            Console.WriteLine($"Task T1: {result}");

            Console.ReadKey();
        }

        private static double Wurzelsumme(double max, CancellationTokenSource cts)
        {
            double result = 0;
            try
            {

                for (int i = 1; i <= max; i++)
                {
                    result += Math.Sqrt(i);
                    if (cts.IsCancellationRequested)
                    {
                        return result;
                    }
                }

                return result;

            }
            catch (TaskCanceledException ex)
            {
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

    }
}
