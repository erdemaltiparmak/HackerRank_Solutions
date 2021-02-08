using System;

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

//https://www.linkedin.com/in/erdem-alt%C4%B1parmak/
//erdem.altiparmak@ogr.sakarya.edu.tr
//altiparmak.rdm@gmail.com
namespace CountingValleys
{

    class Result
    {
        public static int countingValleys(int steps, string path)
        {
            int valley = 0, seaLevel = 0, high = 0;

            for (int i = 0; i < steps; i++)
            {
                high = (path[i] == 'D') ? high - 1 : high;

                high = (path[i] == 'U') ? high + 1 : high;

                if (i != 0) valley = (path[i] != 'D' && high == seaLevel) ? valley + 1 : valley;

            }

            return valley;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            Console.Write("Step:");
            int steps = Convert.ToInt32(Console.ReadLine().Trim());
            Console.Write("Path:");
            string path = Console.ReadLine();

            Console.WriteLine("Valley Count:" + Result.countingValleys(steps, path));
            Console.WriteLine("----------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("https://github.com/erdemaltiparmak");

        }
    }


}

