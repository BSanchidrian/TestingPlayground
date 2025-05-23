using FluentAssertions;

namespace UnitTests;

public class CalculatorTests
{
    [Fact]
    public void Add_SomeNumbers_ShouldWork()
    {
        int[] numbers = [1, 2, 10];
        var calculator = new Calculator();

        var result = calculator.Add(numbers);

        result.Should().Be(numbers.Sum());
    }
}