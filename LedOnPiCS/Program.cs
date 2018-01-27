using System;

namespace LedOnPiCS
{
    using Unosquare.RaspberryIO;
    using Unosquare.RaspberryIO.Gpio;
    class Program
    {
        private static GpioPin pin;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            pin = Pi.Gpio.Pin09; //Pin03 appears to be BCM 22 and HeaderPin 25
            pin.PinMode = GpioPinDriveMode.Output;

            for (int i = 0; i < 10; i++)
            {
                Blink(pin, 500, 1000);
            }

            // int counter = 0;
            // foreach (var pin in Pi.Gpio.Pins)
            // {
            //     System.Console.WriteLine("Counter: " + counter++);
            //     pin.PinMode = GpioPinDriveMode.Output;
            //     System.Console.WriteLine("Pin: " + pin.PinNumber);
            //     System.Console.WriteLine("HeaderPinNumber: " + pin.HeaderPinNumber);
            //     System.Console.WriteLine("BCMPinNumber: " + pin.BcmPinNumber);

            //     for (int i = 0; i < 10; i++)
            //     {
            //         Blink(pin, 500, 1000);
            //     }
            // }
        }

        private static void Blink(GpioPin pin, int on, int cycle)
        {
            System.Console.WriteLine("Turning LED to true");
            pin.Write(true);
            System.Threading.Thread.Sleep(on);
            System.Console.WriteLine("Turning LED to false");
            pin.Write(false);
            System.Threading.Thread.Sleep(cycle - on);
        }
    }
}
