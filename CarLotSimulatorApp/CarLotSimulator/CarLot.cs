using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{

    //*************BONUS X 2*************//

    //Create a CarLot class
    //It should have at least one property: a List of cars


    // Building on our car lot simulator project, create a CarLot class with a static field called numberOfCars.
    // Have this number only increment when in our program we create a new Car.
    // From there create 3 cars in the Main() and then each time you create a car, do a Console.WriteLine()
    // printing the current number of cars in the car lot.



    public class CarLot
    {
        public CarLot()
        {
        }

        public List<Car> Cars = new List<Car>();

        public static int numberOfCars = 0;


    }
}
