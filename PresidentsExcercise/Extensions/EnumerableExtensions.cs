using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresidentsExcercise.Extensions
{
    public static class EnumerableExtensions
    {
        public static IOrderedEnumerable<TSource> OrderByWithDirection<TSource, TKey>
            (this IEnumerable<TSource> source,
            Func<TSource, TKey> keySelector,
            bool descending)
        {
            return descending ? source.OrderByDescending(keySelector)
                              : source.OrderBy(keySelector);
        }

    }
}
