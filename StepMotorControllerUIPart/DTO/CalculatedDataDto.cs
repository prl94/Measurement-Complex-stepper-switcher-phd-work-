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
        public readonly double Average;

        public static List<CalculatedDataDto> allResults;
    }
}
