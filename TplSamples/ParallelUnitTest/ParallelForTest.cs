using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParallelOps;
using System;

namespace ParallelUnitTest
{
    [TestClass]
    public class ParallelForTest
    {
        string path = @"C:\tmp";

        [TestMethod]
        public void GetDirectorySizeTest()
        {
            long size = ParallelForSamples.GetDirectorySize(path);

            Assert.IsTrue(size > 0);
        }

        [TestMethod]
        public void GetDirectorySizeLinqTest()
        {
            long size = ParallelForSamples.GetDirectorySizeLinq(path);

            Assert.IsTrue(size > 0);
        }

        [TestMethod]
        public void ParallelExceptionsTest()
        {
            ParallelExceptionsSamples.RunParallelWithExceptions();

            Assert.ThrowsException<AggregateException>(() => ParallelExceptionsSamples.RunParallelWithExceptions());
        }
    }
}
