﻿using System;
using System.Collections;
using System.Collections.Generic;
using IntroductionClasses;
using AssociationBetweenClasses;
using Inheritance;
using Polymorphism;
using Interfaces;

namespace UltimateCSharpPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            //IntroducingClasses();

            //AssociationBetweenClasses();

            //Inheritance();

            //Polymorphism();

            Interfaces();
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
            //var cookie = new HttpCookie();
            //cookie.Expiry = DateTime.Today.AddDays(5);
            //cookie["name"] = "Ivan";
            //Console.WriteLine(cookie["name"]);
            //Console.WriteLine(cookie.Expiry);
        }

        static void AssociationBetweenClasses()
        {
            // Inheritance
            //var text = new Text();
            //text.Width = 100;
            //text.Copy();


            // Composition
            //var logger = new Logger();
            //var dbMigrator = new DbMigrator(logger);
            //var installer = new Installer(logger);
            //dbMigrator.Migrate();
            //installer.Install();
        }

        static void Inheritance()
        {
            // Access Modifiers
            //var goldCustomer = new GoldCustomer();
            //goldCustomer.OfferVoucher();


            // Constructors and Inheritance
            //var car = new Car("XYZ1234");


            // Upcasting and Downcasting
            //var text = new Inheritance.Text();

            //// Upcasting - text and shape are pointing/reference to the same object in memory
            //// Upcasting is implicit, you can convert a object reference to its base class reference
            //Shape shape = text;
            //text.Width = 200;
            //shape.Width = 100;
            //Console.WriteLine(text.Width);

            //// Downcasting
            //// Downcasting is used to convert an object to a more specific type
            //// To do that you can use an explicit cast "Inheritance.Text)shape1"
            //// or the as keyword "shape1 as Inheritance.Text"
            //// shape1 here won't have access to Text methods or properties
            //// You need to downcast to be able to access the Text methods or properties
            //Shape shape1 = new Inheritance.Text();
            //// After downcasting you are able to access all Text methods and properties
            //Inheritance.Text text1 = (Inheritance.Text)shape1;
            //// Or Better to downcasting in a safer way
            //var text2 = shape1 as Inheritance.Text;


            // Boxing and Unboxing
            // Boxing - The process of converting a value type instance to an object reference
            //int number = 10;
            //object obj = number;
            //Console.WriteLine(obj.ToString());

            //// Unboxing - Converting an object reference into a value type instance
            //object obj2 = 10;
            //int number2 = (int)obj2;

            //// Both have a performance penalty. So you should avoid doing it.
            //// ArrayLists receive an object, if you send string, int or any other value type, you are doing boxing.
            //var list = new ArrayList();
            //list.Add(1);
            //list.Add("Ivan");
            //list.Add(DateTime.Today);
            //// Instead of using ArrayLists, in this case you should use Generic Lists
            //// In Generic List you can set the type you want.
            //// So in this case, sending a int to this list won't do a boxing or unboxing
            //var anotherList = new List<int>();
            //anotherList.Add(1);
        }

        static void Polymorphism()
        {
            // Method Overriding
            //var shapes = new List<PolyShape>();
            //shapes.Add(new Circle());
            //shapes.Add(new Rectangle());
            //shapes.Add(new Triangle());
            //var canvas = new Canvas();
            //canvas.DrawShapes(shapes);


            // Abstract Classes and Members
            // We cannot instanciate shape, because it is declared as abstract
            //var shape = new AbstractShape();
            //var circle = new CircleAbstractExample();
            //circle.Draw();
            //var rectangle = new RectangleAbstractExample();
            //rectangle.Draw();


            // Sealed Class
            //var sealedClass = new SealedClassExample();
            //var sealedFunctionClass = new SealedFunctionExample();
            //sealedFunctionClass.Draw();
        }

        static void Interfaces()
        {
            // Interfaces and Testability
            // var orderProcessor = new OrderProcessor(new ShippingCalculator());
            // var order = new Interfaces.Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            // orderProcessor.Process(order);


            // Interfaces and Extensibility
            // var dbMigrator = new Interfaces.DbMigrator(new ConsoleLogger());
            // dbMigrator.Migrate();
            // var dbMigrator2 = new Interfaces.DbMigrator(new FileLogger("/Users/itabarino/Downloads/log.txt"));
            // dbMigrator2.Migrate();


            // Interfaces are NOT for Multiple Inheritance
            // One of the common misconceptions about interfaces is that they are used to implement multiple inheritance in C#.
            // This is fundamentally wrong, yet many books and videos make such a false claim.
            // With inheritance, we write code once and re-use it without the need to type all that code again.
            // With interfaces, we simply declare the members the implementing class should contain.
            // Then we need to type all that declaration along with the actual implementation in that class.
            // So, code is not inherited, even the declaration of the members!
            // In Inheritance you write all the code in the parent class
            // and all derived classes inherit all the code from the parent class
            // The Interfaces don't have any code, just includes the method declaration
            // So, there is not code to inherit
            // A class implements an Multiple Interface and extends from only one class.
            // Check the code in the TextBox to see that extends from UiControl and implements IDraggable and IDroppable
            // var textBox = new TextBox();
            // textBox.Focus();


            // Interfaces and Polymorphism
            // OCP - software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification.
            // We implemented the OCP (Open-Closed Principle) here.
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            encoder.Encode(new Video());
        }
    }
}
