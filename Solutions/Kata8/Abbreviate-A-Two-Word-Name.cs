using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Kata8
{
    public class Abbreviate_A_Two_Word_Name
    {
        //        Write a function to convert a name into initials.This kata strictly takes two words with one space in between them.

        //The output should be two capital letters with a dot separating them.

        //It should look like this:

        //Sam Harris => S.H

        //patrick feeney => P.F


        /// <summary>
        /// <para href="https://www.codewars.com/kata/abbreviate-a-two-word-name/train/csharp"></para>
        /// converts a name into initials.This kata strictly takes two words with one space in between them. 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string AbbrevName(string name) => $"{name[0]}.{name[name.IndexOf(' ') + 1]}".ToUpper();

        //public static string AbbrevName(string name)
        //{
        //    string[] buf = name.Split(' ');

        //    var firstName = buf.First();
        //    var lastName = buf.Last();

        //    var oneUpper = Char.ToUpper(firstName.First());
        //    var twoUpper = Char.ToUpper(lastName.First());

        //    return $"{oneUpper}.{twoUpper}";
        //}

        //public static string AbbrevName(string name)
        //{
        //    string[] a = name.Split(' ').ToArray();
        //    return $"{a[0].Substring(0,1).ToUpper()}.{a[1].Substring(0,1).ToUpper()}";

        //}

        //public static string AbbrevName(string name)
        //{
        //    var arr = name.ToUpperInvariant().Split(" ").Select(x => x[0]);
        //    return     string.Join('.',arr);
        //}

        //public static string AbbrevName(string name) => string.Join(".",name.Split(" ").Select(x=> x[0]).ToList()).ToUpper();

    }
}
