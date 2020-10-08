using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    public class CheckTriangle
    {
        public static void Main()
        {
            int opt;
            Console.WriteLine("\n\n");
            Console.WriteLine("Choose the options below:");
            Console.WriteLine("\n\n");
            Console.WriteLine("1) Enter the Triangle Dimensions");
            Console.WriteLine("\n\n");
            Console.WriteLine("2) Exit");
            Console.WriteLine("\n\n");
            opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:

                    Console.WriteLine("To Find if the given dimensions of the triangle is an equilateral, Isosceles, Scalene.");
                    Console.WriteLine("\n\n");

                    Console.WriteLine("Provide the value for side 1 of the triangle");
                   int sidex = int.Parse(Console.ReadLine());
                    Console.WriteLine("Provide the value for side 2 of the triangle");
                   int sidey = int.Parse(Console.ReadLine());
                    Console.WriteLine("Provide the value for side 3 of the triangle");
                   int sidez = int.Parse(Console.ReadLine());

                    var CheckTriangle = new CheckTriangle();
                        Console.WriteLine(TriangleSolver.Analyze(sidex, sidey, sidez));
                    break;

                case 2:
                    break;

                default:
                    Console.WriteLine("Enter the correct option");
                    break;
            }
        }
    }
}