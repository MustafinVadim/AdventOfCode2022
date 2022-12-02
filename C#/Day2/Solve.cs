namespace Day2;

public static class Solve
{
    public static int Part1(List<string> input)
    {
        return input.Select(i => CalculateRound(i.Split(' ')[0][0], i.Split(' ')[1][0])).Sum();
    }

    public static int Part2(List<string> input)
    {
        return input.Select(i => Change(i.Split(' ')[0][0], i.Split(' ')[1][0]))
            .Select(i => CalculateRound(i.a, i.b))
            .Sum();
    }

    private static (char a, char b) Change(char a, char b)
    {
        var result = (a, b) switch
        {
            ('A', 'X') => (a, 'Z'),
            ('C', 'X') => (a, 'Y'),
            ('A', 'Y') => (a, 'X'),
            ('C', 'Y') => (a, 'Z'),
            ('A', 'Z') => (a, 'Y'),
            ('C', 'Z') => (a, 'X'),
            _ => (a, b)
        };
        return result;
    }

    private static int CalculateRound(char a, char b)
    {
        var matchResult = (a, b) switch
        {
            ('A', 'X') or ('B', 'Y') or ('C', 'Z') => 3,
            ('A', 'Y') or ('B', 'Z') or ('C', 'X') => 6,
            ('A', 'Z') or ('B', 'X') or ('C', 'Y') => 0
        };

        var selectResult = b switch
        {
            'X' => 1,
            'Y' => 2,
            'Z' => 3
        };

        return matchResult + selectResult;
    }
}