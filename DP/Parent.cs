using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class Parent:Person
    {
        public enum ParentType { Father, Mother }
        public int MyProperty { get; set; }
        public enum Origin { Ashkenazic, Yemeni,
            Iraqi, Moroccan, Syrian, Tunisian, Persian,
            Tripolitanian, Bukhari, Algerian, Georgian,
            Caucasian, Turkish, Kurdish, Afghan, Lebanese,GenerallyEastern
        } //Eastern are all of the orogins after the word 'Yemeni'--> we should decide be function
    }
}
