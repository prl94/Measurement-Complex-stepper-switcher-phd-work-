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
        
        public static bool Calibration(AdcArduinoParams adcArduinoParams)
        {
            ModBus adc = new ModBus();
            adc.Connect();
            Arduino.Connect(adcArduinoParams.ArduinoComPort);

            if (CalibrationStart != null) CalibrationStart();

            for (int i = 1; i <= 36; i++)
            {
                if (CalibrationStep != null) CalibrationStep(i);
                float[] calibrationData = new float[10];
                for (int j = 0; j < calibrationData.Length; j++)
                {
                    calibrationData[j] = adc.Read(adcArduinoParams.Stepper1Adress);
                }
                // if average value < 1 stepper in correct position
                if (calibrationData.Average() >= 1)
                {
                    adc.Disconnect();

                    if (CalibrationFinish != null) CalibrationFinish(true);

                    return true;
                }

                    Arduino.MakeOneStep();
                    Thread.Sleep(3000);
            }
            adc.Disconnect();
            if (CalibrationFinish != null) CalibrationFinish(false);
            return false;
        }

        public static event Action CalibrationStart;
        public static event Action<int> CalibrationStep;
        public static event Action<bool> CalibrationFinish;


        public static List<Mesure> GetMesures(MesureParameters parameters, AdcArduinoParams adcArduinoParams, Resistors resistors, Diaphragms diaphragms)
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
                
                Arduino.MakeOneStep();
                Thread.Sleep(parameters.DelayAfterStep);

                var length = parameters.MesuresCount;
                float[] dataFromOscillatorArray = new float[length],
                    dataFromStepper1Array = new float[length],
                    dataFromStepper2Array = new float[length];

                for (int j = 0; j < parameters.MesuresCount; j++)
                {
                    dataFromOscillatorArray[j] = adc.Read(adcArduinoParams.OscillatorAdress);
                    dataFromStepper1Array[j] = adc.Read(adcArduinoParams.Stepper1Adress);
                    dataFromStepper2Array[j] = adc.Read(adcArduinoParams.Stepper2Adress);

                }
                stepper1List.Add(new Mesure(i, dataFromOscillatorArray, dataFromStepper1Array,resistors.ResistorsArray[i-1],diaphragms.DiaphragmsArray[i-1]));
                stepper2List.Add(new Mesure(i + 10, dataFromOscillatorArray, dataFromStepper2Array,resistors.ResistorsArray[(i-1)+10],diaphragms.DiaphragmsArray[(i-1)+10]));

                mesuresList.AddRange(stepper1List);
                mesuresList.AddRange(stepper2List);
            }
            logger.Debug("Finished Mesures");
            return mesuresList;
        }
    }

}

