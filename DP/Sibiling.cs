using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class Sibiling : Person
    {
        public enum Gender { Male, Female }
        public int YearOfBirth { get; set; }//needs to be current
        public bool Married { get; set; }
        public string marriedTo { get; set; }
        public enum Statuse { Works, Studies, WorksAndStudies, Other }

    }
}
