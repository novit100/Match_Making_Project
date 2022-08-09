using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{

    public class Seeker : Person
    {
        public enum Gender { Male,Female }
        public string Picture { get; set; }
        public enum BodyStructure { Thin, Average, Thick }
        public DateTime DOB { get; set; }
        public string ElementrySchool { get; set; }
        public bool DoesWork { get; set; }//not sure if to add the profession here or in the questionnair
        public Questionnaire Questionnaire { get; set; }//can i nme them the same
        //pointers to the family members
        public Parent Father { get; set; }
        public Parent Mother { get; set; }
        public List<Sibiling> Sibilings { get; set; }
        public List<Inquiry> Inquiries { get; set; }

        // public int NumberOfSiblings { get; set; }




        //there is a father/mother object so i'm not sure how to insert the value
        // public string FatherName { get; set; }
        //public string MotherName { get; set; }
        //public string MotherFamilyName { get; set; }
        //public Origin Myorigin() { }// we should do a function that takes the fathers father origin





    }
}