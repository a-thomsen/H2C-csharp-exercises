using System;

namespace exercise_121
{
    public class Fitbyte
    {
        public int age { get; set; }
        public int restingHeartRate { get; set; }
        public double maxHeartRate { get; set; }

        public Fitbyte(int age, int restingHeartRate)
        {
            this.age = age;
            this.restingHeartRate = restingHeartRate;
            this.maxHeartRate = 206.3 - (0.711 * this.age);
        }

        public double TargetHeartRate(double percentageOfMaximum)
        {
            double targetRate = (this.maxHeartRate - this.restingHeartRate) * percentageOfMaximum + this.restingHeartRate;
            return targetRate;
        }
    }
}