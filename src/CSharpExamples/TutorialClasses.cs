using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorials
{
    public class TutorialClasses
    {
        // a class is the design of an object
        // an object is an instance of a class

        public class Speedometer
        {
            // the standard way to interact with fields
            // is to use get and set
            private int _currentSpeed;
            public int CurrentSpeed
            {
                get
                {
                    return _currentSpeed;
                }
                set
                {
                    if (value < 0) { return; }
                    if(value > 120) { return; }
                    _currentSpeed = value;
                }
            }
        }
        // we extract this information as a
        // separate class rather than repeat it
        public class Address
        {
            public string StreetAddress { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string PostalCode { get; set; }
            public string Country { get; set; }
        }

        public class Person
        {
            // by default a class has an empty constructor
            // a constructor is used to initialise
            // the properties of an instance
            public Person(DateTime dateOfBirth)
            {
                DateOfBirth = dateOfBirth;
            }
            // we can specify a default value 
            // for each property by using =
            public string FirstName { get; set; } = string.Empty;
            public string LastName { get; set; } = string.Empty;
            public DateTime DateOfBirth { get; set; }
            public string TaxPayerId { get; set; } = string.Empty;
            public Address ShippingAddress { get; set; }

        }
        public class Company
        {
            public string Name { get; set; }
            public Address ShippingAddress { get; set; }
        }

        // inheritance 
        // one cannot make instances of abstract classes
        // 
        public abstract class Shape
        {
            // virtual means that children can override
            // virtual is not required in abstract class
            // because all are implicitly available 
            // for overwriting
            public abstract int Perimeter();
            public void DisplayShape()
            {
                Console.WriteLine($"Perimeter = {this.Perimeter()}");
            }
        }

        public class Rectangle:Shape
        {
            public int Height { get; set; }
            public int Width { get; set; }
            public override int Perimeter()
            {
                return (Height + Width) * 2;
            }
        }
        public class Triangle:Shape
        {
            public int Side1 { get; set; }
            public int Side2 { get; set; }
            public int Side3 { get; set; }
            public override int Perimeter()
            {
                return Side1 + Side2 + Side3;
            }
        }

        private void printShape(Shape shape)
        {
            Console.WriteLine($"Peri = {shape.Perimeter()}");
        }

        public void printPerimeters()
        {


            var rectangle = new Rectangle();
            rectangle.Height = 5;
            rectangle.Width = 6;
            printShape(rectangle);

            var triangle = new Triangle();
            triangle.Side1 = 3;
            triangle.Side2 = 4;
            triangle.Side3 = 5;
            printShape(triangle);

        }
    }
}
