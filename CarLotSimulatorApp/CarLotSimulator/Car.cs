using System;


namespace CarLotSimulator
{
    
    //Create a seperate class file called Car
    public class Car
    {
        
        // 'Default' Constructor
        public Car()
        {
        }

        // 'Initializer Syntax' Constructor
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }


        // 'Year' Property
        public int Year { get; set; }

        // 'Make' Property
        public string Make { get; set; }

        // 'Model' Property
        public string Model { get; set; }

        // 'EngineNoise' Property
        public string EngineNoise { get; set; }

        // 'HonkNoise' Property
        public string HonkNoise { get; set; }

        // 'IsDriveable' Property
        public bool IsDriveable { get; set; }

        // 'MakeEngineNoise()' Method
        public void MakeEngineNoise(string engineNoise)
        {
            EngineNoise = engineNoise;
            // Console.WriteLine($"The car with Make: {Make}, Model: {Model}, and Year: {Year} has done EngineNoise: {EngineNoise}.");
        }

        // 'MakeHonkNoise()' Method
        public void MakeHonkNoise(string honkNoise)
        {
            HonkNoise = honkNoise;
            // Console.WriteLine($"The car with Make: {Make}, Model: {Model}, and Year: {Year} has done HonkNoise: {HonkNoise}.");
        }
        
    }
    
}