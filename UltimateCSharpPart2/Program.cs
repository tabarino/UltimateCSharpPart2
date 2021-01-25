using System;
using IntroductionClasses;

namespace UltimateCSharpPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroducingClasses();
        }

        static void IntroducingClasses()
        {
            //var person = Person.Parse("John");
            //person.Introduce("Ivan");


            //var customer = new Customer(1, "John");
            //var order = new Order();
            //customer.Orders.Add(order);
            //Console.WriteLine(customer.Id);
            //Console.WriteLine(customer.Name);


            // Instead of Creating many Constructors to set the parameters
            // You can use Object Initialization like this.
            // In this way you can leave your constructor clean and empty and can keep setting the paramaters
            //var objectInitializer = new ObjectInitializers
            //{
            //    FirstName = "Ivan",
            //    LastName = "Tabarino"
            //};
            //Console.WriteLine(objectInitializer.FirstName);
            //Console.WriteLine(objectInitializer.LastName);


            // Use Points
            //try
            //{
            //    var point = new Point(10, 20);
            //    point.Move(new Point(40, 60));
            //    Console.WriteLine($"Point is at ({point.X}, {point.Y})");

            //    point.Move(100, 200);
            //    Console.WriteLine($"Point is at ({point.X}, {point.Y})");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An unexpected error ocurred - {ex.Message}");
            //}


            // Use Params
            //var calculator = new Calculator();
            //Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));


            // Do not use "out" or "ref". It is a bad practice
            // This is the only exception where we can use "out"
            //int number;
            //var result = int.TryParse("abc", out number);
            //if (result)
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Conversion Failed.");
            //}

            // However you can do the same in this way without the TryParse and the "out"
            //try
            //{
            //    var number2 = int.Parse("abc");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Conversion Failed - {ex.Message}");
            //}


            //var customerFields = new CustomerFields(1);
            //customerFields.Orders.Add(new OrderFields());
            //customerFields.Orders.Add(new OrderFields());
            //Console.WriteLine(customerFields.Orders.Count);


            //var person = new PersonAccessModifiers();
            //person.Name = "Ivan";
            //person.Name = "Ivan2";
            //person.Birthday = new DateTime(1982, 1, 1);
            //Console.WriteLine(person.Birthday);
            //person.ShowValues();


            //var person = new PersonProperties(new DateTime(1982, 1, 1));
            //Console.WriteLine(person.Age);


            // Indexers
            var cookie = new HttpCookie();
            cookie["name"] = "Ivan";
            Console.WriteLine(cookie["name"]);
        }
    }
}
