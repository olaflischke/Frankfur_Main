using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TradingDayDal;

namespace TradingDayDalUnitTest
{
    [TestClass]
    public class ArchiveUnitTest
    {
        string url = "https://www.ecb.europa.eu/stats/eurofxref/eurofxref-hist-90d.xml";

        [TestMethod]
        public void ArchiveInitTest()
        {

            Archive archive = new Archive(url);

            Assert.AreEqual(GetCubeTimeNodes(url), archive.TradingDays.Count);
        }

        private int GetCubeTimeNodes(string url)
        {
            return 61;
        }
    }
}
