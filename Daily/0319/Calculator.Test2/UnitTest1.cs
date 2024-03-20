public class CalculatorTests2
{
    private Calculator calc;

    public CalculatorTests2() {
        calc = new();
    }

    [Fact]
    public void Add_ReturnCorrectNumber_xUnit()
    {
        int a = 1;
        int b = 3;
        int expected = 4;

        int result = calc.Add(a, b);

        Assert.Equal(expected, result);
    }


    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(-1, 2, 1)]
    [InlineData(1, -2, -1)]
    [InlineData(-1, -2, -3)]
    public void Add_ReturnCorrectNumbers_xUnit(int a, int b, int expected) {
        int result = calc.Add(a, b);

        Assert.Equal(expected, result);
    }
}