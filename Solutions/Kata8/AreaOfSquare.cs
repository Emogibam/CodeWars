using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Kata8
{
    public class AreaOfSquare
    {
        public static double SquareArea(double A)
        {
            return Math.Round(Math.Pow(A / Math.PI, 2) * 4, 2);
        }


        //public static double SquareArea(double A) => Math.Round((4 * A / (2 * Math.PI)) * (4 * A / (2 * Math.PI)), 2);


        //public static double SquareArea(double A)
        //{
        //    return Math.Round(Math.Pow(4 * A / (2 * Math.PI), 2), 2);
        //}

        //public static double SquareArea(double A)
        //{
        //    return Math.Round((A / Math.PI * 2) * (A / Math.PI * 2), 2);
        //}


        //public static double SquareArea(double A)
        //{
        //    return Math.Round(Math.Pow(2 * A / System.Math.PI, 2), 2);
        //}
    }
}
