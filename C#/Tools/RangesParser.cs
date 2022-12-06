using System;
using System.Linq;

namespace Tools;

public static class RangesParser
{
    public static (Range range1, Range range2) Parse(string line)
    {
        var ranges = line.Split(',')
            .Select(l => l.Split('-'))
            .Select(l => new Range(int.Parse(l[0]), int.Parse(l[1])))
            .ToList();

        return (ranges[0], ranges[1]);
    }
}