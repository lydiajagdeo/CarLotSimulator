using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }


        public Car(int year,
            string make, 
            string model,
            string engineNoise,
            string honkNoise,
            bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDrivable;


        }


        public int Year { get; set; }

        public string? Make { get; set; }

        public string? Model { get; set; }

        public string? EngineNoise { get; set; }

        public string? HonkNoise { get; set; }

        public bool IsDriveable { get; set; }


       public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine($" This is what my car's engine sounds like {EngineNoise}");
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine($" This is what my car's honk sounds like {HonkNoise}");
        }
    }
}


