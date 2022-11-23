using System;
using System.Collections;
using System.Diagnostics.Metrics;
using static converter.Core.Converter;

namespace converter.Core
{
    public class Converter
    {
        public string[] weightUnits = { "t", "kg", "g", "mg" };
        public string[] distanceUnits = { "km", "m", "cm", "mm" };

        public int[] weightUnitsConvertRatio = {
            1, 1_000, 1_000_000, 1_000_000_000, //t
            1_000, 1, 1_000, 1_000_000,         //kg
            1_000_000, 1_000, 1, 1_000,         //g
            1_000_000_000, 1_000_000, 1_000, 1  //mg
        };
        public int[] distanceUnitsConvertRatio = {
            1, 1_000, 100_000, 1_000_000,       //km
            1_000, 1, 100, 10_000,              //m
            100_000, 100, 1, 10,                //cm
            1_000_000, 1_000, 10, 1             //mm
        };
        public char[] unitsConvertSign = {
        '*', '*', '*', '*',
        '/', '*', '*', '*',
        '/', '/', '*', '*',
        '/', '/', '/', '*'
        };
        public enum unitTypes
        {
            weight,
            distance
        }
        public string[] unitTypesArray = { "weight", "distance" };
        public bool AreUnitsSame(string? unit, string? fromUnit, string? secondaryUnit, string? toUnit)
        {
            return unit == fromUnit && secondaryUnit == toUnit;
        }
        public bool IsUnitWeight(string? unitType)
        {
            return unitType == unitTypes.weight.ToString();
        }
        public bool IsUnitDistance(string? unitType)
        {
            return unitType == unitTypes.distance.ToString();
        }
        public bool IsConvertSignStar(int counter)
        {
            return unitsConvertSign[counter] == '*';
        }
        public bool IsConvertSignSlash(int counter)
        {
            return unitsConvertSign[counter] == '/';
        }
        public string[] Convert(string? fromUnit, string? toUnit, double val)
        {
            string[] result = new string[3];
            bool success = true;
            double resultValue = -1;
            string error = "no error";
            string[] units = new string[0];
            string? unitType = GetSelectedUnitTypes(fromUnit);
            int counter = 0;
            int[] unitsConvertRatio = new int[0];
            if (IsUnitWeight(unitType))
            {
                units = weightUnits;
                unitsConvertRatio = weightUnitsConvertRatio;
            }
            else if (IsUnitDistance(unitType))
            {
                units = distanceUnits;
                unitsConvertRatio = distanceUnitsConvertRatio;
            }
            else
            {
                error = "incorrect unit";
                success = false;
            }
            foreach (string unit in units)
            {
                foreach (string secondaryUnit in units)
                {
                    if (AreUnitsSame(unit, fromUnit, secondaryUnit, toUnit))
                    {
                        if (IsConvertSignStar(counter))
                        {
                            resultValue = val * unitsConvertRatio[counter];
                        }
                        else if (IsConvertSignSlash(counter))
                        {
                            resultValue = val / unitsConvertRatio[counter];
                        }
                    }
                    counter++;
                }
            }

            if (resultValue >= double.MaxValue || resultValue <= double.MinValue)
            {
                error = "too big value";
                success = false;
                resultValue = -1;
            }
            if (!units.Contains<string>(fromUnit))
            {
                error = "incorrect first unit";
                success = false;
            }

            if (!units.Contains<string>(toUnit))
            {
                error = "incorrect second unit";
                success = false;
            }
            result[0] = success.ToString();
            result[1] = error;
            result[2] = resultValue.ToString();
            return result;
        }
        public bool IsUnitTypeSampleUnit(string? unitType, string? sampleUnit)
        {
            return unitType == sampleUnit;
        }
        public string GetSelectedUnitTypes(string? sampleUnit)
        {
            string[][] unitArrays = {weightUnits, distanceUnits};
            int i = 0;
            foreach (string[] unitTypeArray in unitArrays)
            {
                foreach (string unitType in unitTypeArray)
                {
                    if (IsUnitTypeSampleUnit(unitType, sampleUnit))
                    {
                        return unitTypesArray[i];
                    }
                }
                i++;
            }
            return "";
        }
    }
}
