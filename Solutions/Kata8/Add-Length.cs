using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Kata8
{
    public class Add_Length
     {
        //        What if we need the length of the words separated by a space to be added at the end of that same word and have it returned as an array?

        //Example(Input --> Output)

        //"apple ban" --> ["apple 5", "ban 3"]
        //"you will win" -->["you 3", "will 4", "win 3"]
        //        Your task is to write a function that takes a String and returns an Array/list with the length of each word added to each element.

        //        Note: String will have at least one element; words will always be separated by a space.


        /// <summary>
        /// https://www.codewars.com/kata/add-length/train/csharp
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string[] AddLength(string str)
        {
            string[] arr = str.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] + " " + arr[i].Length;
            }

            return arr;
        }

        //public static string[] AddLength(string str)
        //{
        //    return str.Split().Select(x => $"{x} {x.Length}").ToArray();
        //}

        //public static string[] AddLength(string str)
        //    => str.Split(' ').Select(e=> $"{e} {e.Length}").ToArray();


        //public static string[] AddLength(string str)
        //{
        //    return str.Split(' ').Select(o => o + " " + o.Length).ToArray();
        //}


        //public static string[] AddLength(string str)
        //{
        //    string[] inputArr = str.Split(' ');
        //    string[] resultArr = new string[inputArr.Count()];

        //    for (int i = 0; i < inputArr.Length; i++)
        //    {
        //        resultArr[i] = $"{inputArr[i]} {inputArr[i].Length}";
        //    }

        //    return resultArr;
        //}


        //public static string[] AddLength(string str)
        //{
        //    return str.Split(' ').Select(s => string.Format("{0} {1}", s, s.Length)).ToArray();
        //}


    }
}
