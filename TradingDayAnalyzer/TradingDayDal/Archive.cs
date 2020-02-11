using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace TradingDayDal
{
    public class Archive
    {
        public Archive(string url)
        {
            this.TradingDays = GetData(url);
        }

        private List<TradingDay> GetData(string url)
        {
            List<TradingDay> list = new List<TradingDay>();

            try
            {
                XDocument document = XDocument.Load(url);

                var qCubes = from xe in document?.Root.Descendants().AsParallel()
                             where xe.Name.LocalName == "Cube" && xe.Attributes().Any(at => at.Name == "time")                            // Projektion
                             select new TradingDay()
                             {
                                 Date = Convert.ToDateTime(xe.Attribute("time").Value),
                                 Currencies = xe.Descendants().Select(cu => new Currency()
                                 {
                                     Rate = Convert.ToDouble(cu.Attribute("rate").Value, new NumberFormatInfo()
                                     {
                                         NumberDecimalSeparator = "."
                                     }),
                                     Symbol = cu.Attribute("currency").Value
                                 }).ToList()
                             };

                var qCubesMeth = document?.Root.Descendants().AsParallel()
                                        .Where(xe => xe.Name.LocalName == "Cube"
                                            && xe.Attributes().Any(at =>
                                            {
                                                if (at.Name == "time")
                                                {
                                                    return true;
                                                }
                                                return false;
                                            }))
                                        .Select(xe => new TradingDay()
                                        {
                                            Date = Convert.ToDateTime(xe.Attribute("time").Value)
                                        });

                //foreach (var item in qCubes)
                //{
                //    TradingDay day = new TradingDay()
                //    {
                //        Date = Convert.ToDateTime(item.Attribute("time").Value)
                //    };
                //    list.Add(day);
                //}

                list = qCubes.ToList();

                return list;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool HasName(XAttribute attribute, string name)
        {
            if (attribute.Name == name) return true;
            return false;
        }

        public List<TradingDay> TradingDays { get; set; }


    }
}
