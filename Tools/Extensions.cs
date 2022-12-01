using System;
using System.Collections.Generic;

namespace Tools;

public static class Extensions
{
    public static IEnumerable<IEnumerable<TSource>> SeparateBy<TSource>(this IEnumerable<TSource> source,
        Func<TSource, bool> predicate)
    {
        if (source == null)
            throw new ArgumentException("Collection can't be null");

        if (predicate == null)
            throw new ArgumentException("Function can't be null");

        var innerList = new List<TSource>();

        foreach (var item in source)
        {
            if (predicate(item) && innerList.Count > 0)
            {
                yield return innerList;
                innerList = new List<TSource>();
            }
            else
            {
                innerList.Add(item);
            }
        }

        if (innerList.Count > 0)
            yield return innerList;
    }
}