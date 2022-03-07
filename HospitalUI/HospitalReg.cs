using HospitalManagement.Contracts;
using HospitalManagement;
using HospitalManagement.Enum;

namespace HospitalUI
{
    public partial class HospitalReg : Form
    {
        public IList<IPatient> patientsData { get; set; }

        public HospitalReg()
        {
            InitializeComponent();
            patientsData = new List<IPatient>() 
            {
                new Patient()
                {
                    FirstName            = "Adam",
                    LastName             = "Okeke",
                    Age                  = 27,
                    BodyTemperature      = 30,
                    HasFever             = false,
                    HasDiabetes          = false,
                    Gender               = Gender.Male.ToString(),
                    HeartBitRate         = 85,
                    MortalityRiskPercent = 7,
                    RiskDescription     = "Mild Risk"
                },
                new Patient()
                {
                    FirstName            = "Adanna",
                    LastName             = "Eze",
                    Age                  = 40,
                    BodyTemperature      = 39,
                    HasFever             = false,
                    HasDiabetes          = true,
                    Gender               = Gender.Female.ToString(),
                    HeartBitRate         = 88,
                    MortalityRiskPercent = 42,
                    RiskDescription     = "Critical Condition"
                }

            };
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisplayPatient displayForm = new DisplayPatient(patientsData);
            displayForm.Show();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            ManipulatePatientData data = new ManipulatePatientData();

            string firstName        = FirstName.Text;
            string lastName         = LastName.Text;
            string hasFever         = HasFever.Text.ToLower();
            string hasDiabeties     = HasDiabeties.Text.ToLower();
            string gender           = GenderField.Text;
            double heartBit         = Convert.ToDouble(HeartBit.Text);
            int age                 = Convert.ToInt32(Age.Text);
            double bodyTemperature  = Convert.ToDouble(BodyTemperature.Text);

            double sumRiskFactors =  data.FeverRiskFactor(hasFever)
                                   + data.DiabetisRiskFactor(hasDiabeties)
                                   + data.HeartBitRateRiskFactor(heartBit)
                                   + data.AgingRiskFactor(age)
                                   + data.BodyTemperatureRiskFactor(bodyTemperature);

            sumRiskFactors = (Math.Round((sumRiskFactors * 100), 2));
            string petientRiskDescription = data.RiskDescription(sumRiskFactors);

            var newPatient = new Patient()
            {
                FirstName = firstName,
                LastName = lastName,
                BodyTemperature = bodyTemperature,
                Age = age,
                HasFever = Convert.ToBoolean(hasFever),
                HasDiabetes = Convert.ToBoolean(hasDiabeties),
                HeartBitRate = heartBit,
                Gender = gender,
                MortalityRiskPercent = (sumRiskFactors),
                RiskDescription = petientRiskDescription

            };
            
            patientsData.Add(newPatient);
            ClearFields();
            MessageBox.Show($"{newPatient.FullName} has been successfully registered");
        }

        public void ClearFields()
        {
            FirstName.Text = "";
            LastName.Text = "";
            HeartBit.Text = "";
            Age.Text = "";
            BodyTemperature.Text = "";
        }
    }
}