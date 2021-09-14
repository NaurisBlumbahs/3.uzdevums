using System;

namespace _3.uzdevums
{
    class Phone
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public double DimensionsLenght { get; set; }
        public double DimensionsWidth { get; set; }
        public double DimensionsHeight { get; set; }

        public string Call(int number)
        {
            return $"Zvanīt {number}, beep beep: Hallo!";
        }

        public string SendSMS(int number, string text)
        {
            return $"Sūtīt SMS uz {number} un rakstīt: {text}";
        }
    }

    class Car
    {
        public string Mark { get; set; }
        public string PlateNr { get; set; }
        public int Speed { get; set; }

        public int StartDriving()
        {
            return (int)(Speed * 0.1);
        }

        public int Accelerate()
        {
            return (int)(Speed * 0.2);
        }

        public int StopDriving()
        {
            return Speed = 0;
        }

        public string Honk()
        {
            return "Beep beep";
        }
    }
}
