using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot()
        {
        }
        public List<Car> MyCarLot = new List<Car>();
        public static int numberOfCars = 0;

        public static void ReportOfCarLot ()
        {
            Console.WriteLine($"There are {numberOfCars} in all car lots.");
        }
    }
}
//Create a CarLot class
//It should have at least one property: a List of cars
//Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
//At the end iterate through the list printing each of car's Year, Make, and Model to the console