using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoVisualization
{
    public class Result
    {
        public double Humidity;
        public double Temperature;
        public double Distance;
        public int MotionDetect;

        public Result(double Humidity, double Temperature, double Distance, int MotionDetect)
        {
            this.Humidity = Humidity;
            this.Temperature = Temperature;
            this.Distance = Distance;
            this.MotionDetect = MotionDetect;
        }
    }
}
