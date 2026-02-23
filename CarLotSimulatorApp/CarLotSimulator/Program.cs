using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Creating an Instance of the 'CarLot' class
            CarLot carLot = new CarLot();
            
            // Creating an Object instance using 'Default' Constructor method:
            Car objToyota = new Car();
            
            objToyota.Make = "Toyota";
            objToyota.Model = "Corona";
            objToyota.Year = 2015;
            objToyota.MakeEngineNoise("Hum....Pur...");
            objToyota.MakeHonkNoise("Honk");
            
            // Adding to the Carlot
            carLot.ListOfCars.Add(objToyota);
            
            
            // Creating an Object instance using 'Default' Constructor method - 2:
            Car objHonda = new Car()
            {
                Make = "Honda",
                Model = "Odyssey",
                Year = 2016
            };
            objHonda.MakeEngineNoise("tick-tick-tick...");
            objHonda.MakeHonkNoise("Beep");
            
            // Adding to the Carlot
            carLot.ListOfCars.Add(objHonda);
            
            
            // Creating an Object instance using 'Object Initializer' Syntax:
            Car objNissan = new Car
            {
                Make = "Nissan",
                Model = "Rogue",
                Year = 2014
            };
            objNissan.MakeEngineNoise("Tink...and...Click...");
            objNissan.MakeHonkNoise("Blare");
            
            // Adding to the Carlot
            carLot.ListOfCars.Add(objNissan);
 
            
            // Iterating through the list and printing the values of each object's properties
            int loopCounter = 0;
            foreach (var car in carLot.ListOfCars)
            {
                Console.WriteLine($"Added Car {++loopCounter}:");
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, and Model: {car.Model}, that makes EngineNoise like '{car.EngineNoise}' & HonkNoise like '{car.HonkNoise}'.\n");
            }
            
            
        }
    }
}
