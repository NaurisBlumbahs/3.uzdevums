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

    public class Product
    {
        public Product(double lenght, double width, double height)
        {
            Lenght = lenght;
            Width = width;
            Height = height;
        }

        public double Lenght { get; }
        public double Width { get; }
        public double Height { get; }

        public double Weight { get; set; }

        public string CreateProduct()
        {
            return $"Prece tiek izveidota";
        }
        public string ShowProductData()
        {
            return $"Preces parametri: garums ir {Lenght} cm, platums {Width} cm, augstums {Height} cm un svars {Weight} kg";
        }
    }

    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime YearsOld { get; set; }

        public string Hobby { get; set; }

        public string Gender { get; set; }

        public string Greeting()
        {
            return $"Hello my name is {FirstName} {LastName} and I am {CalculateAge()} years old ";
        }

        public double CalculateAge()
        {
            var birthDay = YearsOld;
            var dateNow = DateTime.Now;

            double today = double.Parse(dateNow.ToString("yyyyMMdd"));
            double bDay = double.Parse(birthDay.ToString("yyyyMMdd"));

            double ageNowUnrounded = (today - bDay) / 10000;
            double ageNow = Math.Round(ageNowUnrounded, 0);


            if (dateNow.Year > birthDay.Year & dateNow.Month < birthDay.Month)
            {
                var realAge = ageNow - 1;
                return realAge;            
            }

            else if (dateNow.Year > birthDay.Year & dateNow.Month <= birthDay.Month & dateNow.Day < birthDay.Day)
            {
                var realAge = ageNow - 1;
                return realAge;                
            }

            else
            {
                return ageNow;      
            }
        }
    }
}
