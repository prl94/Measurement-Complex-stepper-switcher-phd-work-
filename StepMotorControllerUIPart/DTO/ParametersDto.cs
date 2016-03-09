using System.Diagnostics;

namespace StepMotorControllerUIPart.DTO
{
    public class ParametersDto
    {
        public readonly int StepsCount;
        public readonly int MesuresCount;

        public ParametersDto(int stepsCount, int mesuresCount)
        {
            StepsCount = stepsCount;
            MesuresCount = mesuresCount;
        }

    }
}