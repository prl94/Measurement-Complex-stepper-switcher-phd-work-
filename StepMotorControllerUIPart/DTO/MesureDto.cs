using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StepMotorControllerUIPart.DTO
{
    class MesureDto
    {
        public readonly int SwitcherPosition;
        public readonly double[] DataFromSwitcherArray;
        public readonly double[] DataFromOscillatorArray;

        public MesureDto(int switcherPosition, double[] dataFromSwitcherArray, double[] dataFromOscillatorArray)
        {
            SwitcherPosition = switcherPosition;
            DataFromOscillatorArray = dataFromOscillatorArray;
            DataFromSwitcherArray = dataFromSwitcherArray;
        }

    }
}
