using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StepMotorControllerUIPart.UsedTypes
{
    //todo add diaphragmas array instead of current realidation
    public class Diaphragms
    {
         public float[] DiaphragmsArray;

         public Diaphragms(Dictionary<string, float> diaphragms)
        {
            DiaphragmsArray = new float[diaphragms.Count];
            for (int i = 0; i < diaphragms.Count; i++)
            {
                DiaphragmsArray[i] = diaphragms["D" + i];
            }
        }
    }
}
