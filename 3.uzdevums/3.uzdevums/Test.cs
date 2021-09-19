using System;


namespace _3.uzdevums
{
    class Test
    {
        static void Main(string[] args)
        {

            Phone();
            Car();
            Product();
            Person();
        }

        static private void Phone()
        {
            var phone = new Phone();

            Console.WriteLine("Uzdevums - Telefons");

            //atkomentēt, lai pārbaudītu programmu ar šīm vērtībam
            
            phone.Mark = "Samsung";
            phone.Model = "S20+";
            phone.DimensionsLenght = 16;
            phone.DimensionsWidth = 7.5;
            phone.DimensionsHeight = 0.7;

            //atkomentēt, lai pārbaudītu programmu ar šīm vērtībam

            //atkomentēt, lai pārbaudītu programmu ar vērtībām kuras ievadi no konsoles

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

            //atkomentēt, lai pārbaudītu programmu ar vērtībām kuras ievadi no konsoles

            Console.WriteLine($"Jūsu telefona ražotājs ir {phone.Mark} un modelis {phone.Model}");
            Console.WriteLine($"Jūsu telefona garums ir {phone.DimensionsLenght} cm, platums {phone.DimensionsWidth} cm, un augstums {phone.DimensionsHeight} cm");

            Console.WriteLine("Ievadi nummuru kam tu zvanīsi");

            string numberToCallText = Console.ReadLine();
            int numberToCall = int.Parse(numberToCallText);
            phone.Call(numberToCall);
            string call = phone.Call(numberToCall);
            Console.WriteLine(call);

            Console.WriteLine("Ievadi tekstu ko sūtīsi SMS");

            string textToSend = Console.ReadLine();
            string sendSMS = phone.SendSMS(numberToCall, textToSend);

            Console.WriteLine(sendSMS);
        }

        static private void Car()
        {
            var car = new Car();

            Console.WriteLine("Uzdevums - Mašīna");

            //atkomentēt, lai pārbaudītu programmu ar šīm vērtībam

            car.Mark = "Renault";
            car.PlateNr = "MM - 1234";
            car.Speed = 200;

            //atkomentēt, lai pārbaudītu programmu ar šīm vērtībam

            //atkomentēt, lai pārbaudītu programmu ar vērtībām kuras ievadi no konsoles

            //Console.WriteLine("Ievadi savu mašīnas ražotāju");
            //car.Mark = Console.ReadLine();

            //Console.WriteLine("Ievadi savu mašīnas nummurzīmi");
            //car.PlateNr = Console.ReadLine();

            //Console.WriteLine("Ievadi mašīnas maksimālo ātrumu");
            //string maxSpeedText = Console.ReadLine();
            //int maxSpeed = int.Parse(maxSpeedText);
            //car.Speed = maxSpeed;

            //atkomentēt, lai pārbaudītu programmu ar vērtībām kuras ievadi no konsoles

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

        static private void Product ()
        {
            // ievadīt preces garumu, platumu un augstumu
            var product = new Product(4, 5, 6);
            //atkomentēt, lai pārbaudītu programmu ar šīm vērtībam
            product.Weight = 10;
            //atkomentēt, lai pārbaudītu programmu ar šīm vērtībam

            Console.WriteLine("Uzdevums - Prece");

            //atkomentēt, lai pārbaudītu programmu ar vērtībām kuras ievadi no konsoles

            //Console.WriteLine("Ievadiet preces svaru (kg)");
            //string weightText = Console.ReadLine();
            //double weight = double.Parse(weightText);
            //product.Weight = weight;

            //atkomentēt, lai pārbaudītu programmu ar vērtībām kuras ievadi no konsoles

            string createProduct = product.CreateProduct();
            Console.WriteLine(createProduct);
            string showProductData = product.ShowProductData();
            Console.WriteLine(showProductData);
        }

        static private void Person()
        {
            var person = new Person();

            Console.WriteLine("Uzdevums - Persona");

            person.FirstName = "Nauris";
            person.LastName = "Blumbahs";
            person.YearsOld = new (1994, 4, 14);
            person.Hobby = "Spēlēju video spēles";
            person.Gender = "Vīrietis";

            string getGreeting = person.Greeting();
            Console.WriteLine(getGreeting);
        }
    }
}
