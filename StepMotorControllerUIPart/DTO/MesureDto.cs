using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StepMotorControllerUIPart.DTO
{
    class MesureDto
    {
        public readonly int SwitcherPosition;
        public readonly double[] DataFromOscillatorArray;
        public readonly double[] DataFromSwitcherArray;
        

        public MesureDto(int switcherPosition, double[] dataFromOscillatorArray, double[] dataFromSwitcherArray)
        {
            SwitcherPosition = switcherPosition;
            DataFromOscillatorArray = dataFromOscillatorArray;
            DataFromSwitcherArray = dataFromSwitcherArray;
        }
    }
}
