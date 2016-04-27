namespace StepMotorControllerUIPart.UsedTypes
{
    public class Mesure
    {
        public readonly int SwitcherPosition;
        public readonly double[] DataFromOscillatorArray;
        public readonly double[] DataFromSwitcherArray;
        

        public Mesure(int switcherPosition, double[] dataFromOscillatorArray, double[] dataFromSwitcherArray)
        {
            SwitcherPosition = switcherPosition;
            DataFromOscillatorArray = dataFromOscillatorArray;
            DataFromSwitcherArray = dataFromSwitcherArray;
        }
    }
}
