using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Kata8
{
    internal class AllStarCodeChallenge18
    {
        public static int StrCount(string str, string letter)
        {
            return str.Count(c => c == letter[0]);
        }


        //public static int StrCount(string str, string letter) => str.Count(x => x.ToString() == letter);


        //public static int StrCount(string str, string letter)
        //{
        //    int count = 0;
        //    foreach(char c in str)
        //    {
        //        if(c.ToString() == letter) count++;
        //    }
        //    return count;

        //}


        //public static int StrCount(string str, string letter)
        //{    
        //    return str.Count(c => c == Convert.ToChar(letter) );
        //}


        //public static int StrCount(string str, string letter)
        //{
        //    return Regex.Matches(str,letter).Count;
        //}


        //public static int StrCount(string str, string letter)
        //{
        //    return str.Split(letter).Length - 1;
        //}


        //public static int StrCount(string str, string letter) => str.Where(o => o == char.Parse(letter)).Count();


        //public static int StrCount(string str, string letter)
        //{
        //    return str.Count(c => c == letter.First());
        //}


        //public static int StrCount(string str, string letter)
        //{
        //    return str.Where(e=> e == letter.First()).Count();
        //}
    }
}
