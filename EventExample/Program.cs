using System;
using System.Diagnostics;

namespace EventExample
{
    public delegate void SpeedLimitExceededEventHandler(object source, EventArgs e);
    class Program
    {
        static void Main(string[] args)
        {
            static void CarSpeedLimitExceeded(object source, EventArgs e)
            {
                Car car = (Car)source;
                Console.WriteLine("Speed limit exceeded {0}mph", car.Speed);
            }

            Car car = new Car();
            car.SpeedLimitExceeded +=
                new SpeedLimitExceededEventHandler(CarSpeedLimitExceeded);

            for (int i = 0; i < 3; i++)
            {
                car.Accelerate(30);
                Console.WriteLine("Speed: {0}mph", car.Speed);
            }
        }
    }
}
