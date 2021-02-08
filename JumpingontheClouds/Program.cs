using System;

namespace JumpingontheClouds
{
    class Solution 
    {

            static int jumpingOnClouds(int[] c)
            { 
                if(c[c.Length-1]==1)
                {
                    Console.WriteLine("the last value cannot be 1");
                    return 0;
                }

                int stepCount = 0;
                    for (int i = 0; i < c.Length; i++)
                    {
                        if (i + 2 < c.Length-1)
                        {
                            if (c[i + 2] == 1)
                            {
                                stepCount++;
                            }
                            else
                            {
                                stepCount++;
                                i++;

                            }
                        }
                        if (i  == c.Length-1)
                        {
                            stepCount++;
                        }

                    }

                return stepCount++;
             }


            static void Main(string[] args) 
            {
                 Console.Write("Array(ex 0,1,0,0):");
                 string str = Console.ReadLine();
                 int[] c = Array.ConvertAll(str.Split(','), int.Parse);
        
                Console.WriteLine("Step Count:" + jumpingOnClouds(c));
                Console.WriteLine("----------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("https://github.com/erdemaltiparmak");

              }
        }

}
