namespace StepMotorControllerUIPart.View
{
    partial class Form1
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
            this.mesuresCountTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.serialPortsComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.drawGraph = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кількість кроків";
            // 
            // stepsCountTextBox
            // 
            this.stepsCountTextBox.Location = new System.Drawing.Point(120, 36);
            this.stepsCountTextBox.Name = "stepsCountTextBox";
            this.stepsCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.stepsCountTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кількість вимірів";
            // 
            // mesuresCountTextBox
            // 
            this.mesuresCountTextBox.Location = new System.Drawing.Point(120, 65);
            this.mesuresCountTextBox.Name = "mesuresCountTextBox";
            this.mesuresCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.mesuresCountTextBox.TabIndex = 3;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 104);
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
            this.serialPortsComboBox.Location = new System.Drawing.Point(12, 385);
            this.serialPortsComboBox.Name = "serialPortsComboBox";
            this.serialPortsComboBox.Size = new System.Drawing.Size(86, 21);
            this.serialPortsComboBox.TabIndex = 5;
            this.serialPortsComboBox.Text = "COMPORT";
            this.serialPortsComboBox.SelectedIndexChanged += new System.EventHandler(this.serialPortsComboBox_SelectedIndexChanged);
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(226, 12);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(509, 370);
            this.zedGraph.TabIndex = 6;
            // 
            // drawGraph
            // 
            this.drawGraph.Location = new System.Drawing.Point(19, 179);
            this.drawGraph.Name = "drawGraph";
            this.drawGraph.Size = new System.Drawing.Size(98, 23);
            this.drawGraph.TabIndex = 7;
            this.drawGraph.Text = "Тест Графіка";
            this.drawGraph.UseVisualStyleBackColor = true;
            this.drawGraph.Click += new System.EventHandler(this.drawGraph_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Параметри";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 418);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drawGraph);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.serialPortsComboBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.mesuresCountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stepsCountTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stepsCountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mesuresCountTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ComboBox serialPortsComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Button drawGraph;
        private System.Windows.Forms.Label label3;
    }
}

