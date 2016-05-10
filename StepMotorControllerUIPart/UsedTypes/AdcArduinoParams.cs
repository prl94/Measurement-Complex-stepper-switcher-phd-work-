using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StepMotorControllerUIPart.UsedTypes
{
    public class AdcArduinoParams
    {
        public readonly String ModBusComPort;
        public readonly String ArduinoComPort;
        public readonly Adress OscillatorAdress;
        public readonly Adress Stepper1Adress;
        public readonly Adress Stepper2Adress;

        public AdcArduinoParams(String modBusComPort, String arduinoComPort, Adress oscillatorAdress,
            Adress stepper1Adress, Adress stepper2Adress)
        {
            ModBusComPort = modBusComPort;
            ArduinoComPort = arduinoComPort;
            OscillatorAdress = oscillatorAdress;
            Stepper1Adress = stepper1Adress;
            Stepper2Adress = stepper2Adress;
        }
    }
}
