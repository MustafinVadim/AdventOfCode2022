using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace Tools;

public static class Data
{
	public static IEnumerable<string> GetInput(int day)
	{
		using var client = new HttpClient();
		client.DefaultRequestHeaders.Add("cookie", "session=");
		var stream = client.GetStreamAsync($"https://adventofcode.com/2022/day/{day}/input").Result;
		var reader = new StreamReader(stream);
		while (reader.ReadLine() is { } line)
			yield return line;
	}
}