using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Creating an Instance of the 'CarLot' class
            CarLot carLot = new CarLot();
            
            Console.WriteLine($"No of cars at startup: {CarLot._numberOfCars}");

            // Creating an Object instance using 'Default' Constructor method:
            Car objToyota = new Car();
            
            objToyota.Make = "Toyota";
            objToyota.Model = "Corona";
            objToyota.Year = 2015;
            objToyota.MakeEngineNoise("Hum....Pur...");
            objToyota.MakeHonkNoise("Honk");

            // Static Keyword: Exercise 2
            Console.WriteLine($"Cars created {CarLot._numberOfCars}: {objToyota.Make}, {objToyota.Model}, {objToyota.Year}.");
            
            // Adding to the Carlot
            carLot.ListOfCars.Add(objToyota);
            
            // Creating an Object instance using 'Default' Constructor Method - 2:
            Car objHonda = new Car()
            {
                Make = "Honda",
                Model = "Odyssey",
                Year = 2016
            };
            objHonda.MakeEngineNoise("tick-tick-tick...");
            objHonda.MakeHonkNoise("Beep");

            // Static Keyword: Exercise 2
            Console.WriteLine($"Cars created {CarLot._numberOfCars}: {objHonda.Make}, {objHonda.Model}, {objHonda.Year}.");

            // Adding to the Carlot
            carLot.ListOfCars.Add(objHonda);
            
            
            // Creating an Object instance using 'PARAMETERIZED CONSTRUCTOR INITIALIZER' Syntax - Method - 1:
            // PARAMETERIZED CONSTRUCTOR INITIALIZATION: Either Braces or Brackets: 'Braces' below
            /*
            Car objNissan = new Car
            {
                Make = "Nissan",
                Model = "Rogue",
                Year = 2014
            };
            */
            
            // Creating an Object instance using 'PARAMETERIZED CONSTRUCTOR INITIALIZER' Syntax - Method - 2:
            // PARAMETERIZED CONSTRUCTOR INITIALIZATION: Either Braces or Brackets: 'Brackets' below
            Car objNissan = new Car("Nissan", "Rogue", 2014);
            
            // Static Keyword: Exercise 2
            Console.WriteLine($"Cars created {CarLot._numberOfCars}: {objNissan.Make}, {objNissan.Model}, {objNissan.Year}.\n");

            objNissan.MakeEngineNoise("Tink...and...Click...");
            objNissan.MakeHonkNoise("Blare");
            
            // Adding to the Carlot
            carLot.ListOfCars.Add(objNissan);

            
            // Iterating through the list and printing the values of each object's properties
            int loopCounter = 0;
            foreach (var car in carLot.ListOfCars)
            {
                Console.WriteLine($"Cars arriving to the car lot {++loopCounter}:");
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, and Model: {car.Model}, that makes EngineNoise like '{car.EngineNoise}' & HonkNoise like '{car.HonkNoise}'.\n");
            }
                        
        }
    }

}
