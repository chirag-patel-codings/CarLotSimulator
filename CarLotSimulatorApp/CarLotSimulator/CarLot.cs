using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    
    // Creating a new 'CarLot' class
    public class CarLot
    {
        
        // Static Keyword: Exercise 2
        public static int _numberOfCars = 0;
        
        // Creating a Property 'ListOfCars' and Initiating with Default Value;
        public List<Car> ListOfCars { get; set; } = new List<Car>();
        
    }
}