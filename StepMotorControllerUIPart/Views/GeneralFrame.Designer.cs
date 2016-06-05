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
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dot2TextBox = new System.Windows.Forms.TextBox();
            this.dot1TextBox = new System.Windows.Forms.TextBox();
            this.SettingsTabPage = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.RLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.generalTabPage.SuspendLayout();
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
            this.SettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.SettingsTabPage.Name = "SettingsTabPage";
            this.SettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTabPage.Size = new System.Drawing.Size(972, 499);
            this.SettingsTabPage.TabIndex = 1;
            this.SettingsTabPage.Text = "Параметри";
            this.SettingsTabPage.UseVisualStyleBackColor = true;
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
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.Location = new System.Drawing.Point(654, 415);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(13, 13);
            this.RLabel.TabIndex = 23;
            this.RLabel.Text = "0";
            this.RLabel.Click += new System.EventHandler(this.label9_Click);
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
    }
}

