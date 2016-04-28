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
        private AdcArduinoParams adcs;

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
            int mesures = Int32.Parse(mesureCountTextBox.Text);
            int delay = Int32.Parse(delayBeforeStepTextBox.Text);
            var paraeters = new MesureParameters(steps, mesures, delay);
            
            Adress a1 = new Adress(1, 1);
            Adress a2 = new Adress(1, 2);
            Adress a3 = new Adress(1, 3);
            adcs = new AdcArduinoParams("COM3", a1,a2,a3);

            var mesures1 = GeneralLogic.GetMesures_My(paraeters, adcs);
            WritingToFile.WriteMesure_MyToFile(mesures1);

          //  var resistors =  ConfigReader.GetSettings("Resistors.config");
           
           // Arduino.Connect("COM3");
            //Arduino.MakeSteps(5);
            //ParametersDto parameters = new ParametersDto(,I);

        }

        private void serialPortsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           // backgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;

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
            GeneralLogic.Step += GeneralLogic_Step;
            bool calibrated =  GeneralLogic.StartCalibration(adcs);
            if (calibrated)
            {
                calibrationLabel.BackColor = Color.GreenYellow;
                CalibrationButton.Enabled = false;
            }
        }

        private void GeneralLogic_Step(int obj)
        {
            MessageBox.Show("step: " + obj);
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
    }
    
}
