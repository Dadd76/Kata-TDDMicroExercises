using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDMicroExercises;
using TDDMicroExercises.TirePressureMonitoringSystem;

namespace TDDMicroExercisesUnitTest
{
    class MockSensorTest : ISensor
    {
        Queue<double> _queue = new Queue<double>();

        public double PopNextPressurePsiValue()
        {
            return _queue.Dequeue();
        }

        public void addPresure(double i)
        {
            _queue.Enqueue(i);
        }

    }
}
