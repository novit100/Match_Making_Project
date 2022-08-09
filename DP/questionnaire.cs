using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class Questionnaire
    {
        public string FinancialHelp { get; set; }
        public bool transferPhoto { get; set; }
        public string Email { get; set; }
        public string PhoneNumberForOfferings { get; set; }

        public bool AreParentsDivorced { get; set; }
        public string HealthCondition { get; set; }
        public List<string> Interests = new List<string>()
                    {
                        "reading",
                        "writing",
                        "music",
                        "cooking / baking",
                        "sport",
                        "Drawing",
                        "Academic reading",
                        "Extreme activity",
                        "trips / nature",
                        "language teaching",
                        "Crosswords / sudoku / riddles",
                        "Board games(chess, etc.)",
                        "Volunteering / charity activity]"
                    };












    }
}
