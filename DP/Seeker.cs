using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{

    public class Seeker : Person
    {
        public string Picture { get; set; }
        public enum BodyStructure { thin, average, thick }

        public DateTime DOB { get; set; }
        public string ElementarSchool { get; set; }

        public Parent Father { get; set; }
        public Parent Mother { get; set; }

        //there is a father/mother object so i'm not sure how to insert the value
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string MotherFamilyName { get; set; }
     //   public Origin Myorigin() { }// we should do a function that takes the fathers father origin
        public int NumberOfSiblings { get; set; }
        public List<Sibiling> Sibilings { get; set; }

        /////


    }
}
