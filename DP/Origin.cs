using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class Origin
    {
        public string Ashkenazic { get; set; }
        public string Yemeni { get; set; } //"teymani" in hebrew
        public enum Eastern
        {
            Iraqi, Moroccan, Syrian, Tunisian, Persian,
            Tripolitanian, Bukhari, Algerian, Georgian,
            Caucasian, Turkish, Kurdish, Afghan, Lebanese
        }



    }
}
