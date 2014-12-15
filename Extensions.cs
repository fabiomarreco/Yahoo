using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yahoo
{
    public static class Extensions
    {
        public static T Fold<T>(this IEnumerable<T> source, Func<T, int, T> fnAggregate)
        {
            int indice = 0;
            T result = source.FirstOrDefault();

            foreach (T obj in source.Skip(1))
                result = fnAggregate(result, indice++);
            return result;
        }

    }
}
