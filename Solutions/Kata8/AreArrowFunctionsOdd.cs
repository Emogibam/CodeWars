using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Kata8
{
    public class AreArrowFunctionsOdd
    {
        public static List<int> Odds(List<int> values) => values.Where(x => x % 2 == 1).ToList();
    }


    //public static List<int> Odds(List<int> values) =>
    //values.Where(q => q % 2 != 0)
    //.ToList();


    //public static List<int> Odds(List<int> values) =>
    //// arrow it
    //values.Where(x => x % 2 == 1)
    //.ToList();


    //public static List<int> Odds(List<int> values) =>
    //// arrow it
    //values.Where(s => s % 2 == 1)
    //.ToList();


    //public static List<int> Odds(List<int> values)
    //{
    //    return values.Where(x => x % 2 == 1).ToList();
    //}
}
