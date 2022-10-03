using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Kata8
{
    public class AlternatingCase
    {
        public static string ToAlternatingCase( string s)
        {
            return new String(s.Select(c => (char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c))).ToArray());
        }


        //public static string ToAlternatingCase (this string s)
        //{
        //    return string.Concat(s.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)));
        //}

        //public static string ToAlternatingCase (this string Input)
        //{
        //    return String.Join("", Input.ToCharArray().Select(character => Char.IsLower(character) ? Char.ToUpper(character) : Char.ToLower(character)));
        //}


        //public static string ToAlternatingCase (this string s)
        //{
        //    return string.Concat(s.Select(x => char.IsLower(x) ? char.ToUpper(x) : char.ToLower(x)));    
        //}


        //public static string ToAlternatingCase (this string s)
        //{
        //    return string.Concat(s.Select(c => (char)(c^c/65*(1-(c-1)%32/26)*32)));
        //}


        //public static string ToAlternatingCase (this string s) =>
        //    string.Concat(s.Select(c => char.IsLetter(c) ? (char)(c ^ 32) : c));


        //public static string ToAlternatingCase (this string s)
        //{
        //    return Regex.Replace(s,"[a-zA-Z]", x => Char.IsUpper(x.Value[0]) ? Char.ToLower(x.Value[0]).ToString() : Char.ToUpper(x.Value[0]).ToString());
        //}


        //public static string ToAlternatingCase (this string s)
        //{
        //    string Alternate(char c) => 
        //        char.IsLower(c) 
        //            ? char.ToUpper(c).ToString() 
        //            : char.ToLower(c).ToString();

        //    return string.Concat(s.Select(Alternate));
        //}


        //public static string ToAlternatingCase (this string s)
        //{
        //    Func<char, String> selector=
        //        c => (char.IsUpper(c)?char.ToLower(c):char.ToUpper(c)).ToString();
        //    return s.Select(selector).Aggregate(String.Concat);
        //}
    }
}
