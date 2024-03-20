public class CalculatorTests
{
    private Calculator calc;

    [SetUp]
    public void Setup()
    {
        calc = new Calculator();
    }

    [Test]
    public void Add_ReturnCorrectNumber_nUnit()
    {
        // 3A
        // Arrange
        int a = 1;
        int b = 3;
        int expected = 4;

        // Action
        int result = calc.Add(a, b);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [TestCase(1, 2, 3)]
    [TestCase(-1, 2, 1)]
    [TestCase(1, -2, -1)]
    [TestCase(-1, -2, -3)]
    public void Add_ReturnCorrectNumbers_nUnit(int a, int b, int expected)
    {
        // Action
        int result = calc.Add(a, b);

        // Assert
        Assert.AreEqual(expected, result);
    }
}