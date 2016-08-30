using System;
using TDDMicroExercises;
using NUnit.Framework;
using TDDMicroExercises.TirePressureMonitoringSystem;

namespace TDDMicroExercisesUnitTest
{
    [TestFixture]
    public class TelemetryTest
    {
        [Test]
        public void AlarmShouldRingOverLimitValue()
        {
            MockSensorTest mockSensor = new MockSensorTest();
            // int maxValue = 21;

            mockSensor.addPresure(22);
            Alarm alarm = new Alarm(mockSensor);
            alarm.Check();
            Assert.That(alarm.AlarmOn == true);

        }
        [Test]
        public void AlarmShouldRingUnderLimitValue()
        {
            MockSensorTest mockSensor = new MockSensorTest();
            // int minValue = 17;

            mockSensor.addPresure(16);
            Alarm alarm = new Alarm(mockSensor);
            alarm.Check();
            Assert.That(alarm.AlarmOn == true);
        }

        [Test]
        public void AlarmShouldNotRingBetweenLimitValue()
        {
            MockSensorTest mockSensor = new MockSensorTest();
            // int minValue = 17;

            mockSensor.addPresure(18);
            Alarm alarm = new Alarm(mockSensor);
            alarm.Check();
            Assert.That(alarm.AlarmOn == false);
        }

        [Test]
        public void AlarmShouldRingWhenPressureReachMaxValueAndShouldNotStopWhenPresureGoBackToGoodPreasure()
        {
            MockSensorTest mockSensor = new MockSensorTest();
            // int maxValue = 21;

            mockSensor.addPresure(22);
            mockSensor.addPresure(18);
            Alarm alarm = new Alarm(mockSensor);
            alarm.Check();
            Assert.That(alarm.AlarmOn == true);
            alarm.Check();
            Assert.That(alarm.AlarmOn == true);
        }

        public void AlarmShouldRingWhenPressureReachLimitValue()
        {
            MockSensorTest mockSensor = new MockSensorTest();
            // int maxValue = 21;

            mockSensor.addPresure(18);
            mockSensor.addPresure(22);
            Alarm alarm = new Alarm(mockSensor);
            alarm.Check();
            Assert.That(alarm.AlarmOn == false);
            alarm.Check();
            Assert.That(alarm.AlarmOn == true);
        }
    }
}
