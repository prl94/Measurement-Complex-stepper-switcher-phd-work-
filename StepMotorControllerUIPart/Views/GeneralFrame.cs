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
using StepMotorControllerUIPart.Properties;
using StepMotorControllerUIPart.SettingsFolder;
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
            var mesures = GeneralLogic.StartMesures(_mesureParameters, _connectionParams, _resistors, _diaphragms);

            WritingToFile.WriteMesureToFile(mesures);


            var pointPairList = GraphLogic.GetDataForGraph(mesures);

            DrawLineGraph(pointPairList);

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


            GraphObjList obgList = new GraphObjList();


            // *** Выведем текст с фоном по умолчанию (с белым фоном) ***
            for (int i = 0; i < list.Count; i++)
            {

                TextObj temp = new TextObj((i + 1).ToString(), list[i].X + 0.03, list[i].Y + 0.05);

                // Отключим рамку вокруг текста
                temp.FontSpec.Border.IsVisible = false;
                temp.FontSpec.Fill = new Fill();
                obgList.Add(temp);

            }
            pane.GraphObjList.AddRange(obgList);


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


        private void updateBaseObjects()
        {
            _diaphragms = new Diaphragms();
            _resistors = new Resistors();



            var secondaryEmisionMonitor = new Adress(Settings.Default.SecondaryEmisionMonitorAdcNumber, Settings.Default.SecondaryEmisionMonitorChannelNumber);
            var channel1 = new Adress(Settings.Default.Channel1AdcNumber, Settings.Default.Channel1ChannelNumber);
            var channel2 = new Adress(Settings.Default.Channel2AdcNumber, Settings.Default.Channel2ChannelNumber);

            string arduinoPort = Settings.Default.ArduinoCOMPort;
            string ADCPort = Settings.Default.AKONCOMPort;

            _connectionParams = new ConnectionParams(ADCPort, arduinoPort, secondaryEmisionMonitor, channel1, channel2);


            int stepsCount = Convert.ToInt32(Settings.Default.StepsCount);
            int mesuresPerStep = Convert.ToInt32(Settings.Default.MesuresPerStep);
            int delayBeforeStep = Convert.ToInt32(Settings.Default.DelayBeforeStep);


            _mesureParameters = new MesureParams(stepsCount, mesuresPerStep, delayBeforeStep);

        }


        private void GeneralView_Shown(object sender, EventArgs e)
        {
            InitSettings();
            updateBaseObjects();
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


            RLabel.Text = Math.Abs( Math.Round(b/a, 4)).ToString();
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

            myCurve.Line.Width = 2;
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();

        }
        private void saveSattingsButton_Click(object sender, EventArgs e)
        {
            UpdateSettings();
            updateBaseObjects();
            MessageBox.Show("Дані збережено");

        }


        private void InitSettings()
        {

            StepsCountTextBox.Text = Settings.Default.StepsCount.ToString();
            MesuresPerStepTextBox.Text = Settings.Default.MesuresPerStep.ToString();
            DelayBeforeStepTextBox.Text = Settings.Default.DelayBeforeStep.ToString();

            AKONCOMPortTextBox.Text = Settings.Default.AKONCOMPort;

            SecondaryEmisionMonitorAdcNumberTextBox.Text = Settings.Default.SecondaryEmisionMonitorAdcNumber.ToString();
            SecondaryEmisionMonitorChannelNumberTextBox.Text = Settings.Default.SecondaryEmisionMonitorChannelNumber.ToString();

            Channel1AdcNumberTextBox.Text = Settings.Default.Channel1AdcNumber.ToString();
            Channel1ChannelNumberTextBox.Text = Settings.Default.Channel1ChannelNumber.ToString();

            Channel2AdcNumberTextBox.Text = Settings.Default.Channel2AdcNumber.ToString();
            Channel2ChannelNumberTextBox.Text = Settings.Default.Channel2ChannelNumber.ToString();

            ArduinoCOMPortTextBox.Text = Settings.Default.ArduinoCOMPort;

            R1textBox.Text = ResistorsStn.Default.R1.ToString();
            R2textBox.Text = ResistorsStn.Default.R2.ToString();
            R3textBox.Text = ResistorsStn.Default.R3.ToString();
            R4textBox.Text = ResistorsStn.Default.R4.ToString();
            R5textBox.Text = ResistorsStn.Default.R5.ToString();
            R6textBox.Text = ResistorsStn.Default.R6.ToString();
            R7textBox.Text = ResistorsStn.Default.R7.ToString();
            R8textBox.Text = ResistorsStn.Default.R8.ToString();
            R9textBox.Text = ResistorsStn.Default.R9.ToString();
            R10textBox.Text = ResistorsStn.Default.R10.ToString();
            R11textBox.Text = ResistorsStn.Default.R11.ToString();
            R12textBox.Text = ResistorsStn.Default.R12.ToString();
            R13textBox.Text = ResistorsStn.Default.R13.ToString();
            R14textBox.Text = ResistorsStn.Default.R14.ToString();
            R15textBox.Text = ResistorsStn.Default.R15.ToString();
            R16textBox.Text = ResistorsStn.Default.R16.ToString();
            R17textBox.Text = ResistorsStn.Default.R17.ToString();
            R18textBox.Text = ResistorsStn.Default.R18.ToString();
            R19textBox.Text = ResistorsStn.Default.R19.ToString();
            R20textBox.Text = ResistorsStn.Default.R20.ToString();

            D1textBox.Text = DiaphragmsStn.Default.D1.ToString();
            D2textBox.Text = DiaphragmsStn.Default.D2.ToString();
            D3textBox.Text = DiaphragmsStn.Default.D3.ToString();
            D4textBox.Text = DiaphragmsStn.Default.D4.ToString();
            D5textBox.Text = DiaphragmsStn.Default.D5.ToString();
            D6textBox.Text = DiaphragmsStn.Default.D6.ToString();
            D7textBox.Text = DiaphragmsStn.Default.D7.ToString();
            D8textBox.Text = DiaphragmsStn.Default.D8.ToString();
            D9textBox.Text = DiaphragmsStn.Default.D9.ToString();
            D10textBox.Text = DiaphragmsStn.Default.D10.ToString();
            D11textBox.Text = DiaphragmsStn.Default.D11.ToString();
            D12textBox.Text = DiaphragmsStn.Default.D12.ToString();
            D13textBox.Text = DiaphragmsStn.Default.D13.ToString();
            D14textBox.Text = DiaphragmsStn.Default.D14.ToString();
            D15textBox.Text = DiaphragmsStn.Default.D15.ToString();
            D16textBox.Text = DiaphragmsStn.Default.D16.ToString();
            D17textBox.Text = DiaphragmsStn.Default.D17.ToString();
            D18textBox.Text = DiaphragmsStn.Default.D18.ToString();
            D19textBox.Text = DiaphragmsStn.Default.D19.ToString();
            D20textBox.Text = DiaphragmsStn.Default.D20.ToString();


        }

        private void UpdateSettings()
        {
            Settings.Default.StepsCount = Convert.ToInt32(StepsCountTextBox.Text);
            Settings.Default.MesuresPerStep = Convert.ToInt32(MesuresPerStepTextBox.Text);
            Settings.Default.DelayBeforeStep = Convert.ToInt32(DelayBeforeStepTextBox.Text);

            Settings.Default.AKONCOMPort = AKONCOMPortTextBox.Text;

            Settings.Default.SecondaryEmisionMonitorAdcNumber = Convert.ToByte(SecondaryEmisionMonitorAdcNumberTextBox.Text);
            Settings.Default.SecondaryEmisionMonitorChannelNumber = Convert.ToByte(SecondaryEmisionMonitorChannelNumberTextBox.Text);

            Settings.Default.Channel1AdcNumber = Convert.ToByte(Channel1AdcNumberTextBox.Text);
            Settings.Default.Channel1ChannelNumber = Convert.ToByte(Channel1ChannelNumberTextBox.Text);

            Settings.Default.Channel2AdcNumber = Convert.ToByte(Channel2AdcNumberTextBox.Text);
            Settings.Default.Channel2ChannelNumber = Convert.ToByte(Channel2ChannelNumberTextBox.Text);

            Settings.Default.ArduinoCOMPort = ArduinoCOMPortTextBox.Text;

            Settings.Default.Save();

            ResistorsStn.Default.R1 = Convert.ToSingle(R1textBox.Text);
            ResistorsStn.Default.R2 = Convert.ToSingle(R2textBox.Text);
            ResistorsStn.Default.R3 = Convert.ToSingle(R3textBox.Text);
            ResistorsStn.Default.R4 = Convert.ToSingle(R4textBox.Text);
            ResistorsStn.Default.R5 = Convert.ToSingle(R5textBox.Text);
            ResistorsStn.Default.R6 = Convert.ToSingle(R6textBox.Text);
            ResistorsStn.Default.R7 = Convert.ToSingle(R7textBox.Text);
            ResistorsStn.Default.R8 = Convert.ToSingle(R8textBox.Text);
            ResistorsStn.Default.R9 = Convert.ToSingle(R9textBox.Text);
            ResistorsStn.Default.R10 = Convert.ToSingle(R10textBox.Text);
            ResistorsStn.Default.R11 = Convert.ToSingle(R11textBox.Text);
            ResistorsStn.Default.R12 = Convert.ToSingle(R12textBox.Text);
            ResistorsStn.Default.R13 = Convert.ToSingle(R13textBox.Text);
            ResistorsStn.Default.R14 = Convert.ToSingle(R14textBox.Text);
            ResistorsStn.Default.R15 = Convert.ToSingle(R15textBox.Text);
            ResistorsStn.Default.R16 = Convert.ToSingle(R16textBox.Text);
            ResistorsStn.Default.R17 = Convert.ToSingle(R17textBox.Text);
            ResistorsStn.Default.R18 = Convert.ToSingle(R18textBox.Text);
            ResistorsStn.Default.R19 = Convert.ToSingle(R19textBox.Text);
            ResistorsStn.Default.R20 = Convert.ToSingle(R20textBox.Text);

            ResistorsStn.Default.Save();

            DiaphragmsStn.Default.D1 = Convert.ToSingle(D1textBox.Text);
            DiaphragmsStn.Default.D2 = Convert.ToSingle(D2textBox.Text);
            DiaphragmsStn.Default.D3 = Convert.ToSingle(D3textBox.Text);
            DiaphragmsStn.Default.D4 = Convert.ToSingle(D4textBox.Text);
            DiaphragmsStn.Default.D5 = Convert.ToSingle(D5textBox.Text);
            DiaphragmsStn.Default.D6 = Convert.ToSingle(D6textBox.Text);
            DiaphragmsStn.Default.D7 = Convert.ToSingle(D7textBox.Text);
            DiaphragmsStn.Default.D8 = Convert.ToSingle(D8textBox.Text);
            DiaphragmsStn.Default.D9 = Convert.ToSingle(D9textBox.Text);
            DiaphragmsStn.Default.D10 = Convert.ToSingle(D10textBox.Text);
            DiaphragmsStn.Default.D11 = Convert.ToSingle(D11textBox.Text);
            DiaphragmsStn.Default.D12 = Convert.ToSingle(D12textBox.Text);
            DiaphragmsStn.Default.D13 = Convert.ToSingle(D13textBox.Text);
            DiaphragmsStn.Default.D14 = Convert.ToSingle(D14textBox.Text);
            DiaphragmsStn.Default.D15 = Convert.ToSingle(D15textBox.Text);
            DiaphragmsStn.Default.D16 = Convert.ToSingle(D16textBox.Text);
            DiaphragmsStn.Default.D17 = Convert.ToSingle(D17textBox.Text);
            DiaphragmsStn.Default.D18 = Convert.ToSingle(D18textBox.Text);
            DiaphragmsStn.Default.D19 = Convert.ToSingle(D19textBox.Text);
            DiaphragmsStn.Default.D20 = Convert.ToSingle(D20textBox.Text);

            DiaphragmsStn.Default.Save();

        }

    }


    }
    

