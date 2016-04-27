namespace StepMotorControllerUIPart.UsedTypes
{
    public class MesureParameters
    {
        public readonly int StepsCount;
        public readonly int MesuresCount;
        public readonly int DelayBeforeStep;

        public MesureParameters(int stepsCount, int mesuresCount, int delayBeforeStep)
        {
            StepsCount = stepsCount;
            MesuresCount = mesuresCount;
            DelayBeforeStep = delayBeforeStep * 1000;
        }

    }
}