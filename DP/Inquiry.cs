using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
     public class Inquiry : Person
    {
        public enum status { friend, rabbai, family, familyAcquaintances, inLaws, other }
        public string PhoneNumber { get; set; }
    }
}
