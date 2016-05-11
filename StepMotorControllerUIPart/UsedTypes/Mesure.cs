using System.Linq;
using StepMotorControllerUIPart.Helper;

namespace StepMotorControllerUIPart.UsedTypes
{
    public class Mesure
    {

        public readonly int MesureNumber;
        public readonly float[] USecondaryEmitionMonitor;
        public readonly float[] UChannel;
        public float Resistor;
        public float Diaphragm;

        public double Inorm {
            get { return (USecondaryEmitionMonitorAverage / Resistor) / UChannelAverage; }
        }
    
        //average
        public double USecondaryEmitionMonitorAverage {
            get { return USecondaryEmitionMonitor.Average(); }
        }
        public double UChannelAverage
        {
            get { return UChannel.Average(); }
        }

        //StandardDeviation
        public double USecondaryEmitionMonitorStandardDeviation
        {
            get { return MathHelper.GetStandardDeviation(USecondaryEmitionMonitor); }
        }
        public double UChannelStandardDeviation
        {
            get { return MathHelper.GetStandardDeviation(UChannel); }
        }

        public Mesure(int mesureNumber, float[] uSecondaryEmitionMonitor, float[] uChannel, float resistor, float diaphragm)
        {
            MesureNumber = mesureNumber;
            USecondaryEmitionMonitor = uSecondaryEmitionMonitor;
            UChannel = uChannel;
            Resistor = resistor;
            Diaphragm = diaphragm;
        }
        

    }
}
