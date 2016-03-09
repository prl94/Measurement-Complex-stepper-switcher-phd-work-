using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StepMotorControllerUIPart.Helper
{
    static class ThreadSafeRandom
    {
        private static readonly Random random = new Random();

        public static double NextDouble()
        {
            lock (random)
            {
                return random.NextDouble();
            }
        }
    }
}
