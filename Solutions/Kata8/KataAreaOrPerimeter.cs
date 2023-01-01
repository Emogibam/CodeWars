using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Kata8
{
    public class KataAreaOrPerimeter
    {
        public static int AreaOrPerimeter(int l, int w)
        {
            //return (l + w) * 2; //ISSUE: test cases are completely wrong!!! 12.02.2020
            return l == w ? l * w : (l + w) * 2; //Correctly solution
        }

        // public static int AreaOrPerimeter(int l, int w)
        // {
        //     return l == w ? l * w : (l + w) * 2;
        // }


        // public static int AreaOrPerimeter(int l, int w) => 2 * (l + w);

        // public static int AreaOrPerimeter(int l, int w) => l == w ? l * w : 2 * (l + w);

        // public static int AreaOrPerimeter(int l, int w)
        // {
        //     return l == w ? l * w : 2 * (l + w);
        // }

        // public static int AreaOrPerimeter(int a, int b)
        // {
        //     return a == b ? a * b : 2 * (a + b);
        // }

        // public static int AreaOrPerimeter(int l, int w)
        // {
        //     if (l == w)
        //     {
        //         return l * w;
        //     }
        //     else
        //     {
        //         return l * 2 + w * 2;
        //     }
        // }


        // public static int AreaOrPerimeter(int l, int w)
        // {
        //     return 2 * l + 2 * w;
        // }


        // public static int AreaOrPerimeter(int l, int w)
        // {
        //     return l == w ? (int) Math.Pow(l, 2) : (l + w) * 2;
        // }
    }
}
