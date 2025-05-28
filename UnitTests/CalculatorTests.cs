using FluentAssertions;

namespace UnitTests;

public class CalculatorTests
{
    [Fact]
    public void Add_SomeNumbers_ShouldWork()
    {
        int[] numbers = [1, 2, 12];
        var calculator = new Calculator();

        var result = calculator.Add(numbers);

        result.Should().Be(numbers.Sum());
    }

    [Fact]
    public void Add_SomeNumbers_ShouldWork2()
    {
        int[] numbers = [1, 2, 11, 10];
        var calculator = new Calculator();

        var result = calculator.Add(numbers);

        result.Should().Be(numbers.Sum());
    }
}