using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2023.DayTwo
{
    public class DayTwo
    {
        public static int CheckNumberOfCubes(int green, int blue, int red, string line)
        {
            string[] gamePair = line.Split(':');
            string id = gamePair[0];
            string game = gamePair[1];
            int highestGreen = 0;
            int highestBlue = 0;  
            int highestRed = 0;

            string[] rounds = game.Split(';');

            foreach (var round in rounds)
            {
                string[] cubes = round.Split(",");
                foreach (var cube in cubes)
                {
                    string[] pair = cube.Trim().Split(' ');
                    int numberOfCubes = int.Parse(pair[0]);
                    if (pair[1].Equals("green")) highestGreen = int.Max(highestGreen, numberOfCubes);

                    if (pair[1].Equals("blue")) highestBlue = int.Max(highestBlue, numberOfCubes);

                    if (pair[1].Equals("red")) highestRed = int.Max(highestRed, numberOfCubes);
                }
            }

            return highestBlue * highestGreen * highestRed;
        }

        public static void Solution()
        {
            string[] lines = File.ReadAllLines("C:\\Users\\caleg\\source\\repos\\AdventOfCode2023\\AdventOfCode2023\\DayTwo\\input.txt");
            int sum = 0;
            foreach (var line in lines)
            {
                int gameId = CheckNumberOfCubes(13, 14, 12, line);
                sum += gameId;
            }

            Console.WriteLine(sum);
        }
    }
}
