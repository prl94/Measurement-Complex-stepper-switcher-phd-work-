using System;
using System.IO;
using System.IO.Ports;
using NLog;

namespace StepMotorControllerUIPart.SerialPortClasses
{
    public static class Arduino
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static SerialPort _serialPort;

        public static bool IsConnected()
        {
            return _serialPort != null;
        }

        public static void Connect(string comPort)
        {
            if (_serialPort == null)
            {
                _serialPort = new SerialPort(comPort, 9600, Parity.None, 8, StopBits.One);
                try
                {
                    logger.Debug("Trying to open serial port: {0}",comPort);
                    _serialPort.Open();
                }
                catch (IOException e)
                {
                    logger.Error(e);
                    throw e;
                }
            }
            else
            {
                logger.Debug("Port already open {0}", comPort);
            }     
        }

        public static void Disconnect()
        {
            if (_serialPort != null)
            {
                try
                {
                    logger.Debug("Closing Serial Port");
                    _serialPort.Close();
                }
                catch (IOException e)
                {
                    logger.Error(e);
                    throw e;
                }

            }
        }

        public static string[] GetAvaiblePorts()
        {
            return SerialPort.GetPortNames();
        }

        public static void MakeOneStep()
        {
            makeStep(1);
        }
        public static void MakeSteps(byte steps)
        {
            makeStep(steps);
        }

        private static void makeStep(byte steps)
        {
            if (IsConnected())
            {
                try
                {
                    byte[] data = { 255, steps};
                    logger.Trace("Send request to SerialPort to make {0} steps", steps);
                    _serialPort.Write(data, 0, data.Length);
                }
                catch (Exception e)
                {
                    logger.Error(e);
                    throw e;
                }
            }
            else
            {
                logger.Debug("Port did not open");
            }

        }

    }
}
