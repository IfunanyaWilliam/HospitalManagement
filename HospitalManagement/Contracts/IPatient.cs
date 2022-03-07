using HospitalManagement.Enum;

namespace HospitalManagement.Contracts
{
    public interface IPatient
    {
        int Age { get; set; }
        double BodyTemperature { get; set; }
        string FirstName { get; set; }
        string FullName { get; }
        string Gender { get; set; }
        bool HasDiabetes { get; set; }
        bool HasFever { get; set; }
        double HeartBitRate { get; set; }
        string Id { get; }
        string LastName { get; set; }
        double MortalityRiskPercent { get; set; }
        string RiskDescription { get; set; }
    }
}