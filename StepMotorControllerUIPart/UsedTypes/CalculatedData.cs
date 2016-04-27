namespace StepMotorControllerUIPart.UsedTypes
{
    public class CalculatedData
    {
        public readonly int SwitcherPosition;
        public readonly double Dispersion;
        public readonly double AverageValue;


        public CalculatedData(int switcherPosition, double dispersion, double averageValue)
        {
            SwitcherPosition = switcherPosition;
            Dispersion = dispersion;
            AverageValue = averageValue;
        }
    }
}
