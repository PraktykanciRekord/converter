using converter;
namespace converter.Core
{
    public class Converter
    {
        public string[] weight_units = { "t", "kg", "g", "mg" };
        public string[] distance_units = { "km", "m", "cm", "mm" };
        public int[] weight_units_convert_ratio = {
            1, 1_000, 1_000_000, 1_000_000_000, //t
            1_000, 1, 1_000, 1_000_000,         //kg
            1_000_000, 1_000, 1, 1_000,     //g
            1_000_000_000, 1_000_000, 1_000, 1  //mg
        };
        public int[] distance_units_convert_ratio = {
            1, 1_000, 100_000, 1_000_000,       //km
            1_000, 1, 100, 10_000,              //m
            100_000, 100, 1, 10,                //cm
            1_000_000, 1_000, 10, 1             //mm
        };
        public char[] units_convert_sign = {
        '*', '*', '*', '*',
        '/', '*', '*', '*',
        '/', '/', '*', '*',
        '/', '/', '/', '*'
        };
        public enum selected_unit_types
        {
            weight,
            distance
        }
        public double Convert(string? from_unit, string? to_unit, string? unit_type, double val)
        {
            double res = -1;
            string[] units = new string[0];
            int counter = 0;
            int[] units_convert_ratio = new int[0];
            if (unit_type == selected_unit_types.weight.ToString())
            {
                units = weight_units;
                units_convert_ratio = weight_units_convert_ratio;
            }
            else if (unit_type == selected_unit_types.distance.ToString())
            {
                units = distance_units;
                units_convert_ratio = distance_units_convert_ratio;
            }

            foreach (string unit in units)
            {
                foreach (string secondary_unit in units)
                {
                    if (unit == from_unit && secondary_unit == to_unit)
                    {
                        if (units_convert_sign[counter] == '*')
                        {
                            res = val * units_convert_ratio[counter];
                        }
                        else if (units_convert_sign[counter] == '/')
                        {
                            res = val / units_convert_ratio[counter];
                        }
                    }
                    counter++;
                }
            }
            return res;
        }
    }
}
