using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Kata8
{
    public class KataArrayMadness
    {
        public static bool ArrayMadness(int[] a, int[] b)
        {
            return a.Sum(x => Math.Pow(x, 2)) > b.Sum(x => Math.Pow(x, 3));
        }


        //public static bool ArrayMadness(int[] a, int[] b) => a.Sum(n => n * n) > b.Sum(n => n * n * n);


        //public static bool ArrayMadness(int[] a, int[] b)
        //{
        //    return a.Sum(x => x * x) > b.Sum(x => x * x * x);
        //}
    }
}
