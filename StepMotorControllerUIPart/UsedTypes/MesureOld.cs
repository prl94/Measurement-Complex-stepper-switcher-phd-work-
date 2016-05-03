namespace StepMotorControllerUIPart.UsedTypes
{
    public class MesureOld
    {
        public readonly int SwitcherPosition;
        public readonly double[] DataFromOscillatorArray;
        public readonly double[] DataFromSwitcherArray;
        

        public MesureOld(int switcherPosition, double[] dataFromOscillatorArray, double[] dataFromSwitcherArray)
        {
            SwitcherPosition = switcherPosition;
            DataFromOscillatorArray = dataFromOscillatorArray;
            DataFromSwitcherArray = dataFromSwitcherArray;
        }
    }
}
