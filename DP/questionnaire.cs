using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class Questionnaire
    {
        public int SeekerId { get; set; }
        public string FinancialHelp { get; set; }
        public bool transferPhoto { get; set; }
        public string Email { get; set; }
        public string PhoneNumberForOfferings { get; set; }

        public bool AreParentsDivorced { get; set; }
        public string HealthCondition { get; set; }
        public List<Interest> Interests { get; set; }
        public bool DoesWork { get; set; }//not sure if to add the profession here or in the questionnair












    }
}
