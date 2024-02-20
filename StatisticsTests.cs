using Microsoft.VisualStudio.TestTools.UnitTesting;
using Statistics;

[TestClass]
public class StatisticsTests
{
    [TestMethod]
    public void TestMaximum()
    {
        // Arrange
        int[] numbers = { 1, 2, 3, 4, 5 };
         calculator = new StatisticsCalculator();

        // Act
        int result = calculator.Maximum(numbers);

        // Assert
        Assert.AreEqual(5, result);
    }
}