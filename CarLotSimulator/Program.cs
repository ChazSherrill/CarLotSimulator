using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property            


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var thisCarLot = new CarLot();

            var camry = new Car();

            camry.Year = 2020;
            camry.Make = "Toyota";
            camry.Model = "Camry";
            camry.EngineNoise = "BBBRRAAAABRAAAAAAAABOOOM";
            camry.HonkNoise = "excuse me";
            camry.IsDriveable = false;

            camry.MakeEngineNoise();
            camry.MakeEngineNoise();


            thisCarLot.MyCarLot.Add(camry);

            var mustang = new Car() { Year = 1979, Make="Ford", Model= "Mustang", EngineNoise= "WAAAAAAAAWAAAAAAwaaaa", HonkNoise="Move", IsDriveable = true};

            //mustang.Year = 1979;
            //mustang.Make = "Ford";
            //mustang.Model = "Mustang";
            // mustang.EngineNoise = "WAAAAAAAAWAAAAAAwaaaa";
            // mustang.HonkNoise = "MOVE";
            // mustang.IsDriveable = true;

            mustang.MakeEngineNoise();
            mustang.MakeEngineNoise();

            thisCarLot.MyCarLot.Add(mustang);

            var deathmachine = new Car(7088, "Death Machine", "Excelsior", "o2ijfoij23ijfffij23f", "I AM THE SENATE", true);

            //deathmachine.Year = 7088;
            //deathmachine.Make = "Death Machine";
            //deathmachine.Model = "Excelsior";
            //deathmachine.EngineNoise = "o2ijfoij23ijfffij23f";
            //deathmachine.HonkNoise = "I AM THE SENATE";
            //deathmachine.IsDriveable = true;

            deathmachine.MakeEngineNoise();
            deathmachine.MakeHonkNoise();

            thisCarLot.MyCarLot.Add(deathmachine);

            foreach (Car listCars in thisCarLot.MyCarLot)
            {
                Console.WriteLine(listCars.Year);
                Console.WriteLine(listCars.Make);
                Console.WriteLine(listCars.Model);
                Console.WriteLine($"Can you drive this car of the lot today? {listCars.IsDriveable}");
                listCars.MakeEngineNoise();
                listCars.MakeHonkNoise();
                Console.WriteLine("----------------");
            }
            

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
