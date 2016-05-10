using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StepMotorControllerUIPart.UsedTypes
{

    //todo add resistors array instead of current realisation

    class Resistors
    {
       public float[] ResistorsArray;

        public Resistors(Dictionary<string, float> resistors)
        {
            ResistorsArray = new float[resistors.Count];
            for (int i= 0; i < resistors.Count; i++)
            {
                ResistorsArray[i] = resistors["R" + i];
            }
        }
    }    
}

