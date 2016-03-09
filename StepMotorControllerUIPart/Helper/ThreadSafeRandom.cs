using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StepMotorControllerUIPart.Helper
{
    class ThreadSafeRandom
    {
        private static Random random = new Random();

        public static double NextDouble()
        {
            lock (random)
            {
                return random.NextDouble();
            }
        }
    }
}
