using converter.Core;
namespace converter.Test
{
    public class TestOfConverterCore
    {
        [Theory]
        //weight units
        //t
        [InlineData("t", "t", "weight", 1, 1)]
        [InlineData("t", "kg", "weight", 1, 1_000)]
        [InlineData("t", "g", "weight", 1, 1_000_000)]
        [InlineData("t", "mg", "weight", 1, 1_000_000_000)]

        //kg
        [InlineData("kg", "t", "weight", 1, 0.001)]
        [InlineData("kg", "kg", "weight", 1, 1)]
        [InlineData("kg", "g", "weight", 1, 1_000)]
        [InlineData("kg", "mg", "weight", 1, 1_000_000)]

        //g
        [InlineData("g", "t", "weight", 1, 0.000_001)]
        [InlineData("g", "kg", "weight", 1, 0.001)]
        [InlineData("g", "g", "weight", 1, 1)]
        [InlineData("g", "mg", "weight", 1, 1_000)]
        
        //mg
        [InlineData("mg", "t", "weight", 1, 0.000_000_001)]
        [InlineData("mg", "kg", "weight", 1, 0.000_001)]
        [InlineData("mg", "g", "weight", 1, 0.001)]
        [InlineData("mg", "mg", "weight", 1, 1)]

        [InlineData("mg", "mg", "weight", -1, -1)]

        //distance units
        //km
        [InlineData("km", "km", "distance", 1, 1)]
        [InlineData("km", "m", "distance", 1, 1_000)]
        [InlineData("km", "cm", "distance", 1, 100_000)]
        [InlineData("km", "mm", "distance", 1, 1_000_000)]

        //m
        [InlineData("m", "km", "distance", 1, 0.001)]
        [InlineData("m", "m", "distance", 1, 1)]
        [InlineData("m", "cm", "distance", 1, 100)]
        [InlineData("m", "mm", "distance", 1, 10_000)]

        //cm
        [InlineData("cm", "km", "distance", 1, 0.00_001)]
        [InlineData("cm", "m", "distance", 1, 0.01)]
        [InlineData("cm", "cm", "distance", 1, 1)]
        [InlineData("cm", "mm", "distance", 1, 10)]

        //mm
        [InlineData("mm", "km", "distance", 1, 0.000_001)]
        [InlineData("mm", "m", "distance", 1, 0.001)]
        [InlineData("mm", "cm", "distance", 1, 0.1)]
        [InlineData("mm", "mm", "distance", 1, 1)]

        [InlineData("mm", "mm", "distance", -1, -1)]

        public void ShouldConvertUnits(string from_unit, string to_unit, string unit_type, double value, double expected_value)
        {
            // arrange
            Converter converter = new();

            // act
            var result = converter.Convert(from_unit, to_unit, unit_type, value);

            // assert
            Assert.Equal(expected_value, result);
        }

    }
}