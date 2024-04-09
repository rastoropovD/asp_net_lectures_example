using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        
    }

    [Fact]
    public async Task AsyncTest()
    {
        
    }

    [Theory]
    [InlineData(0, "", 1)]
    [InlineData(2, "", 1)]
    [InlineData(4, "", 1)]
    [InlineData(5, "", 1)]
    public void TestWithParams(int num, string someText, int expectedResult)
    {
        // Arrange
        ForTests testClass = new ForTests();

        // Act
        int result = testClass.Run(num, someText);

        // Assert
        // Assert.Throws<NotImplementedException>(() => testClass.Run(num, someText));
        Assert.Equal(expectedResult, result);
    }
    
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestWithParams2(int num, string someText, int expectedResult)
    {
        // Arrange
        ForTests testClass = new ForTests();

        // Act
        int result = testClass.Run(num, someText);

        // Assert
        // Assert.Throws<NotImplementedException>(() => testClass.Run(num, someText));
        Assert.Equal(expectedResult, result);
    }


    public static IEnumerable<object[]> TestData()
    {
        yield return new object[] {1, "", 0};
        yield return new object[] {2, "", 0};
        yield return new object[] {3, "", 0};
        yield return new object[] {4, "", 0};
        yield return new object[] {5, "", 0};
        yield return new object[] {6, "", 0};
    }
}


public sealed class ForTests
{
    public int Run(int i, string data)
    {
        throw new NotImplementedException();
    }
}