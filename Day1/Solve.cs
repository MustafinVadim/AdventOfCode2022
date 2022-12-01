using Tools;

namespace Day1;

public static class Solve
{
    public static int Part1(IEnumerable<string> input)
    {
        return input.SeparateBy(x => x == "")
            .Select(x => x.Select(int.Parse).Sum())
            .Max();
    }

    public static int Part2(IEnumerable<string> input)
    {
        return input.SeparateBy(x => x == "")
            .Select(x => x.Select(int.Parse).Sum())
            .OrderByDescending(x => x)
            .Take(3)
            .Sum();
    }
}