using Tools;

namespace Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SeparatorTest()
    {
        var input = new List<string> {"1", "2", "", "3", "4", "", "5"};
        var result = input.SeparateBy(x => x == "").ToList();
        Assert.That(result, Has.Count.EqualTo(3));
    }
    
    [Test]
    public void SeparatorTest2()
    {
        var input = new List<string> {"", "3", "4", "", "", "5", ""};
        var result = input.SeparateBy(x => x == "").ToList();
        Assert.That(result, Has.Count.EqualTo(2));
    }
}