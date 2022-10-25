using System;
using System.Text;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string arg in args)
            {
                Console.WriteLine(arg + "\nunequal consecutive characters count: " + CountCharacters(arg));
            }
        }

        static int CountCharacters(string line)
        {
            if (line.Length == 0)
            {
                return 0;
            }
            int counter = 1;
            int max = 1;
            for(int i = 1; i < line.Length; i++)
            {
                if(line[i-1] != line[i])
                {
                    counter++;
                    if(counter > max)
                    {
                        max = counter;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            return max;
        }
    }
}