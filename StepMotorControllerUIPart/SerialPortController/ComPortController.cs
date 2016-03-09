﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Ports;
using System.Linq;
using StepMotorControllerUIPart.DTO;
using StepMotorControllerUIPart.Helper;

namespace StepMotorControllerUIPart.SerialPortController
{
    public static class ComPortController
    {
        private static SerialPort _port;

        public static bool PortIsOpen()
        {
            return _port != null;
        }

        public static bool TryOpenPort(string comPort)
        {
            if (_port==null)
            {
                _port = new SerialPort(comPort, 9600, Parity.None, 8, StopBits.One);
                try
                {
                    _port.Open();
                }
                catch (IOException exception)
                {
                    System.Console.WriteLine(exception);
                }
                return true;
            }
            else if (_port.PortName.Contains(comPort) && _port.IsOpen)
            {
                return true;
            }
            else
            {
                Console.WriteLine(@"Connection already open on port "+_port.PortName);
                return false;
            }        
        }

        public static void ClosePort()
        {
            _port.Close();
        }

        public static object[] GetAvaiblePorts()
        {
            return SerialPort.GetPortNames();
        }



        private static bool MakeOneStep()
        {
            if (_port == null)
            {
                return false;
            }
            bool switched = false;
                
            byte[] data = {255, 1};
            _port.Write(data, 0, data.Length);
      
            while (!switched)
            {
                if(_port.ReadLine().Contains("switched"))
                   switched = true;         
            }
            return switched;
            }
        


        public static bool SendDataToSwitcherController(byte count)
        {
            if (_port == null)
            {
                return false;
            }
            else
            {
                byte[] data = {255, count};
                _port.Write(data, 0, data.Length);
                return true;
            }
        }

        public static List<MesureDto> StartMesures(ParametersDto mesureParameters)
        {
            var mesuresPack = new List<MesureDto>();
            for (int i = 0; i <= mesureParameters.StepsCount; i++)
            {
                mesuresPack.Add(CatchStepDataPack(i, mesureParameters.MesuresCount));
            }
            return mesuresPack;
        }

        private static MesureDto CatchStepDataPack(int step, int mesurements)
        {

            var dataFromOscillatorRandomArray = new double[mesurements];
            var dataFromSwitcherRandomArray = new double[mesurements];
           
            // hear listed data from adt
            for (int n = 0; n < mesurements; n++)
            {
                dataFromOscillatorRandomArray[n] = ThreadSafeRandom.NextDouble();
                dataFromSwitcherRandomArray[n] = ThreadSafeRandom.NextDouble();
            }
            return new MesureDto(step, dataFromOscillatorRandomArray, dataFromSwitcherRandomArray);
        }






        public static List<MesureDto> GetTestMesuresList(ParametersDto mesureParameters)
        {
            return StartMesures(mesureParameters);
        }
    }
}
