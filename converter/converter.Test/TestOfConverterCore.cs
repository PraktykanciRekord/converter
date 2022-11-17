using converter.Core;
namespace converter.Test
{
    public class TestOfConverterCore
    {
        [Theory]
        //weight units
        //t
        [InlineData("t", "t", 1, 1)]
        [InlineData("t", "kg", 1, 1_000)]
        [InlineData("t", "g", 1, 1_000_000)]
        [InlineData("t", "mg", 1, 1_000_000_000)]

        //kg
        [InlineData("kg", "t", 1, 0.001)]
        [InlineData("kg", "kg", 1, 1)]
        [InlineData("kg", "g", 1, 1_000)]
        [InlineData("kg", "mg", 1, 1_000_000)]

        //g
        [InlineData("g", "t", 1, 0.000_001)]
        [InlineData("g", "kg", 1, 0.001)]
        [InlineData("g", "g", 1, 1)]
        [InlineData("g", "mg", 1, 1_000)]
        
        //mg
        [InlineData("mg", "t", 1, 0.000_000_001)]
        [InlineData("mg", "kg", 1, 0.000_001)]
        [InlineData("mg", "g", 1, 0.001)]
        [InlineData("mg", "mg", 1, 1)]

        [InlineData("mg", "mg", -2, -2)]

        //distance units
        //km
        [InlineData("km", "km", 1, 1)]
        [InlineData("km", "m", 1, 1_000)]
        [InlineData("km", "cm", 1, 100_000)]
        [InlineData("km", "mm", 1, 1_000_000)]

        //m
        [InlineData("m", "km", 1, 0.001)]
        [InlineData("m", "m", 1, 1)]
        [InlineData("m", "cm", 1, 100)]
        [InlineData("m", "mm", 1, 10_000)]

        //cm
        [InlineData("cm", "km", 1, 0.00_001)]
        [InlineData("cm", "m", 1, 0.01)]
        [InlineData("cm", "cm", 1, 1)]
        [InlineData("cm", "mm", 1, 10)]

        //mm
        [InlineData("mm", "km", 1, 0.000_001)]
        [InlineData("mm", "m", 1, 0.001)]
        [InlineData("mm", "cm", 1, 0.1)]
        [InlineData("mm", "mm", 1, 1)]

        [InlineData("mm", "mm", -2, -2)]

        public void ShouldConvertUnits(string from_unit, string to_unit, double value, double expected_value)
        {
            // arrange
            Converter converter = new();

            // act
            var result = converter.Convert(from_unit, to_unit, value);

            // assert
            Assert.Equal(expected_value, result);
        }

    }
}