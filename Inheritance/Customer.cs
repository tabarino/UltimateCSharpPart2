using System;

namespace Inheritance
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        protected void Promote()
        {
            // It's not a good practice to instanciate a object inside of a method
            // Because this creates coupling or dependency of this object
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);

            if (rating == 10)
            {
                Console.WriteLine("Promoted to Level 1");
            }
            else
            {
                Console.WriteLine("Promoted to Level 2");
            }
        }
    }
}
