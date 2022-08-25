using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            var newLot = new CarLot();

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car



            var carLotList = new Car();
            carLotList.Year = 2007;
            carLotList.Make = "Dodge";
            carLotList.Model = "Nitro";
            carLotList.EngineNoise = "Vroom";
            carLotList.HonkNoise = "Beeeeeep";
            carLotList.IsDriveable = true;


            newLot.Cars.Add(carLotList);


            var carLotList2 = new Car()
            {

                Year = 2006,
                Make = "BMW",
                Model = "shgow",
                EngineNoise = "Meow",
                HonkNoise = "Peep",
                IsDriveable = false
            };

            newLot.Cars.Add(carLotList2);

            var carLotList3 = new Car(2930, "Flying", "HighHigh", "SHHHHHH", "Squeak", false);


            carLotList.MakeEngineNoise(carLotList.EngineNoise);
            carLotList2.MakeEngineNoise(carLotList2.EngineNoise);
            carLotList3.MakeEngineNoise(carLotList3.EngineNoise);

            newLot.Cars.Add(carLotList3);


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Cars created: {CarLot.numberOfCars}");

            foreach (var car in newLot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
