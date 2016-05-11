using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using NLog;
using RADON.SerialPortClasses;
using RADON.SerialPortClasses.test;
using StepMotorControllerUIPart.SerialPortClasses;
using StepMotorControllerUIPart.UsedTypes;

namespace StepMotorControllerUIPart.Logic
{
    public static class GeneralLogic
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static bool Calibration(ConnectionParams connectionParams)
        {
            IModBus adc = new ModBus(connectionParams.ModBusComPort);
            IArduino arduino = new Arduino(connectionParams.ArduinoComPort);
            
            adc.Connect();
            arduino.Connect();

            if (CalibrationStart != null) CalibrationStart();

            for (int i = 1; i <= 36; i++)
            {
                if (CalibrationStep != null) CalibrationStep(i);
                float[] calibrationData = new float[10];
                for (int j = 0; j < calibrationData.Length; j++)
                {
                    calibrationData[j] = adc.Read(connectionParams.Channel1Adress);
                }
                // if average value < 1 stepper in correct position
                if (calibrationData.Average() >= 1)
                {
                    adc.Disconnect();

                    if (CalibrationFinish != null) CalibrationFinish(true);

                    return true;
                }

                    arduino.MakeOneStep();
                    Thread.Sleep(3000);
            }
            adc.Disconnect();
            arduino.Disconnect();

            if (CalibrationFinish != null) CalibrationFinish(false);
            return false;
        }

        public static event Action CalibrationStart;
        public static event Action<int> CalibrationStep;
        public static event Action<bool> CalibrationFinish;

        //todo current realisation works only to 10 steps rework for ability work with 12
        public static List<Mesure> StartMesures(MesureParams mesureParams, ConnectionParams connectionParams, Resistors resistors, Diaphragms diaphragms)
        {

          //  IModBus adc = new ModBus(connectionParams.ModBusComPort);
          //  IArduino arduino = new Arduino(connectionParams.ArduinoComPort);

            IModBus adc = new ModBusTest();
            IArduino arduino = new ArduinoTest();

            adc.Connect();
            arduino.Connect();

            var mesuresList = new List<Mesure>();

            List<Mesure> stepper1List = new List<Mesure>();
            List<Mesure> stepper2List = new List<Mesure>();

            logger.Debug("Start Mesures");
            for (int i = 1; i <= mesureParams.StepsCount; i++)
            {
                logger.Trace("Mesure for {0} step", i);

                arduino.MakeOneStep();
                Thread.Sleep(mesureParams.DelayAfterStep);

                var length = mesureParams.MesuresCount;
                float[] dataFromOscillatorArray = new float[length],
                    dataFromStepper1Array = new float[length],
                    dataFromStepper2Array = new float[length];

                for (int j = 0; j < mesureParams.MesuresCount; j++)
                {
                    dataFromOscillatorArray[j] = adc.Read(connectionParams.SecondaryEmisionMonitorAdress);
                    dataFromStepper1Array[j] = adc.Read(connectionParams.Channel1Adress);
                    dataFromStepper2Array[j] = adc.Read(connectionParams.Channel2Adress);

                }
                stepper1List.Add(new Mesure(i, dataFromOscillatorArray, dataFromStepper1Array,resistors.ResistorsArray[i-1],diaphragms.DiaphragmsArray[i-1]));
                stepper2List.Add(new Mesure(i + 10, dataFromOscillatorArray, dataFromStepper2Array,resistors.ResistorsArray[(i-1)+10],diaphragms.DiaphragmsArray[(i-1)+10]));
    
            }
            mesuresList.AddRange(stepper1List);
            mesuresList.AddRange(stepper2List);

            adc.Disconnect();
            arduino.Disconnect();

            logger.Debug("Finished Mesures");
            return mesuresList;
        }
    }

}

