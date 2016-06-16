namespace StepMotorControllerUIPart.View
{
    partial class GeneralView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.stepsCountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.serialPortsComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.delayBeforeStepTextBox = new System.Windows.Forms.TextBox();
            this.mesureCountTextBox = new System.Windows.Forms.TextBox();
            this.arduinoComPortLabel = new System.Windows.Forms.Label();
            this.calibrationLabel = new System.Windows.Forms.Label();
            this.CalibrationButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.stepCountLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.RLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dot2TextBox = new System.Windows.Forms.TextBox();
            this.dot1TextBox = new System.Windows.Forms.TextBox();
            this.SettingsTabPage = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.AKONCOMPortTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ArduinoCOMPortTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.SecondaryEmisionMonitorAdcNumberTextBox = new System.Windows.Forms.TextBox();
            this.SecondaryEmisionMonitorChannelNumberTextBox = new System.Windows.Forms.TextBox();
            this.Channel1AdcNumberTextBox = new System.Windows.Forms.TextBox();
            this.Channel1ChannelNumberTextBox = new System.Windows.Forms.TextBox();
            this.Channel2AdcNumberTextBox = new System.Windows.Forms.TextBox();
            this.Channel2ChannelNumberTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.SettingsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кількість кроків";
            // 
            // stepsCountTextBox
            // 
            this.stepsCountTextBox.Location = new System.Drawing.Point(159, 195);
            this.stepsCountTextBox.Name = "stepsCountTextBox";
            this.stepsCountTextBox.Size = new System.Drawing.Size(46, 20);
            this.stepsCountTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кількість вимірів";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(25, 290);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(101, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // serialPortsComboBox
            // 
            this.serialPortsComboBox.FormattingEnabled = true;
            this.serialPortsComboBox.Location = new System.Drawing.Point(29, 453);
            this.serialPortsComboBox.Name = "serialPortsComboBox";
            this.serialPortsComboBox.Size = new System.Drawing.Size(86, 21);
            this.serialPortsComboBox.TabIndex = 5;
            this.serialPortsComboBox.Text = "COMPORT";
            this.serialPortsComboBox.SelectedIndexChanged += new System.EventHandler(this.serialPortsComboBox_SelectedIndexChanged);
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(362, 6);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(591, 381);
            this.zedGraph.TabIndex = 6;
            this.zedGraph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.zedGraph_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Параметри ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Затримка після кроку";
            // 
            // delayBeforeStepTextBox
            // 
            this.delayBeforeStepTextBox.Location = new System.Drawing.Point(159, 255);
            this.delayBeforeStepTextBox.Name = "delayBeforeStepTextBox";
            this.delayBeforeStepTextBox.Size = new System.Drawing.Size(46, 20);
            this.delayBeforeStepTextBox.TabIndex = 10;
            // 
            // mesureCountTextBox
            // 
            this.mesureCountTextBox.Location = new System.Drawing.Point(159, 224);
            this.mesureCountTextBox.Name = "mesureCountTextBox";
            this.mesureCountTextBox.Size = new System.Drawing.Size(46, 20);
            this.mesureCountTextBox.TabIndex = 11;
            // 
            // arduinoComPortLabel
            // 
            this.arduinoComPortLabel.AutoSize = true;
            this.arduinoComPortLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.arduinoComPortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arduinoComPortLabel.Location = new System.Drawing.Point(22, 428);
            this.arduinoComPortLabel.Name = "arduinoComPortLabel";
            this.arduinoComPortLabel.Size = new System.Drawing.Size(115, 17);
            this.arduinoComPortLabel.TabIndex = 12;
            this.arduinoComPortLabel.Text = "Arduino ComPort";
            // 
            // calibrationLabel
            // 
            this.calibrationLabel.AutoSize = true;
            this.calibrationLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calibrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calibrationLabel.Location = new System.Drawing.Point(172, 428);
            this.calibrationLabel.Name = "calibrationLabel";
            this.calibrationLabel.Size = new System.Drawing.Size(79, 17);
            this.calibrationLabel.TabIndex = 13;
            this.calibrationLabel.Text = "Калібрація";
            // 
            // CalibrationButton
            // 
            this.CalibrationButton.Location = new System.Drawing.Point(175, 448);
            this.CalibrationButton.Name = "CalibrationButton";
            this.CalibrationButton.Size = new System.Drawing.Size(75, 23);
            this.CalibrationButton.TabIndex = 14;
            this.CalibrationButton.Text = "Калібрація";
            this.CalibrationButton.UseVisualStyleBackColor = true;
            this.CalibrationButton.Click += new System.EventHandler(this.CalibrationButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Номер кроку :";
            // 
            // stepCountLabel
            // 
            this.stepCountLabel.AutoSize = true;
            this.stepCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepCountLabel.Location = new System.Drawing.Point(117, 386);
            this.stepCountLabel.Name = "stepCountLabel";
            this.stepCountLabel.Size = new System.Drawing.Size(16, 18);
            this.stepCountLabel.TabIndex = 16;
            this.stepCountLabel.Text = "0";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.generalTabPage);
            this.tabControl1.Controls.Add(this.SettingsTabPage);
            this.tabControl1.Location = new System.Drawing.Point(4, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 525);
            this.tabControl1.TabIndex = 17;
            // 
            // generalTabPage
            // 
            this.generalTabPage.Controls.Add(this.RLabel);
            this.generalTabPage.Controls.Add(this.label8);
            this.generalTabPage.Controls.Add(this.button1);
            this.generalTabPage.Controls.Add(this.label7);
            this.generalTabPage.Controls.Add(this.label6);
            this.generalTabPage.Controls.Add(this.dot2TextBox);
            this.generalTabPage.Controls.Add(this.dot1TextBox);
            this.generalTabPage.Controls.Add(this.label3);
            this.generalTabPage.Controls.Add(this.zedGraph);
            this.generalTabPage.Controls.Add(this.stepCountLabel);
            this.generalTabPage.Controls.Add(this.stepsCountTextBox);
            this.generalTabPage.Controls.Add(this.label5);
            this.generalTabPage.Controls.Add(this.label1);
            this.generalTabPage.Controls.Add(this.CalibrationButton);
            this.generalTabPage.Controls.Add(this.label2);
            this.generalTabPage.Controls.Add(this.calibrationLabel);
            this.generalTabPage.Controls.Add(this.arduinoComPortLabel);
            this.generalTabPage.Controls.Add(this.startButton);
            this.generalTabPage.Controls.Add(this.label4);
            this.generalTabPage.Controls.Add(this.serialPortsComboBox);
            this.generalTabPage.Controls.Add(this.mesureCountTextBox);
            this.generalTabPage.Controls.Add(this.delayBeforeStepTextBox);
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalTabPage.Size = new System.Drawing.Size(972, 499);
            this.generalTabPage.TabIndex = 0;
            this.generalTabPage.Text = "Головна";
            this.generalTabPage.UseVisualStyleBackColor = true;
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.Location = new System.Drawing.Point(654, 415);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(13, 13);
            this.RLabel.TabIndex = 23;
            this.RLabel.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(621, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "R = ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "рахувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "точка 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "точка 1";
            // 
            // dot2TextBox
            // 
            this.dot2TextBox.Location = new System.Drawing.Point(473, 428);
            this.dot2TextBox.Name = "dot2TextBox";
            this.dot2TextBox.Size = new System.Drawing.Size(23, 20);
            this.dot2TextBox.TabIndex = 18;
            // 
            // dot1TextBox
            // 
            this.dot1TextBox.Location = new System.Drawing.Point(473, 401);
            this.dot1TextBox.Name = "dot1TextBox";
            this.dot1TextBox.Size = new System.Drawing.Size(23, 20);
            this.dot1TextBox.TabIndex = 17;
            // 
            // SettingsTabPage
            // 
            this.SettingsTabPage.Controls.Add(this.Channel2AdcNumberTextBox);
            this.SettingsTabPage.Controls.Add(this.Channel2ChannelNumberTextBox);
            this.SettingsTabPage.Controls.Add(this.Channel1AdcNumberTextBox);
            this.SettingsTabPage.Controls.Add(this.Channel1ChannelNumberTextBox);
            this.SettingsTabPage.Controls.Add(this.SecondaryEmisionMonitorChannelNumberTextBox);
            this.SettingsTabPage.Controls.Add(this.SecondaryEmisionMonitorAdcNumberTextBox);
            this.SettingsTabPage.Controls.Add(this.ArduinoCOMPortTextBox);
            this.SettingsTabPage.Controls.Add(this.label18);
            this.SettingsTabPage.Controls.Add(this.label16);
            this.SettingsTabPage.Controls.Add(this.label17);
            this.SettingsTabPage.Controls.Add(this.label14);
            this.SettingsTabPage.Controls.Add(this.label15);
            this.SettingsTabPage.Controls.Add(this.label13);
            this.SettingsTabPage.Controls.Add(this.label12);
            this.SettingsTabPage.Controls.Add(this.AKONCOMPortTextBox);
            this.SettingsTabPage.Controls.Add(this.label11);
            this.SettingsTabPage.Controls.Add(this.saveSettingsButton);
            this.SettingsTabPage.Controls.Add(this.label10);
            this.SettingsTabPage.Controls.Add(this.label9);
            this.SettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.SettingsTabPage.Name = "SettingsTabPage";
            this.SettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTabPage.Size = new System.Drawing.Size(972, 499);
            this.SettingsTabPage.TabIndex = 1;
            this.SettingsTabPage.Text = "Параметри";
            this.SettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Мононітор втор. емісії ацп";
            // 
            // AKONCOMPortTextBox
            // 
            this.AKONCOMPortTextBox.Location = new System.Drawing.Point(89, 36);
            this.AKONCOMPortTextBox.Name = "AKONCOMPortTextBox";
            this.AKONCOMPortTextBox.Size = new System.Drawing.Size(76, 20);
            this.AKONCOMPortTextBox.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "АКОН ComPort";
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Location = new System.Drawing.Point(887, 464);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.saveSettingsButton.TabIndex = 2;
            this.saveSettingsButton.Text = "Зберегти";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSattingsButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Параметри Ардуїно";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Параметри АКОН";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Мононітор втор. емісії канал";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Канал 1 канал";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Канал 1 ацп";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 201);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Канал 2 канал";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 177);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Канал 2 ацп";
            // 
            // ArduinoCOMPortTextBox
            // 
            this.ArduinoCOMPortTextBox.Location = new System.Drawing.Point(98, 254);
            this.ArduinoCOMPortTextBox.Name = "ArduinoCOMPortTextBox";
            this.ArduinoCOMPortTextBox.Size = new System.Drawing.Size(76, 20);
            this.ArduinoCOMPortTextBox.TabIndex = 12;
            this.ArduinoCOMPortTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 257);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Ардуїно ComPort";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // SecondaryEmisionMonitorAdcNumberTextBox
            // 
            this.SecondaryEmisionMonitorAdcNumberTextBox.Location = new System.Drawing.Point(174, 52);
            this.SecondaryEmisionMonitorAdcNumberTextBox.Name = "SecondaryEmisionMonitorAdcNumberTextBox";
            this.SecondaryEmisionMonitorAdcNumberTextBox.Size = new System.Drawing.Size(76, 20);
            this.SecondaryEmisionMonitorAdcNumberTextBox.TabIndex = 13;
            // 
            // SecondaryEmisionMonitorChannelNumberTextBox
            // 
            this.SecondaryEmisionMonitorChannelNumberTextBox.Location = new System.Drawing.Point(174, 78);
            this.SecondaryEmisionMonitorChannelNumberTextBox.Name = "SecondaryEmisionMonitorChannelNumberTextBox";
            this.SecondaryEmisionMonitorChannelNumberTextBox.Size = new System.Drawing.Size(76, 20);
            this.SecondaryEmisionMonitorChannelNumberTextBox.TabIndex = 14;
            // 
            // Channel1AdcNumberTextBox
            // 
            this.Channel1AdcNumberTextBox.Location = new System.Drawing.Point(98, 120);
            this.Channel1AdcNumberTextBox.Name = "Channel1AdcNumberTextBox";
            this.Channel1AdcNumberTextBox.Size = new System.Drawing.Size(76, 20);
            this.Channel1AdcNumberTextBox.TabIndex = 16;
            // 
            // Channel1ChannelNumberTextBox
            // 
            this.Channel1ChannelNumberTextBox.Location = new System.Drawing.Point(98, 142);
            this.Channel1ChannelNumberTextBox.Name = "Channel1ChannelNumberTextBox";
            this.Channel1ChannelNumberTextBox.Size = new System.Drawing.Size(76, 20);
            this.Channel1ChannelNumberTextBox.TabIndex = 15;
            // 
            // Channel2AdcNumberTextBox
            // 
            this.Channel2AdcNumberTextBox.Location = new System.Drawing.Point(98, 172);
            this.Channel2AdcNumberTextBox.Name = "Channel2AdcNumberTextBox";
            this.Channel2AdcNumberTextBox.Size = new System.Drawing.Size(76, 20);
            this.Channel2AdcNumberTextBox.TabIndex = 18;
            // 
            // Channel2ChannelNumberTextBox
            // 
            this.Channel2ChannelNumberTextBox.Location = new System.Drawing.Point(98, 197);
            this.Channel2ChannelNumberTextBox.Name = "Channel2ChannelNumberTextBox";
            this.Channel2ChannelNumberTextBox.Size = new System.Drawing.Size(76, 20);
            this.Channel2ChannelNumberTextBox.TabIndex = 17;
            // 
            // GeneralView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(982, 522);
            this.Controls.Add(this.tabControl1);
            this.Name = "GeneralView";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.GeneralView_Shown);
            this.tabControl1.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.generalTabPage.PerformLayout();
            this.SettingsTabPage.ResumeLayout(false);
            this.SettingsTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stepsCountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ComboBox serialPortsComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox delayBeforeStepTextBox;
        private System.Windows.Forms.TextBox mesureCountTextBox;
        private System.Windows.Forms.Label arduinoComPortLabel;
        private System.Windows.Forms.Label calibrationLabel;
        private System.Windows.Forms.Button CalibrationButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label stepCountLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.TabPage SettingsTabPage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dot2TextBox;
        private System.Windows.Forms.TextBox dot1TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.TextBox AKONCOMPortTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ArduinoCOMPortTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox SecondaryEmisionMonitorAdcNumberTextBox;
        private System.Windows.Forms.TextBox Channel2AdcNumberTextBox;
        private System.Windows.Forms.TextBox Channel2ChannelNumberTextBox;
        private System.Windows.Forms.TextBox Channel1AdcNumberTextBox;
        private System.Windows.Forms.TextBox Channel1ChannelNumberTextBox;
        private System.Windows.Forms.TextBox SecondaryEmisionMonitorChannelNumberTextBox;
    }
}

