namespace Day6;

public class Solve
{
    public static int Part1(string input) => FindMarker(input, 4);
    public static int Part2(string input) => FindMarker(input, 14);

    private static int FindMarker(string input, int count)
    {
        var queue = new Queue<char>(input.Take(count));
        for (var i = count; i < input.Length; i++)
        {
            if (new HashSet<char>(queue).Count == count)
                return i;
            queue.Dequeue();
            queue.Enqueue(input[i]);
        }

        throw new Exception();
    }

    public static string GetTestInput() => "mjqjpqmgbljsphdztnvjfqwrcgsmlb";
}