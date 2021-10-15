using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();
            Car acura = new Car() { HasTrunk = true, Make = "Acura", Model = "TLX", Year = 2022 };
            Motorcycle honda = new Motorcycle() { HasSideCart = true, Make = "Honda", Model = "CBR500R", Year = 2021 };

            Vehicle SUV = new Car() { HasTrunk = true, Make = "Mazda", Model = "CX-5", Year = 2023 };
            Vehicle hyundai = new Car() { HasTrunk = true, Make = "Hyundai", Model = "Sonata", Year = 2020};

            vehicles.Add(acura);
            vehicles.Add(honda);
            vehicles.Add(SUV);
            vehicles.Add(hyundai);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine();
                Console.WriteLine("Output Information for this vehicle:");
                
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
            Console.WriteLine();
            Console.WriteLine("==========================");
            Console.WriteLine("Calling Methods:");
            acura.DriveAbstract();
            acura.DriveVirtual();
            honda.DriveAbstract();
            honda.DriveVirtual();
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*  
             * DONE - Create an abstract class called Vehicle
             *DONE -  The vehicle class shall have three string properties Year, Make, and Model
             * DONE - Set the defaults to something generic in the Vehicle class
             * DONE - Vehicle shall have an abstract method called DriveAbstract with no implementation
             * DONE - Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             *DONE- Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONE -Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONE -Provide the implementations for the abstract methods
             * DONE - Only in the Motorcycle class will you override the virtual drive method
            */

            // DONE - Create a list of Vehicle called vehicles

            /*
             * DONE-Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * DONE- new it up as one of each derived class
             *DONE- Set the properties with object initializer syntax
             */

            /*
             *DONE- Add the 4 vehicles to the list
             *DONE- Using a foreach loop iterate over each of the properties
             */

            //DONE- Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
