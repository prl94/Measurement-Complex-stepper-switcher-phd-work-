using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StepMotorControllerUIPart.DTO
{
    class CalculatedDataDto
    {
        public readonly int SwitcherPosition;
        public readonly double Dispersion;
        public readonly double AverageValue;


        public CalculatedDataDto(int switcherPosition, double dispersion, double averageValue)
        {
            SwitcherPosition = switcherPosition;
            Dispersion = dispersion;
            AverageValue = averageValue;
        }
    }
}
