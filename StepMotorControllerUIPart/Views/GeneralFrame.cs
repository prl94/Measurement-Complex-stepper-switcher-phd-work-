using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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
         //   GeneralLogic.MesureStep += GeneralLogic_MesureStep;

            var mesures = GeneralLogic.StartMesures(_mesureParameters, _connectionParams, _resistors, _diaphragms);

            WritingToFile.WriteMesureToFile(mesures);


            var pointPairList = GraphLogic.GetDataForGraph(mesures);

            DrawLineGraph(pointPairList);
        }

   /*     private void GeneralLogic_MesureStep(int obj)
        {

            stepCountLabel.Text  = Convert.ToString(obj);
            }*/

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
            
            myCurve.Symbol.Fill.Type = FillType.Solid;
            myCurve.Symbol.Size = 5;

            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();

            ShowMessageBox("виберіть лінійний участок");
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

        private void zedGraph_MouseClick(object sender, MouseEventArgs e)
        {
            // Сюда будет сохранена кривая, рядом с которой был произведен клик
            CurveItem curve;

            // Сюда будет сохранен номер точки кривой, ближайшей к точке клика
            int index;

            GraphPane pane = zedGraph.GraphPane;

            // Максимальное расстояние от точки клика до кривой в пикселях, 
            // при котором еще считается, что клик попал в окрестность кривой.
            GraphPane.Default.NearestTol = 10;

            bool result = pane.FindNearestPoint(e.Location, out curve, out index);

            if (result)
            {
                // Максимально расстояние от точки клика до кривой не превысило NearestTol

                // Добавим точку на график, вблизи которой произошел клик
                PointPairList point = new PointPairList();

                point.Add(curve[index]);

                // Кривая, состоящая из одной точки. Точка будет отмечена синим кругом
                LineItem curvePount = pane.AddCurve("",
                    new double[] { curve[index].X },
                    new double[] { curve[index].Y },
                    Color.Red,
                    SymbolType.Circle);

                // 
                curvePount.Line.IsVisible = false;

                // Цвет заполнения круга - колубой
                curvePount.Symbol.Fill.Color = Color.Red;

                // Тип заполнения - сплошная заливка
                curvePount.Symbol.Fill.Type = FillType.Solid;

                // Размер круга
                curvePount.Symbol.Size = 7;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int point1 = Convert.ToInt32(dot1TextBox.Text) - 1;
            int point2 = Convert.ToInt32(dot2TextBox.Text) - 1;

            var graphData = GraphLogic.FinalDataArray;
            graphData.Skip(point1);
      
            var linearSection = new SortedList<double, double>();

            for (int i = point1; i <= point2; i++)
            {
               var elem = graphData.ElementAt(i);
               linearSection.Add(elem.Key,elem.Value);
            }

            _calculateLine(linearSection);
        }

        private void _calculateLine(SortedList<double, double> list)
        {


            double[] xPoints = new double[list.Count];
            double[] yPoints = new double[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                var elem = list.ElementAt(i);
                xPoints[i] = elem.Key;
                yPoints[i] = elem.Value;

            }

            LinearRegression ln = new LinearRegression(xPoints, yPoints);

            double a = ln.a;
            double b = ln.b;


            RLabel.Text = Math.Abs( Math.Round(a, 4)).ToString();
            // y = a*x + b 

            double x1 = 0;
            // y = a * x + b, x = x1
            double y1 = a * x1 + b;


            double y2 = 0;
            // x = (y - b) / a, y = y2
            double x2 = (y2 - b) / a;



            var st = "E 2 =0,423+4,69*R p +0,0532*R p 2";





            var line = new PointPairList();
            line.Add(x1, y1);
            line.Add(x2, y2);

            DrawLine(line);
        }

        private void DrawLine(PointPairList list)
        {
            GraphPane pane = zedGraph.GraphPane;


            LineItem myCurve = pane.AddCurve("", list, Color.Red, SymbolType.None);

            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }


    }
    

