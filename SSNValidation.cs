using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SSN_VAlIDATOR
{
    class SSNValidation
    {
        public static bool IsValid(string ssn)
        {
            // Regular expression to check if SSN is in the correct format (xxx-xx-xxxx)
            Regex ssnFormat = new Regex(@"^\d{3}-\d{2}-\d{4}$");
            if (!ssnFormat.IsMatch(ssn))
            {
                return false;
            }

            // Split SSN into parts
            string[] parts = ssn.Split('-');

            // Check first part
            int firstPart = int.Parse(parts[0]);
            if (firstPart == 000 || firstPart == 666 || (firstPart >= 900 && firstPart <= 999))
            {
                return false;
            }

            // Check second part
            int secondPart = int.Parse(parts[1]);
            if (secondPart < 1 || secondPart > 99)
            {
                return false;
            }

            // Check third part
            int thirdPart = int.Parse(parts[2]);
            if (thirdPart < 1 || thirdPart > 9999)
            {
                return false;
            }

            // If all checks pass, return true
            return true;
        }
    }
}

       

