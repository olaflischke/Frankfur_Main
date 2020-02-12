using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParallelOps
{
    public class ParallelExceptionsSamples
    {
        public static void RunParallelWithExceptions()
        {
            ParallelOptions op = new ParallelOptions() { MaxDegreeOfParallelism = Environment.ProcessorCount };

            Parallel.Invoke(op,
                       () => MethodA(),
                      () => MethodB()
                    );
        }

        private static void MethodB()
        {
            throw new Exception("B - Exception!");
        }

        private static void MethodA()
        {
            for (int i = 0; i < 10000; i++)
            {
                Task.Delay(50);
                if (i == 501)
                {
                    throw new Exception("A - Fehler!");

                }
            }
        }
    }
}
