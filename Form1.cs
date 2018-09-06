using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ArduinoVisualization
{
   
    public partial class Form1 : Form
    {
        int x = 0;
        int y = 0;
        DbMySql db;
        public Form1()
        {
            InitializeComponent();
            db = new DbMySql("192.168.8.2", "3306", "ardumeter", "arduino", "arduino");

            chartTemperature.Series.Clear();
            chartTemperature.Series.Add("Temperature");
            chartTemperature.Series["Temperature"].Color = Color.Red;
            chartTemperature.Series["Temperature"].BorderWidth = 5;
            chartTemperature.Series["Temperature"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartTemperature.Series["Temperature"].ChartArea = "ChartArea1";
            chartTemperature.ChartAreas[0].AxisX.Title = "Time [s]";
            chartTemperature.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Courier New", 10, FontStyle.Regular);
            chartTemperature.ChartAreas[0].AxisY.Title = "Temperature [°C]";
            chartTemperature.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Courier New", 10, FontStyle.Regular);

            chartHumidity.Series.Clear();
            chartHumidity.Series.Add("Humidity");
            chartHumidity.Series["Humidity"].Color = Color.Red;
            chartHumidity.Series["Humidity"].BorderWidth = 5;
            chartHumidity.Series["Humidity"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartHumidity.Series["Humidity"].ChartArea = "ChartArea1";
            chartHumidity.ChartAreas[0].AxisX.Title = "Time [s]";
            chartHumidity.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Courier New", 10, FontStyle.Regular);
            chartHumidity.ChartAreas[0].AxisY.Title = "Humidity [%]";
            chartHumidity.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Courier New", 10, FontStyle.Regular);

            chartDistance.Series.Clear();
            chartDistance.Series.Add("Distance");
            chartDistance.Series["Distance"].Color = Color.Red;
            chartDistance.Series["Distance"].BorderWidth = 5;
            chartDistance.Series["Distance"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartDistance.Series["Distance"].ChartArea = "ChartArea1";
            chartDistance.ChartAreas[0].AxisX.Title = "Time [s]";
            chartDistance.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Courier New", 10, FontStyle.Regular);
            chartDistance.ChartAreas[0].AxisY.Title = "Distance [cm]";
            chartDistance.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Courier New", 10, FontStyle.Regular);

            chartMotionDetection.Series.Clear();
            chartMotionDetection.Series.Add("Motion Detection");
            chartMotionDetection.Series["Motion Detection"].Color = Color.Red;
            chartMotionDetection.Series["Motion Detection"].BorderWidth = 5;
            chartMotionDetection.Series["Motion Detection"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chartMotionDetection.Series["Motion Detection"].ChartArea = "ChartArea1";
            chartMotionDetection.ChartAreas[0].AxisX.Title = "Time [s]";
            chartMotionDetection.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Courier New", 10, FontStyle.Regular);
            chartMotionDetection.ChartAreas[0].AxisY.Title = "Motion Detection [binary]";
            chartMotionDetection.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Courier New", 10, FontStyle.Regular);


            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Result result = db.readLasData();
            chartTemperature.Titles.Clear();
            Title TitleTemperature = chartTemperature.Titles.Add("Temperature: " + result.Temperature.ToString() + " °C");
            TitleTemperature.Font = new System.Drawing.Font("Courier New", 12, FontStyle.Bold);

            //x++;
            //y++;
            //if (y > 10) y = 0;
            chartTemperature.Series["Temperature"].Points.AddXY(x, result.Temperature);
            labelTemperature.Text = result.Temperature.ToString() + " °C";
            //if (x>1)
            //{
            //    chartTemperature.ChartAreas[0].AxisX.Minimum = x - 100;
            //    chartTemperature.ChartAreas[0].AxisX.Maximum = x + 5;
            //}

             //--------
            chartHumidity.Titles.Clear();                                       
            Title TitleHumidity = chartHumidity.Titles.Add("Humidity: " + result.Humidity.ToString() + " %");
            TitleHumidity.Font = new System.Drawing.Font("Courier New", 12, FontStyle.Bold);

            //x++;
            //y++;
            //if (y > 10) y = 0;
            chartHumidity.Series["Humidity"].Points.AddXY(x, result.Humidity);
            labelHumidity.Text = result.Humidity.ToString() + " %";
            //if (x > 1)
            //{
            //    chartHumidity.ChartAreas[0].AxisX.Minimum = x - 100;
            //    chartHumidity.ChartAreas[0].AxisX.Maximum = x + 5;
            //}


            //--------
            chartDistance.Titles.Clear();
            Title TitleDistance = chartDistance.Titles.Add("Distance: " + result.Distance.ToString() + " cm");
            TitleDistance.Font = new System.Drawing.Font("Courier New", 12, FontStyle.Bold);

            //x++;
            //y++;
           // if (y > 10) y = 0;
            chartDistance.Series["Distance"].Points.AddXY(x, result.Distance);
            labelDistance.Text = result.Distance.ToString() + " cm";
            //if (x > 1)
            //{
            //    chartDistance.ChartAreas[0].AxisX.Minimum = x - 100;
            //    chartDistance.ChartAreas[0].AxisX.Maximum = x + 5;
            //}
            //------
            //Random random = new Random();

           // int r = random.Next(0, 2);

            chartMotionDetection.Titles.Clear();
            Title TitleMotionDetection = chartMotionDetection.Titles.Add("Motion Detection: " + result.MotionDetect.ToString() + " binary");
            TitleMotionDetection.Font = new System.Drawing.Font("Courier New", 12, FontStyle.Bold);          
            
            //x++;
            chartMotionDetection.Series["Motion Detection"].Points.AddXY(x, result.MotionDetect);
            if (result.MotionDetect == 1) labelMotionDetector.Text = "true";
            else labelMotionDetector.Text = "false";
            //if (x > 1)
            //{
            //    chartMotionDetection.ChartAreas[0].AxisX.Minimum = x - 100;
            //    chartMotionDetection.ChartAreas[0].AxisX.Maximum = x + 5;
            //}


        }

      
    }
}
