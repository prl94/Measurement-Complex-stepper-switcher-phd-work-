using System.Diagnostics;

namespace StepMotorControllerUIPart.DTO
{
    public class ParametersDto
    {
        public readonly int StepsCount;
        public readonly int DelayInterval;

        public ParametersDto(int stepsCount, int delayInterval)
        {
            StepsCount = stepsCount;
            DelayInterval = delayInterval;
        }

    }
}