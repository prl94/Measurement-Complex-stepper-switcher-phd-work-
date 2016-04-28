using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using NLog;
using StepMotorControllerUIPart.SerialPortClasses;
using StepMotorControllerUIPart.UsedTypes;

namespace StepMotorControllerUIPart.Logic
{
    public static class GeneralLogic
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static List<Mesure> GetMesures(MesureParameters parameters, AdcArduinoParams adcArduinoParams)
        {

            ModBus adc = new ModBus();
            Arduino.Connect(adcArduinoParams.ArduinoComPort);
            adc.Connect();
            var mesuresList = new List<Mesure>();

            List<Mesure> stepper1List = new List<Mesure>();
            List<Mesure> stepper2List = new List<Mesure>();

            logger.Debug("Start Mesures");
            for (int i = 1; i <= parameters.StepsCount; i++)
            {
                logger.Trace("Mesure for {0} step", i);   
                Thread.Sleep(parameters.DelayBeforeStep);

                var length = parameters.MesuresCount;
                double[] dataFromOscillatorArray = new double[length],
                    dataFromStepper1Array = new double[length],
                    dataFromStepper2Array = new double[length];
                
                for (int j = 0; j < parameters.MesuresCount; j++)
                {
                    dataFromOscillatorArray[j] = adc.Read(adcArduinoParams.OscillatorAdress);
                    dataFromStepper1Array[j] = adc.Read(adcArduinoParams.Stepper1Adress);
                    dataFromStepper2Array[j] = adc.Read(adcArduinoParams.Stepper2Adress);

                }
                stepper1List.Add(new Mesure(i, dataFromOscillatorArray,dataFromStepper1Array));
                stepper2List.Add(new Mesure(i+10, dataFromOscillatorArray, dataFromStepper2Array));

                mesuresList.AddRange(stepper1List);
                mesuresList.AddRange(stepper2List);

                Arduino.MakeOneStep();

            }
            logger.Debug("Finished Mesures");
            return mesuresList;
        }

        public static List<Mesure_My> GetMesures_My(MesureParameters parameters, AdcArduinoParams adcArduinoParams)
        {
            ModBus adc = new ModBus();
            adc.Connect();
            Arduino.Connect(adcArduinoParams.ArduinoComPort);

            var mesuresList = new List<Mesure_My>();

            logger.Debug("Start Mesures");
            for (int i = 0; i <= parameters.StepsCount; i++)
            {
                logger.Trace("Mesure for {0} step", i);
                Thread.Sleep(parameters.DelayBeforeStep);

                var length = parameters.MesuresCount;
                float[] dataFromSecondaryEmmisionMonitor = new float[length],
                    dataFromChannel1 = new float[length],
                    dataFromChannel2 = new float[length];

                for (int j = 0; j < parameters.MesuresCount; j++)
                {
                    dataFromSecondaryEmmisionMonitor[j] = adc.Read(adcArduinoParams.OscillatorAdress);
                    dataFromChannel1[j] = adc.Read(adcArduinoParams.Stepper1Adress);
                    dataFromChannel2[j] = adc.Read(adcArduinoParams.Stepper2Adress);
                }
                mesuresList.Add(new Mesure_My(i,dataFromSecondaryEmmisionMonitor, dataFromChannel1, dataFromChannel2));

              Arduino.MakeOneStep();

            }
            logger.Debug("Finished Mesures");
            adc.Disconnect();
            return mesuresList;
        }

        public static bool StartCalibration(AdcArduinoParams adcArduinoParams)
        {
            ModBus adc = new ModBus();
            adc.Connect();
           // Arduino.Connect(adcArduinoParams.ArduinoComPort);

            for (int i = 1; i <= 36; i++)
            {
                if (Step != null)
                {
                    Step(i);
                }
                float[] calibrationData = new float[10];
                for (int j = 0; j < calibrationData.Length; j++)
                {
                    //calibrationData[j] = adc.Read(adcArduinoParams.Stepper1Adress);
                }
                // if average value < 1 stepper in correct position
                if (calibrationData.Average() >= 1)
                {
                    adc.Disconnect();
                    return true;
                }
                    
                    Arduino.MakeOneStep();
                    Thread.Sleep(3000);
            }
            adc.Disconnect();
            return false;
        }

        public static event Action<int> Step;
    }

    public class MesuresLogicEvent : EventArgs
    {
       
        public string Message { get; private set; }
        public MesuresLogicEvent(string message)
        {
            Message = message;
        }


    }

}

