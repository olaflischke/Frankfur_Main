using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelOps
{
    public class ParallelForSamples
    {
        public static long GetDirectorySize(string path)
        {
            if (!Directory.Exists(path)) throw new FileNotFoundException($"{path} not existing.");

            long totalSize = 0;

            String[] files = Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories).ToArray();

            // for (int i = 0; i < length; i++)

            Parallel.For(0, files.Length,
                         i =>
                         {
                             FileInfo fi = new FileInfo(files[i]);
                             long size = fi.Length;
                             Interlocked.Add(ref totalSize, size);
                         });

            return totalSize;
        }

        public static long GetDirectorySizeLinq(string path)
        {
            if (!Directory.Exists(path)) throw new FileNotFoundException($"{path} not existing.");

            long totalSize = 0;

            IEnumerable<string> files = Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories);

            // foreach (var curFile in files)
            Parallel.ForEach(files, curFile =>
                        {
                            FileInfo fi = new FileInfo(curFile);
                            long size = fi.Length;
                            Interlocked.Add(ref totalSize, size);
                        });

            return totalSize;
        }

    }

    public struct SampleData
    {
        public double d1;
        public double d2;
    }

    public class AggregationSample
    {
        static object aggLock = new object();

        public static SampleData Calculate()
        {
            SampleData sum = new SampleData();

            Parallel.For(0, 100000000,
              () => new SampleData(),
              (i, loopState, taskData) =>
              {
                  taskData.d1 += Math.Sqrt(i);
                  taskData.d2 += Math.Tan(i);
                  return taskData;
              },
              (partData) =>
              {
                  lock (aggLock)
                  {
                      sum.d1 += partData.d1;
                      sum.d2 += partData.d2;
                  }
              });

            return sum;
        }
    }

}
