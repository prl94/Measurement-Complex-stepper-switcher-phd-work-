using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using StepMotorControllerUIPart.Helper;
using StepMotorControllerUIPart.SerialPortClasses;
using StepMotorControllerUIPart.UsedTypes;
using StepMotorControllerUIPart.Logic;

using ZedGraph;

namespace StepMotorControllerUIPart.View
{
    public partial class GeneralView : Form
    {

        Thread _myThread;

        private Diaphragms _diaphragms;
        private Resistors _resistors;
        private ConnectionParams _connectionParams;
        private MesureParams _mesureParameters;


        public GeneralView()
        {
            InitializeComponent();
            serialPortsComboBox.Items.AddRange(Arduino.GetAvaiblePorts());
            arduinoComPortLabel.BackColor = Color.Red;
            calibrationLabel.BackColor = Color.Red;
        }
  
        private void startButton_Click(object sender, EventArgs e)
        {
            _myThread = new Thread(startMesures);
            _myThread.Start();

        }

        private void startMesures()
        {
            GeneralLogic.MesureStep += GeneralLogic_MesureStep;

            var mesures = GeneralLogic.StartMesures(_mesureParameters, _connectionParams, _resistors, _diaphragms);

            WritingToFile.WriteMesureToFile(mesures);


            var pointPairList = GraphLogic.GetDataForGraph(mesures);

            DrawLineGraph(pointPairList);
        }

        private void GeneralLogic_MesureStep(int obj)
        {

            stepCountLabel.Text  = Convert.ToString(obj);
            }

        private void serialPortsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             //Arduino.Connect(serialPortsComboBox.SelectedItem.ToString());
            arduinoComPortLabel.BackColor = Color.GreenYellow;
            //   Console.WriteLine(@"Port " + serialPortsComboBox.SelectedItem + @"is open? " + state);
            //  if (!state)
            {
            //    ShowMessageBox(@"Port " + serialPortsComboBox.SelectedItem + @"is open? " + state);
            }
        }

        private void DrawLineGraph(PointPairList list)
        {
            GraphPane pane = zedGraph.GraphPane;
            pane.Title.Text = "";
            pane.XAxis.Title.Text = "d, CM";
            pane.YAxis.Title.Text = "T";
            pane.Legend.IsVisible = false;
            pane.CurveList.Clear();

  
            LineItem myCurve = pane.AddCurve("Sinc", list, Color.Blue, SymbolType.Circle);
            myCurve.Symbol.Size = 3;

            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();
        }

        private void ShowMessageBox(string message)
        {
            MessageBox.Show(message, "Important Message");
        }

        private void CalibrationButton_Click(object sender, EventArgs e)
        {
            GeneralLogic.CalibrationFinish += GeneralLogic_CalibrationFinish;

            bool calibrated =  GeneralLogic.Calibration(_connectionParams);
            if (calibrated)
            {
                CalibrationButton.Enabled = false;
            }
        }

        private void GeneralLogic_CalibrationFinish(bool obj)
        {
            if (obj)
            {
                MessageBox.Show("Калібрація закінчилась, кроковий двигун в позиції 1В");
                calibrationLabel.BackColor = Color.GreenYellow;
            }
            MessageBox.Show("Калібрація закінчилась невдало");
        }

        private void GeneralView_Shown(object sender, EventArgs e)
        {
            // take data from config file
            _diaphragms = new Diaphragms(ConfigReader.GetDiaphragmas());
            _resistors = new Resistors(ConfigReader.GetResistors());
            var secondaryEmisionMonitor = ConfigReader.GetAdress(Constans.SecondaryEmisionMonitorAdcNumber,
                Constans.SecondaryEmisionMonitorChannelNumber);
            var channel1 = ConfigReader.GetAdress(Constans.Channel1AdcNumber, Constans.Channel1ChannelNumber);
            var channel2 = ConfigReader.GetAdress(Constans.Channel2AdcNumber, Constans.Channel2ChannelNumber);

            string arduinoPort = ConfigurationManager.AppSettings["ArduinoPort"];
            string ADCPort = ConfigurationManager.AppSettings["ADCPort"];

            _connectionParams = new ConnectionParams(ADCPort, arduinoPort, secondaryEmisionMonitor, channel1, channel2);


            int stepsCount = Convert.ToInt32(ConfigurationManager.AppSettings["StepsCount"]);
            int mesuresPerStep = Convert.ToInt32(ConfigurationManager.AppSettings["MesuresPerStep"]);
            int delayBeforeStep = Convert.ToInt32(ConfigurationManager.AppSettings["DelayBeforeStep"]);
            _mesureParameters = new MesureParams(stepsCount, mesuresPerStep, delayBeforeStep);
        }


    }
    
}
