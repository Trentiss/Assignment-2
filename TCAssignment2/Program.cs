using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit;
            int option;
            string[] triDimensions;
            exit = false;
            do
            {
                Console.WriteLine("Please Select an Option: " +
                    "\n1. Enter a triangle dimensions " +
                    "\n2. Exit");
                try
                {
                    option = int.Parse(Console.ReadLine());
                    if (option > 2 || option < 0)
                    {
                        throw new Exception("Input must be greater than 0 and less than 2");
                    }
                    switch (option)
                    {
                        case 1:
                            triDimensions = new string[3];
                            for (int i = 0; i < triDimensions.Length; i++)
                            {
                                Console.Write($"Please Enter Number {i + 1}: ");
                                triDimensions[i] = Console.ReadLine();
                            }
                            Console.WriteLine(TriangleSolver.Analyze(triDimensions));
                            Console.WriteLine();
                            break;
                        case 2:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (!exit);
        }
    }
}
