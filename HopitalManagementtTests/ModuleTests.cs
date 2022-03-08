using NUnit.Framework;
using HospitalManagement;

namespace HopitalManagementtTests
{
    public class Tests
    {
        private ManipulatePatientData _operation;
        [SetUp]
        public void Setup()
        {
            _operation = new ManipulatePatientData();
        }

        [Test]
        public void AgingRiskFactor_ShouldReturnDouble()
        {
            int age = 40;
            double expected = (age - 20) / 100; ;

            double actual = _operation.AgingRiskFactor(age);
            Assert.AreEqual(actual, expected);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void BodyTemperatureRiskFactor_ShouldReturnDouble()
        {
            double temp     = 40.3;
            double expected = 0.15;

            double actual = _operation.BodyTemperatureRiskFactor(temp);
            Assert.AreEqual(actual, expected);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void DiabetisRiskFactor_ShouldReturnDouble()
        {
            string hasDiabetes  = "True";
            double expected     = 0.12;

            double actual = _operation.DiabetisRiskFactor(hasDiabetes);
            Assert.AreEqual(actual, expected);
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void FeverRiskFactor_ShouldReturnDouble()
        {
            string fever = "No";
            double expected = 0.00;

            double actual = _operation.FeverRiskFactor(fever);
            Assert.AreEqual(actual, expected);
            Assert.That(actual, Is.EqualTo(expected));
        }
        
        [Test]
        public void HeartBitRateRiskFactor_ShouldReturnDouble()
        {
            double heartBitRate = 84;
            double expected = 0.02;

            double actual = _operation.HeartBitRateRiskFactor(heartBitRate);
            Assert.AreEqual(actual, expected);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void RiskDescription_ShouldReturnDescription()
        {
            double riskFactor = 48;
            string expected = "Very Critical";

            string actual = _operation.RiskDescription(riskFactor);
            Assert.AreEqual(actual, expected);
            Assert.That(actual, Is.EqualTo(expected));
        }


    }
}