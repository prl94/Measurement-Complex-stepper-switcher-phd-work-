using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using StepMotorControllerUIPart.Controller;
using StepMotorControllerUIPart.DTO;
using StepMotorControllerUIPart.SerialPortController;
using ZedGraph;

namespace StepMotorControllerUIPart.View
{
    public partial class Form1 : Form
    {
        private int _steps;
        private int _seconds;


        public Form1()
        {
            InitializeComponent();
            serialPortsComboBox.Items.AddRange(ComPortController.GetAvaiblePorts());
        }
  
        private void startButton_Click(object sender, EventArgs e)
        {
            ParametersDto parameters = new ParametersDto(Int32.Parse(stepsCountTextBox.Text),Int32.Parse(mesuresCountTextBox.Text));
        }

        private void serialPortsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             var state = ComPortController.TryOpenPort(serialPortsComboBox.SelectedItem.ToString());
            Console.WriteLine(@"Port " + serialPortsComboBox.SelectedItem + @"is open? " + state);
            if (!state)
            {
                ShowMessageBox(@"Port " + serialPortsComboBox.SelectedItem + @"is open? " + state);
            }
        }

        private void DrawLineGraph(PointPairList list)
        {
            GraphPane pane = zedGraph.GraphPane;
            pane.Title.Text = "";
            pane.XAxis.Title.Text = "Пластини";
            pane.YAxis.Title.Text = "Ic/Iеф";

            pane.CurveList.Clear();

            double xmin = -50;
            double xmax = 50;

            // Заполняем список точек
            for (double x = xmin; x <= xmax; x += 0.01)
            {
                list.Add(x, x);
            }
            LineItem myCurve = pane.AddCurve("Sinc", list, Color.Blue, SymbolType.None);

            zedGraph.AxisChange();

            // !!!
            // Линию рисуем после обновления осей с помощью AxisChange (), 
            // так как мы будем использовать значения
            // Нарисуем горизонтальную пунктирную линию от левого края до правого на уровне y = 0.5
            double level = 0.5;
            LineObj line = new LineObj(pane.XAxis.Scale.Min, level, pane.XAxis.Scale.Max, level);

            // Стиль линии - пунктирная
            line.Line.Style = System.Drawing.Drawing2D.DashStyle.Dash;

            // Добавим линию в список отображаемых объектов
            pane.GraphObjList.Add(line);


            // Обновляем график
            zedGraph.Invalidate();
        }

        private void ShowMessageBox(string message)
        {
            MessageBox.Show(message, "Important Message");
        }



        private void drawGraph_Click(object sender, EventArgs e)
        {
            ParametersDto parameters = new ParametersDto(Int32.Parse(stepsCountTextBox.Text),Int32.Parse(mesuresCountTextBox.Text));

            DrawLineGraph( GlobalController.StartTestMesures(parameters));



        }

    }
    
}
