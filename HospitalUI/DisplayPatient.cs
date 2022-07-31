using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagement;
using HospitalManagement.Contracts;


namespace HospitalUI
{
    public partial class DisplayPatient : Form
    {
        public IList<IPatient> PatientsData { get; set; }
        public DisplayPatient(IList<IPatient>  patientsData)
        {
            InitializeComponent();
            PatientsData = patientsData;
            DisplayRecords();
        }

        public void DisplayRecords()
        {
           // var patientList = PatientsData;
            var searchQuery = from s in PatientsData
                              orderby s.MortalityRiskPercent descending
                              select s;

            foreach (var patient in searchQuery)
            {
                DisplayPatientRecords.Rows.Add(
                                                patient.Id,
                                                patient.FullName,
                                                patient.MortalityRiskPercent,
                                                patient.RiskDescription);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                        this.Close();
        }
    }
}
