using TollFee.ClassLibrary;
using TollFee.ClassLibrary.Vehicles;

namespace TollFee.Tests
{
    public class TollFeeCalculatorTests
    {
        [Theory]
        [InlineData("2013-01-01 06:15:00", 0)]
        [InlineData("2026-01-01 06:15:00", 8)]
        [InlineData("2026-01-01 06:45:00", 13)]
        [InlineData("2026-01-01 07:45:00", 18)]
        [InlineData("2026-01-01 08:15:00", 13)]
        [InlineData("2026-01-01 10:45:00", 8)]
        [InlineData("2026-01-01 15:15:00", 13)]
        [InlineData("2026-01-01 16:30:00", 18)]
        [InlineData("2026-01-01 17:30:00", 13)]
        [InlineData("2026-01-01 18:15:00", 8)]
        [InlineData("2026-01-01 20:00:00", 0)]
        public void GetTollFee_ForCar_ReturnCorrectTollFee(string dateTimeStr, int expectedTollFee)
        {
            // Arrange
            var dateTime = DateTime.Parse(dateTimeStr);
            var vehicle = new Car();

            // Act
            var actualTollFee = TollFeeCalculator.GetTollFee(date: dateTime, vehicle: vehicle);

            // Assert
            Assert.Equal(expectedTollFee, actualTollFee);
        }

        [Fact]
        public void GetTollFee_ForMotorbike_ReturnCorrectTollFee()
        {
            // Arrange
            var dateTime = DateTime.Now;
            var vehicle = new Motorbike();
            var expectedTollFee = 0;

            // Act
            var actualTollFee = TollFeeCalculator.GetTollFee(date: dateTime, vehicle: vehicle);

            // Assert
            Assert.Equal(expectedTollFee, actualTollFee);
        }
    }
}
