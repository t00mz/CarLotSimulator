using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            var lot = new CarLot();

            
            
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var bmw = new Car();
            bmw.Year = 2020;
            bmw.Make = "BMW";
            bmw.Model = "7.50i";
            bmw.EngineNoise = "vroom";
            bmw.HonkNoise = "beep";
            bmw.IsDriveable = true;

            bmw.MakeEngineNoise(bmw.EngineNoise);
            bmw.MakeHonkNoise(bmw.HonkNoise);

            var honda = new Car()
            {
                Year = 2019,
                Make = "Civic",
                Model = "Civic",
                EngineNoise = "vrum",
                HonkNoise = "honk",
                IsDriveable = true
            };


           honda.MakeEngineNoise(honda.EngineNoise);
           honda.MakeHonkNoise(honda.HonkNoise);
          

            var benz = new Car(2018, "Mercedes", "E350", "vroum", "honkk", true);

           benz.MakeEngineNoise(benz.EngineNoise);
           benz.MakeHonkNoise(benz.HonkNoise);

            lot.Cars.Add(bmw);
            lot.Cars.Add(honda);
            lot.Cars.Add(benz);

            Console.WriteLine($"Number of cars in lot: {CarLot.numberOfCars}");

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}.");
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
