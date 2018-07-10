using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise_5
{
    public class Claim
    {
        public DateTime IncidentDate { get; set; }
        public decimal ClamValue { get; set; }
        public string Message { get; set; }

        public Claim(DateTime incidentDate, decimal clamValue)
        {
            IncidentDate = incidentDate;
            ClamValue = clamValue;
            CheckClaimByClaimValue(this);
            CheckClaimByDate(this);
        }

        private void CheckClaimByClaimValue(Claim claim)
        {
            if (claim.ClamValue > 0m && claim.ClamValue < 10000m)
            {
                Message = "Thank you. Your claim is being processed.";
              
            }
            else if (claim.ClamValue < 10000m)
            {
                Message = "Please call our service agent to have your claim processed";
            }

        }

        private void CheckClaimByDate(Claim claim)
        {
            var currentDate = DateTime.Now;
            var timeSinceIncident = currentDate - claim.IncidentDate;

            if (timeSinceIncident.TotalDays > 30)
            {
                Message = "Claim is not valid. Claim has to be made within 30 days of the incident";
            }
        }
    }
}
