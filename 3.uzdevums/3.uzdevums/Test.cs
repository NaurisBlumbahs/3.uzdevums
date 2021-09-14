using System;


namespace _3.uzdevums
{
    class Test
    {
        static void Main(string[] args)
        {
            var phone = new Phone();

            //phone.Mark = "Samsung";
            //phone.Model = "S20+";
            //phone.DimensionsLenght = 16;
            //phone.DimensionsWidth = 7.5;
            //phone.DimensionsHeight = 0.7;

            //Console.WriteLine("Ievadi savu telefona ražotāju");
            //phone.Mark = Console.ReadLine();
            //Console.WriteLine("Ievadi savu telefona modeli");
            //phone.Model = Console.ReadLine();
            //Console.WriteLine("Ievadi savu telefona izmērus: garums, platums un augstums");

            //string phoneLenghtText = Console.ReadLine();
            //double phoneLenght = double.Parse(phoneLenghtText);
            //phone.DimensionsLenght = phoneLenght;

            //string phoneWidthText = Console.ReadLine();
            //double phoneWidth = double.Parse(phoneWidthText);
            //phone.DimensionsWidth = phoneWidth;

            //string phoneHeightText = Console.ReadLine();
            //double phoneHeight = double.Parse(phoneHeightText);
            //phone.DimensionsHeight = phoneHeight;

            //Console.WriteLine($"Jūsu telefona ražotājs ir {phone.Mark} un modelis {phone.Model}");
            //Console.WriteLine($"Jūsu telefona garums ir {phone.DimensionsLenght} cm, platums {phone.DimensionsWidth} cm, un augstums {phone.DimensionsHeight} cm");

            //Console.WriteLine("Ievadi nummuru kam tu zvanīsi");

            //string numberToCallText = Console.ReadLine();
            //int numberToCall = int.Parse(numberToCallText);
            //phone.Call(numberToCall);
            //string call = phone.Call(numberToCall);
            //Console.WriteLine(call);


            //Console.WriteLine("Ievadi nummuru un tekstu kam tu sūtīsi SMS");

            //string numberToSendSMSText = Console.ReadLine();
            //int numberToSendSMS = int.Parse(numberToSendSMSText);

            //string textToSend = Console.ReadLine();
            //string sendSMS = phone.SendSMS(numberToSendSMS, textToSend);

            //Console.WriteLine(sendSMS);

            Car();
        }

        static void Car()
        {
            var car = new Car();

            Console.WriteLine("Ievadi savu mašīnas ražotāju");
            car.Mark = Console.ReadLine();

            Console.WriteLine("Ievadi savu mašīnas nummurzīmi");
            car.PlateNr = Console.ReadLine();

            Console.WriteLine("Ievadi mašīnas maksimālo ātrumu");
            string maxSpeedText = Console.ReadLine();
            int maxSpeed = int.Parse(maxSpeedText);
            car.Speed = maxSpeed;

            Console.WriteLine($"Tu brauc ar {car.Mark}, nummurzīme {car.PlateNr} un maksimālais ātrums ir {car.Speed} km/h");

            int startDrive = car.StartDriving();
            int accelerateCar = car.Accelerate();
            int stopDrive = car.StopDriving();
            string honk = car.Honk();

            Console.WriteLine($"{car.Mark} uzsāk braukt ar ātrumu {startDrive} km/h");
            Console.WriteLine($"{car.Mark} palielina ātrumu līdz {accelerateCar} km/h");
            Console.WriteLine(($"{car.Mark} samazina ātrumu līdz {stopDrive} km/h. {car.Mark} ir apstājies"));
            Console.WriteLine(honk);

            



        }


    }
}
