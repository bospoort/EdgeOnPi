using System;

namespace LedOnPiCS
{
    using Unosquare.RaspberryIO;
    using Unosquare.RaspberryIO.Gpio;

    class Program
    {
        private static GpioPin pin = Pi.Gpio.Pin03;
 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            pin.PinMode = GpioPinDriveMode.Output;

            for (int i = 0; i < 10; i++)
                Blink(500, 1000);
        }

        private static void Blink(int on, int cycle)
        {
            pin.Write(true);   
            System.Threading.Thread.Sleep(on);
            pin.Write(true);   
            System.Threading.Thread.Sleep(cycle-on);
        }
    }
}
