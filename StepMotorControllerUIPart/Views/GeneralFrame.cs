using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
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

        private Diaphragms _diaphragms;
        private Resistors _resistors;
        private Adress _secondaryEmisionMonitor, _channel1, _channel2;
        private String _arduinoPort;



        private AdcArduinoParams _adcs;

        private int _steps;
        private int _seconds;


        public GeneralView()
        {
            InitializeComponent();
            serialPortsComboBox.Items.AddRange(Arduino.GetAvaiblePorts());
            //ConfigReader.GetResistors();
            // dataGridView1.Rows.Add();

            // init colors in constructor
            arduinoComPortLabel.BackColor = Color.Red;
            calibrationLabel.BackColor = Color.Red;
        }
  
        private void startButton_Click(object sender, EventArgs e)
        {
            int steps = Int32.Parse(stepsCountTextBox.Text);
            int mesuresCount = Int32.Parse(mesureCountTextBox.Text);
            int delay = Int32.Parse(delayBeforeStepTextBox.Text);
            
              var parameters = new MesureParameters(steps, mesuresCount, delay);
            

            _adcs = new AdcArduinoParams("COM1", "COM3", _secondaryEmisionMonitor,_channel1,_channel2);

            var mesures = GeneralLogic.GetListOfMesures(parameters, _adcs);
            WritingToFile.WriteMesure_MyToFile(mesures);

          //  var resistors =  ConfigReader.GetSettings("Resistors.config");
           
           // Arduino.Connect("COM3");
            //Arduino.MakeSteps(5);
            //ParametersDto parameters = new ParametersDto(,I);

        }

        private void serialPortsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             Arduino.Connect(serialPortsComboBox.SelectedItem.ToString());
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
            pane.XAxis.Title.Text = "Пластини";
            pane.YAxis.Title.Text = "Ic/Iеф";

            pane.CurveList.Clear();

  
            LineItem myCurve = pane.AddCurve("Sinc", list, Color.Blue, SymbolType.None);

            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();
        }

        private void ShowMessageBox(string message)
        {
            MessageBox.Show(message, "Important Message");
        }



        private void drawGraph_Click(object sender, EventArgs e)
        {
            
           // ParametersDto parameters = new ParametersDto(Int32.Parse(stepsCountTextBox.Text),Int32.Parse(mesuresCountTextBox.Text));
          
         //   DrawLineGraph( GlobalController.StartTestMesures(parameters));
           
        }
        private void CalibrationButton_Click(object sender, EventArgs e)
        {
            GeneralLogic.CalibrationFinish += GeneralLogic_CalibrationFinish;

            bool calibrated =  GeneralLogic.Calibration(_adcs);
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


        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void GeneralView_Load(object sender, EventArgs e)
        {

            // inserting data from config file
            _diaphragms = new Diaphragms(ConfigReader.GetDiaphragmas());
            _resistors = new Resistors(ConfigReader.GetResistors());
            _secondaryEmisionMonitor = ConfigReader.GetAdress(Constans.SecondaryEmisionMonitorAdcNumber,
                Constans.SecondaryEmisionMonitorChannelNumber);
            _channel1 = ConfigReader.GetAdress(Constans.Channel1AdcNumber, Constans.Channel1ChannelNumber);
            _channel2 = ConfigReader.GetAdress(Constans.Channel2AdcNumber, Constans.Channel2ChannelNumber);
        }
    }
    
}
