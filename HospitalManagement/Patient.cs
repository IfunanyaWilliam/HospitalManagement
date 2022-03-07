using System.Collections;
using HospitalManagement.Contracts;

namespace HospitalManagement
{
    public class Patient : IPatient
    {
        public Patient()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double BodyTemperature { get; set; }
        public bool HasFever { get; set; }
        public bool HasDiabetes { get; set; }
        public double HeartBitRate { get; set; }
        public string Gender { get; set; }
        public double MortalityRiskPercent { get; set; }
        public string RiskDescription { get; set; }
        public string FullName => FirstName + " " + LastName;


    }

}