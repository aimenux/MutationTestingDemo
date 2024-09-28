using App;
using FluentAssertions;

namespace Tests;

public class SuperComputerTests
{
    [Theory]
    [InlineData(20.5, 20.5, 41)]
    public void Given_X_And_Y_Then_Should_Sum_Operation_Compute_Their_Addition(decimal x, decimal y, decimal expectedSum)
    {
        // arrange
        var superComputer = new SuperComputer();

        // act
        var sum = superComputer.Sum(x, y);

        // assert
        sum.Should().Be(expectedSum);
    }
    
    [Fact]
    public void Given_Largest_Numbers_Then_Sum_Should_Throw_SuperComputerException()
    {
        // arrange
        var superComputer = new SuperComputer();

        // act
        Action sumAction = () => superComputer.Sum(decimal.MaxValue, decimal.MaxValue);

        // assert
        sumAction.Should().Throw<SuperComputerException>().And.Message.Should().Be("Operation 'Sum' has failed.");
    }
    
    [Theory]
    [InlineData(20.5, 20.5, 0)]
    public void Given_X_And_Y_Then_Should_Sub_Operation_Compute_Their_Subtraction(decimal x, decimal y, decimal expectedSub)
    {
        // arrange
        var superComputer = new SuperComputer();

        // act
        var sub = superComputer.Sub(x, y);

        // assert
        sub.Should().Be(expectedSub);
    }

    [Fact]
    public void Given_Largest_Numbers_Then_Sub_Should_Throw_SuperComputerException()
    {
        // arrange
        var superComputer = new SuperComputer();

        // act
        Action subAction = () => superComputer.Sub(decimal.MaxValue, -decimal.MaxValue);

        // assert
        subAction.Should().Throw<SuperComputerException>().And.Message.Should().Be("Operation 'Sub' has failed.");
    }

    [Theory]
    [InlineData(20.5, 20.5, 420.25)]
    public void Given_X_And_Y_Then_Should_Mul_Operation_Compute_Their_Multiplication(decimal x, decimal y, decimal expectedMul)
    {
        // arrange
        var superComputer = new SuperComputer();

        // act
        var mul = superComputer.Mul(x, y);

        // assert
        mul.Should().Be(expectedMul);
    }

    [Fact]
    public void Given_Largest_Numbers_Then_Mul_Should_Throw_SuperComputerException()
    {
        // arrange
        var superComputer = new SuperComputer();

        // act
        Action mulAction = () => superComputer.Mul(decimal.MaxValue, decimal.MaxValue);

        // assert
        mulAction.Should().Throw<SuperComputerException>().And.Message.Should().Be("Operation 'Mul' has failed.");
    }

    [Theory]
    [InlineData(20.5, 20.5, 1)]
    public void Given_X_And_Y_Then_Should_Div_Operation_Compute_Their_Division(decimal x, decimal y, decimal expectedDiv)
    {
        // arrange
        var superComputer = new SuperComputer();

        // act
        var div = superComputer.Div(x, y);

        // assert
        div.Should().Be(expectedDiv);
    }

    [Fact]
    public void Given_Y_Equals_To_Zero_Then_Div_Should_Throw_SuperComputerException()
    {
        // arrange
        var superComputer = new SuperComputer();

        // act
        Action divAction = () => superComputer.Div(decimal.MaxValue, 0);

        // assert
        divAction.Should().Throw<SuperComputerException>();
    }

    [Theory]
    [InlineData(20.5, 20.1, true)]
    [InlineData(20.5, 20.5, false)]
    [InlineData(20.1, 20.5, false)]
    public void Given_X_And_Y_Then_Should_IsSuperior_Compute_Their_Superior(decimal x, decimal y, bool expectedIsSuperior)
    {
        // arrange
        var superComputer = new SuperComputer();

        // act
        var isSuperior = superComputer.IsSuperior(x, y);

        // assert
        isSuperior.Should().Be(expectedIsSuperior);
    }

    [Theory]
    [InlineData(20.1, 20.5, true)]
    [InlineData(20.5, 20.5, false)]
    [InlineData(20.5, 20.1, false)]
    public void Given_X_And_Y_Then_Should_IsInferior_Compute_Their_Inferior(decimal x, decimal y, bool expectedIsInferior)
    {
        // arrange
        var superComputer = new SuperComputer();

        // act
        var isInferior = superComputer.IsInferior(x, y);

        // assert
        isInferior.Should().Be(expectedIsInferior);
    }

    [Theory]
    [InlineData(20.5, 20.5, true)]
    [InlineData(20.1, 20.5, false)]
    [InlineData(20.5, 20.1, false)]
    public void Given_X_And_Y_Then_Should_IsEquals_Compute_Their_Equals(decimal x, decimal y, bool expectedIsEquals)
    {
        // arrange
        var superComputer = new SuperComputer();

        // act
        var isEquals = superComputer.IsEquals(x, y);

        // assert
        isEquals.Should().Be(expectedIsEquals);
    }    
}