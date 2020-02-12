using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Linq;

using Microsoft.Office.Interop.Excel;

namespace TradingDayDal
{
    public class Archive
    {
        public Archive(string url)
        {
            this.TradingDays = GetData(url);
        }

        private IEnumerable<TradingDay> ReadXml(IEnumerable<XElement> elements, string attributeName)
        {
            //foreach (var item in elements)
            //{
            //    Debug.WriteLine(item.Name.LocalName);
            //}

            var qCubes = from xe in elements
                         where xe.Name.LocalName == "Cube" && xe.Attributes().Any(at => at.Name == attributeName)                            // Projektion
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

            return qCubes;
        }

        private List<TradingDay> GetData(string url)
        {
            List<TradingDay> list = new List<TradingDay>();

            try
            {
                XDocument document = XDocument.Load(url);

                var elements = document.Root.Descendants();

                string attTimeName = "time";

                IEnumerable<TradingDay> qCubes = ReadXml(elements, attTimeName);

                IEnumerable<TradingDay> qCubes2 = ReadXml(elements, "test");

                //var qCubes = from xe in document?.Root.Descendants().AsParallel()
                //             where xe.Name.LocalName == "Cube" && xe.Attributes().Any(at => at.Name == attTimeName)                            // Projektion
                //             select new TradingDay()
                //             {
                //                 Date = Convert.ToDateTime(xe.Attribute("time").Value),
                //                 Currencies = xe.Descendants().Select(cu => new Currency()
                //                 {
                //                     Rate = Convert.ToDouble(cu.Attribute("rate").Value, new NumberFormatInfo()
                //                     {
                //                         NumberDecimalSeparator = "."
                //                     }),
                //                     Symbol = cu.Attribute("currency").Value
                //                 }).ToList()
                //             };

                //var qCubesMeth = document?.Root.Descendants().AsParallel()
                //                        .Where(xe => xe.Name.LocalName == "Cube"
                //                            && xe.Attributes().Any(at =>
                //                            {
                //                                if (at.Name == "time")
                //                                {
                //                                    return true;
                //                                }
                //                                return false;
                //                            }))
                //                        .Select(xe => new TradingDay()
                //                        {
                //                            Date = Convert.ToDateTime(xe.Attribute("time").Value)
                //                        });

                ////foreach (var item in qCubes)
                ////{
                ////    TradingDay day = new TradingDay()
                ////    {
                ////        Date = Convert.ToDateTime(item.Attribute("time").Value)
                ////    };
                ////    list.Add(day);
                ////}
                ///

                var days = from td in qCubes
                           select td.Date;

                attTimeName = "Banane";
                elements.First().Add(new XAttribute("Wert", "42"));

                foreach (var item in qCubes)
                {
                    Debug.WriteLine(item.Date);
                }


                list = qCubes.ToList();

                ObservableCollection<TradingDay> list2 = qCubes2.ToObservableCollection();  // new ObservableCollection<TradingDay>(qCubes2);//.ToList();

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
