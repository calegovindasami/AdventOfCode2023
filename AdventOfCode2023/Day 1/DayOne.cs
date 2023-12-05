using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode2023.Day_1
{
    public static class DayOne
    {
        static Dictionary<string, string> Digits = new()
        {
            { "zero", "z0o" },
            { "one", "o1e" },
            { "two", "t2o" },
            { "three", "t3e" },
            { "four", "f4r" },
            { "five", "f5e" },
            { "six", "s6x" },
            { "seven", "s7n" },
            { "eight", "e8t" },
            { "nine", "n9e" }
        };
        public static int GetCalibrationValue(string line)
        {
            foreach (var pair in Digits)
            {
                string pattern = $@"{pair.Key}";
                line = Regex.Replace(line, pattern, pair.Value);
            }

            char[] numbers = line.Where(x => char.IsNumber(x)).ToArray();

            string combinedNumber = numbers[0].ToString() + numbers[numbers.Length - 1].ToString();
            return int.Parse(combinedNumber);
        }

        public static int Solution()
        {
            int sum = 0;
            string[] lines = File.ReadAllLines("C:\\Users\\caleg\\source\\repos\\AdventOfCode2023\\AdventOfCode2023\\Day 1\\input.txt");

            foreach (string line in lines)
            {
                int calibVal = GetCalibrationValue(line);
                sum += calibVal;
            }

            return sum;
        }
    }
}
