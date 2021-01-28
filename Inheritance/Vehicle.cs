using System;

namespace Inheritance
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        public Vehicle(string registrationNumber)
        {
            Console.WriteLine("Vehicle is being initialised.");

            this._registrationNumber = registrationNumber;

            Console.WriteLine($"Registration Number: {registrationNumber}");
        }
    }
}
