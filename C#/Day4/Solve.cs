namespace Day4;

public static class Solve
{
    public static int Part1(List<string> input)
    {
        return input.Select(Parse).Count(i => IsInside(i.range1, i.range2));
    }

    public static int Part2(List<string> input)
    {
        return input.Select(Parse).Count(i => IsBetween(i.range1, i.range2) || IsBetween(i.range2, i.range1));
    }

    private static (Range range1, Range range2) Parse(string line)
    {
        var ranges = line.Split(',')
            .Select(l => l.Split('-'))
            .Select(l => new Range(int.Parse(l[0]), int.Parse(l[1])))
            .ToList();

        return (ranges[0], ranges[1]);
    }

    private static bool IsInside(Range range1, Range range2)
    {
        if (range1.Start.Value >= range2.Start.Value && range1.End.Value <= range2.End.Value)
            return true;

        if (range1.Start.Value <= range2.Start.Value && range1.End.Value >= range2.End.Value)
            return true;

        return false;
    }

    private static bool IsBetween(Range range1, Range range2)
    {
        return range1.Start.Value >= range2.Start.Value && range1.Start.Value <= range2.End.Value;
    }
}