using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship
{
    static public class Maths
    {
        public static double Min(double a, double b) 
        {
            return a > b ? b : a;
        }
        public static double Max(double a, double b) 
        {
            return a > b ? a : b;
        }
        public static double Sqrt(double a) 
        {
            return Math.Sqrt(a);
        }
        public static double Abs(double a) 
        {
            return a >= 0 ? a : a * (-1);
        }

        //Maths.Pow
        public static double Pow(double a, double b) 
        {
            return Math.Pow(a, b);
        }

        //Manual Power
        public static int Pow(int a, int b)
        {
            int pow = 1;
            for (int i = 0; i < b; i++)
            {
                pow *= a;
            }
            return pow;
        }
        
        
    }
}
