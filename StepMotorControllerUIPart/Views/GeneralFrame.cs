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
        private int _steps;
        private int _seconds;


        public GeneralView()
        {
            InitializeComponent();
            serialPortsComboBox.Items.AddRange(Arduino.GetAvaiblePorts());
            //ConfigReader.GetResistors();
           // dataGridView1.Rows.Add();
            
            new ColumnHeader();
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
            AdcArduinoParams adcs = new AdcArduinoParams("COM3", a1,a2,a3);

            var mesures1 = MesuresLogic.GetMesures_My(paraeters, adcs);
            WritingToFile.WriteMesure_MyToFile(mesures1);

          //  var resistors =  ConfigReader.GetSettings("Resistors.config");
           
           // Arduino.Connect("COM3");
            //Arduino.MakeSteps(5);
            //ParametersDto parameters = new ParametersDto(,I);

        }

        private void serialPortsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
       Arduino.Connect(serialPortsComboBox.SelectedItem.ToString());
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
        
    }
    
}
