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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кількість кроків";
            // 
            // stepsCountTextBox
            // 
            this.stepsCountTextBox.Location = new System.Drawing.Point(141, 40);
            this.stepsCountTextBox.Name = "stepsCountTextBox";
            this.stepsCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.stepsCountTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кількість вимірів";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(27, 359);
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
            this.serialPortsComboBox.Location = new System.Drawing.Point(19, 489);
            this.serialPortsComboBox.Name = "serialPortsComboBox";
            this.serialPortsComboBox.Size = new System.Drawing.Size(86, 21);
            this.serialPortsComboBox.TabIndex = 5;
            this.serialPortsComboBox.Text = "COMPORT";
            this.serialPortsComboBox.SelectedIndexChanged += new System.EventHandler(this.serialPortsComboBox_SelectedIndexChanged);
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(247, 12);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(537, 385);
            this.zedGraph.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Параметри ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Затримка після кроку";
            // 
            // delayBeforeStepTextBox
            // 
            this.delayBeforeStepTextBox.Location = new System.Drawing.Point(141, 100);
            this.delayBeforeStepTextBox.Name = "delayBeforeStepTextBox";
            this.delayBeforeStepTextBox.Size = new System.Drawing.Size(100, 20);
            this.delayBeforeStepTextBox.TabIndex = 10;
            // 
            // mesureCountTextBox
            // 
            this.mesureCountTextBox.Location = new System.Drawing.Point(141, 69);
            this.mesureCountTextBox.Name = "mesureCountTextBox";
            this.mesureCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.mesureCountTextBox.TabIndex = 11;
            // 
            // arduinoComPortLabel
            // 
            this.arduinoComPortLabel.AutoSize = true;
            this.arduinoComPortLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.arduinoComPortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arduinoComPortLabel.Location = new System.Drawing.Point(12, 464);
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
            this.calibrationLabel.Location = new System.Drawing.Point(162, 464);
            this.calibrationLabel.Name = "calibrationLabel";
            this.calibrationLabel.Size = new System.Drawing.Size(79, 17);
            this.calibrationLabel.TabIndex = 13;
            this.calibrationLabel.Text = "Калібрація";
            // 
            // CalibrationButton
            // 
            this.CalibrationButton.Location = new System.Drawing.Point(165, 487);
            this.CalibrationButton.Name = "CalibrationButton";
            this.CalibrationButton.Size = new System.Drawing.Size(75, 23);
            this.CalibrationButton.TabIndex = 14;
            this.CalibrationButton.Text = "Калібрація";
            this.CalibrationButton.UseVisualStyleBackColor = true;
            this.CalibrationButton.Click += new System.EventHandler(this.CalibrationButton_Click);
            // 
            // GeneralView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(796, 522);
            this.Controls.Add(this.CalibrationButton);
            this.Controls.Add(this.calibrationLabel);
            this.Controls.Add(this.arduinoComPortLabel);
            this.Controls.Add(this.mesureCountTextBox);
            this.Controls.Add(this.delayBeforeStepTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.serialPortsComboBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stepsCountTextBox);
            this.Controls.Add(this.label1);
            this.Name = "GeneralView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GeneralView_Load);
            this.Shown += new System.EventHandler(this.GeneralView_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

