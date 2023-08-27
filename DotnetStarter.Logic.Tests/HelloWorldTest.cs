using System.Collections.Generic;
using Xunit;

namespace DotnetStarter.Logic.Tests;

public class HelloWorldTest
{
    [Theory]
    [InlineData("I")]
    [InlineData("II")]
    [InlineData("III")]
    // don't pass all inputs and outputs as parameters
    // one should be fixed or calculated in the test
    // exception - if I test a hashmap
    public void Hello_ReturnsWorld3(string roman)
    {
        // if the parameterized test forces to repeat the logic from the code
        // then it's not a good test (smell)
        // gray area
        Assert.Equal(roman.Length, toArabic(roman));
    }

    // convert x to 10
    [Theory]
    [InlineData("I", 1)]
    [InlineData("V", 5)]
    [InlineData("X", 10)]
    [InlineData("L", 50)]
    [InlineData("C", 100)]
    [InlineData("D", 500)]
    [InlineData("M", 1000)]
    public void Hello_ReturnsWorld4(string roman, int expected)
    {
        Assert.Equal(expected, toArabic(roman));
    }

    private static int toArabic(string s)
    {
        var dictionary = new Dictionary<string, int>();
        return s.Length;
    }
}