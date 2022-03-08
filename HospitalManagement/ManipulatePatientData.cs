using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagement.Contracts;


namespace HospitalManagement
{
    public class ManipulatePatientData
    {
        public double AgingRiskFactor(int age)
        {
            
            if (age == 20) { return 0.01; }
            double dyingProbability = (age - 20) / 100;
            return dyingProbability;
        }

        public double BodyTemperatureRiskFactor(double tempValue)
        {
            double dyingProbability = tempValue switch

            {
                double value when value >= 36.0   &&  value is <= 38.0 => 0.00,
                double value when value >  38.0   &&  value is <= 39.0 => 0.05,  
                double value when value >  39.0   &&  value is <= 40.0 => 0.10,  
                double value when value >  40.0   &&  value is <= 41.0 => 0.15,  
                double value when value >  41.0   &&  value is <= 42.0 => 0.20,  
                double value when value >  42.0   &&  value is <= 43.0 => 0.25,
                double value when value >  43.0   &&  value is <= 44.0 => 0.30,
                double value when value >  44.0   &&  value is <= 45.0 => 0.35,
                double value when value >  45.0   &&  value is <= 46.0 => 0.40,
                double value when value >  46.0   &&  value is <= 47.0 => 0.45,
                double value when value >  47.0   &&  value is <= 48.0 => 0.50,

                _ => 0.55
            };
            return dyingProbability;
        }

        public double FeverRiskFactor(string fever)
        {
            double dyingProbability = 0.0;
            if(fever == "True") { return dyingProbability = 0.15; }
            return dyingProbability;
        }

        public double DiabetisRiskFactor(string hasDiabetes)
        {
            double dyingProbability = 0.0;
            if(hasDiabetes == "True") { return dyingProbability = 0.12;  }
            return dyingProbability;
        }

        public double HeartBitRateRiskFactor(double heartBitRate)
        {
            double dyingProbability = 0.0;
            if(heartBitRate > 85 || heartBitRate < 85) { return dyingProbability = 0.02;  }
            return dyingProbability;
        }

        public string RiskDescription(double riskFactor)
        {
            string riskDescription = riskFactor switch
            {
                double value when value >= 0.0 && value is <= 15.0 => "Mild Risk",
                double value when value > 15.0 && value is <= 30.0 => "See Doctor",  
                double value when value > 30.0 && value is <= 45.0 => "Critical Condition",  
                double value when value > 45.0 && value is <= 60.0 => "Very Critical",  
                double value when value > 60.0 && value is <= 75.0 => "Critically Acute",   
                double value when value > 75.0 && value is <= 90.0 => "Red Alert",
                
                _ => "Terminal Condition"
            };
            return riskDescription;
        }
    }
}
