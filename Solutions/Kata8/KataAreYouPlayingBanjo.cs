using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Kata8
{
   
    
        public static class KataAreYouPlayingBanjo
        {
            public static string AreYouPlayingBanjo(string name)
            {
                return name.ToUpper().StartsWith("R") ? $"{name} plays banjo" : $"{name} does not play banjo";
            }

            //public static string AreYouPlayingBanjo(string name)
            //{
            //    return string.Format("{0} {1} banjo", name, char.ToLower(name[0]) == 'r' ? "plays" : "does not play");
            //}


            //public static string AreYouPlayingBanjo(string name)
            //{
            //    //Implement me
            //    return name.ToLower()[0] == 'r' ? name + " plays banjo" : name + " does not play banjo";
            //}


            //public static string AreYouPlayingBanjo(string name)
            //{
            //    if (name.StartsWith("R", true, CultureInfo.InvariantCulture))
            //        return String.Format("{0} plays banjo", name);
            //    return String.Format("{0} does not play banjo", name);
            //}


            //public static string AreYouPlayingBanjo(string name) => name.ToLower()[0] == 'r' ? name + " plays banjo" : name + " does not play banjo";


            //public static string AreYouPlayingBanjo(string name)
            //{
            //    return $"{name} {(name[0] == 'R' || name[0] == 'r')? "plays banjo" : "does not play banjo"}";
            //}


            //public static string AreYouPlayingBanjo(string name)
            //{
            //    return name + " " + (name.ToUpperInvariant().StartsWith("R") ? "plays" : "does not play") + " banjo";
            //}
        }
    }
