using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TradingDayDal
{
    public static class IEnumerableExtensions
    {
        public static ObservableCollection<T2> ToObservableCollection<T2>(this IEnumerable<T2> query)
        {
            return new ObservableCollection<T2>(query);
        }
    }
}
