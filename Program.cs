using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Triangle
{
    public class TriangleSolver
    {

        public static string Analyze(int sidex, int sidey, int sidez)
        {
            if (sidex == sidey && sidey == sidez)
            {
                return "It is a equilateral triangle.\n";
            }
            else if (sidex == sidey || sidey == sidez || sidex == sidez)
            {
                return "It is a isosceles triangle.\n";
            }
            else
            {
                return "It is a scalene triangle.\n";
            }

        }
    }
}