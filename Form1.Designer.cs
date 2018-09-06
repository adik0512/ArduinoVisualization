namespace ArduinoVisualization
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartHumidity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDistance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chartMotionDetection = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelMotionDetector = new System.Windows.Forms.Label();
            this.labelDistance = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.pictureBoxMotionDetector = new System.Windows.Forms.PictureBox();
            this.pictureBoxDistance = new System.Windows.Forms.PictureBox();
            this.pictureBoxHumidity = new System.Windows.Forms.PictureBox();
            this.pictureBoxTemperature = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistance)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMotionDetection)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotionDetector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemperature)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartTemperature
            // 
            this.chartTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartTemperature.BorderlineColor = System.Drawing.Color.Black;
            this.chartTemperature.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea9.Name = "ChartArea1";
            this.chartTemperature.ChartAreas.Add(chartArea9);
            this.chartTemperature.Location = new System.Drawing.Point(3, 6);
            this.chartTemperature.Name = "chartTemperature";
            this.chartTemperature.Size = new System.Drawing.Size(932, 300);
            this.chartTemperature.TabIndex = 0;
            this.chartTemperature.Text = "chart1";
            // 
            // chartHumidity
            // 
            this.chartHumidity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartHumidity.BorderlineColor = System.Drawing.Color.Black;
            this.chartHumidity.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea10.Name = "ChartArea1";
            this.chartHumidity.ChartAreas.Add(chartArea10);
            this.chartHumidity.Location = new System.Drawing.Point(3, 312);
            this.chartHumidity.Name = "chartHumidity";
            this.chartHumidity.Size = new System.Drawing.Size(932, 300);
            this.chartHumidity.TabIndex = 1;
            this.chartHumidity.Text = "chart2";
            // 
            // chartDistance
            // 
            this.chartDistance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartDistance.BorderlineColor = System.Drawing.Color.Black;
            this.chartDistance.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea11.Name = "ChartArea1";
            this.chartDistance.ChartAreas.Add(chartArea11);
            this.chartDistance.Location = new System.Drawing.Point(3, 618);
            this.chartDistance.Name = "chartDistance";
            this.chartDistance.Size = new System.Drawing.Size(932, 300);
            this.chartDistance.TabIndex = 2;
            this.chartDistance.Text = "chart3";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(951, 478);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.chartMotionDetection);
            this.tabPage1.Controls.Add(this.chartDistance);
            this.tabPage1.Controls.Add(this.chartTemperature);
            this.tabPage1.Controls.Add(this.chartHumidity);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(943, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Advance";
            // 
            // chartMotionDetection
            // 
            this.chartMotionDetection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartMotionDetection.BorderlineColor = System.Drawing.Color.Black;
            this.chartMotionDetection.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea12.Name = "ChartArea1";
            this.chartMotionDetection.ChartAreas.Add(chartArea12);
            this.chartMotionDetection.Location = new System.Drawing.Point(3, 924);
            this.chartMotionDetection.Name = "chartMotionDetection";
            this.chartMotionDetection.Size = new System.Drawing.Size(932, 300);
            this.chartMotionDetection.TabIndex = 3;
            this.chartMotionDetection.Text = "chart3";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(943, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Basic";
            // 
            // labelMotionDetector
            // 
            this.labelMotionDetector.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMotionDetector.AutoSize = true;
            this.labelMotionDetector.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelMotionDetector.Location = new System.Drawing.Point(65, 223);
            this.labelMotionDetector.Name = "labelMotionDetector";
            this.labelMotionDetector.Size = new System.Drawing.Size(0, 32);
            this.labelMotionDetector.TabIndex = 7;
            // 
            // labelDistance
            // 
            this.labelDistance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDistance.AutoSize = true;
            this.labelDistance.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelDistance.Location = new System.Drawing.Point(65, 223);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(0, 32);
            this.labelDistance.TabIndex = 6;
            // 
            // labelHumidity
            // 
            this.labelHumidity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelHumidity.Location = new System.Drawing.Point(72, 223);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(0, 32);
            this.labelHumidity.TabIndex = 5;
            // 
            // labelTemperature
            // 
            this.labelTemperature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTemperature.Location = new System.Drawing.Point(71, 223);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(0, 32);
            this.labelTemperature.TabIndex = 4;
            // 
            // pictureBoxMotionDetector
            // 
            this.pictureBoxMotionDetector.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxMotionDetector.Image = global::ArduinoVisualization.Properties.Resources.MotionDetector;
            this.pictureBoxMotionDetector.Location = new System.Drawing.Point(6, 20);
            this.pictureBoxMotionDetector.Name = "pictureBoxMotionDetector";
            this.pictureBoxMotionDetector.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxMotionDetector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMotionDetector.TabIndex = 3;
            this.pictureBoxMotionDetector.TabStop = false;
            // 
            // pictureBoxDistance
            // 
            this.pictureBoxDistance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxDistance.Image = global::ArduinoVisualization.Properties.Resources.Distance;
            this.pictureBoxDistance.Location = new System.Drawing.Point(6, 20);
            this.pictureBoxDistance.Name = "pictureBoxDistance";
            this.pictureBoxDistance.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxDistance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDistance.TabIndex = 2;
            this.pictureBoxDistance.TabStop = false;
            // 
            // pictureBoxHumidity
            // 
            this.pictureBoxHumidity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxHumidity.Image = global::ArduinoVisualization.Properties.Resources.Humidity;
            this.pictureBoxHumidity.Location = new System.Drawing.Point(6, 20);
            this.pictureBoxHumidity.Name = "pictureBoxHumidity";
            this.pictureBoxHumidity.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxHumidity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHumidity.TabIndex = 1;
            this.pictureBoxHumidity.TabStop = false;
            // 
            // pictureBoxTemperature
            // 
            this.pictureBoxTemperature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxTemperature.Image = global::ArduinoVisualization.Properties.Resources.Temperature;
            this.pictureBoxTemperature.Location = new System.Drawing.Point(6, 20);
            this.pictureBoxTemperature.Name = "pictureBoxTemperature";
            this.pictureBoxTemperature.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxTemperature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTemperature.TabIndex = 0;
            this.pictureBoxTemperature.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.pictureBoxTemperature);
            this.groupBox1.Controls.Add(this.labelTemperature);
            this.groupBox1.Location = new System.Drawing.Point(36, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 274);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperature";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.pictureBoxHumidity);
            this.groupBox2.Controls.Add(this.labelHumidity);
            this.groupBox2.Location = new System.Drawing.Point(255, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 274);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Humidity";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.pictureBoxDistance);
            this.groupBox3.Controls.Add(this.labelDistance);
            this.groupBox3.Location = new System.Drawing.Point(474, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 274);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Distance";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.pictureBoxMotionDetector);
            this.groupBox4.Controls.Add(this.labelMotionDetector);
            this.groupBox4.Location = new System.Drawing.Point(693, 89);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 274);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Motion Detector";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(951, 478);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ArduMeter";
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistance)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMotionDetection)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotionDetector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemperature)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperature;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHumidity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDistance;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMotionDetection;
        private System.Windows.Forms.PictureBox pictureBoxMotionDetector;
        private System.Windows.Forms.PictureBox pictureBoxDistance;
        private System.Windows.Forms.PictureBox pictureBoxHumidity;
        private System.Windows.Forms.PictureBox pictureBoxTemperature;
        private System.Windows.Forms.Label labelMotionDetector;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

