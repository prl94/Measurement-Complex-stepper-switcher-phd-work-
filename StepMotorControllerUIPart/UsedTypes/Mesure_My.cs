using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StepMotorControllerUIPart.UsedTypes
{
    public class Mesure_My
    {
        public int MesureNumber;
        public float[] USecondaryEmmisionMonitor;
        public float[] UChannel1;
        public float[] UChannel2;

        public Mesure_My(int mesureNumber, float[] uSecondaryEmmisionMonitor, float[] uChannel1, float[] uChannel2)
        {
            MesureNumber = mesureNumber;
            USecondaryEmmisionMonitor = uSecondaryEmmisionMonitor;
            UChannel1 = uChannel1;
            UChannel2 = uChannel2;
        }

    }
}
