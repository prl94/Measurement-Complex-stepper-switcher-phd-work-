namespace StepMotorControllerUIPart.UsedTypes
{
    public class MesureParameters
    {
        public readonly int StepsCount;
        public readonly int MesuresCount;
        public readonly int DelayAfterStep;

        public MesureParameters(int stepsCount, int mesuresCount, int delayBeforeStep)
        {
            StepsCount = stepsCount;
            MesuresCount = mesuresCount;
            DelayAfterStep = delayBeforeStep * 1000;
        }

    }
}