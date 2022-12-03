namespace Day3;

public static class Solve
{
    public static long Part1(List<string> input)
    {
        return input.Select(i => i[..(i.Length / 2)].ToHashSet()
                        .Intersect(i[(i.Length / 2)..].ToHashSet()).First())
                    .Select(c => char.IsLower(c) ? c - 96 : c - 38).Sum();
    }

    public static int Part2(List<string> input)
    {
        var result = 0;
        
        for (var i = 0; i < input.Count; i += 3)
        {
            var item = input[i].Intersect(input[i + 1]).Intersect(input[i + 2]).First();
            result += char.IsLower(item) ? item - 96 : item - 38;
        }

        return result;
    }
}