using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class ChangePersonDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("ChangePersonDemo: Demonstrates that you can modify a property on array elements using foreach");

            Person[] people = new Person[]
            {
                new Person { Name = "Jill", Age = 32},
                new Person { Name = "Ben", Age = 20 }
            };

            // set the age of all persons in the list to 40
            // Person is a reference type. So we can modify the property on an array elements
            foreach(Person person in people)
            {
                person.Age = 40;
                person.Name = "DummyName";
            }

            foreach(Person person in people)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format($"[{Name}, age = {Age}]");
        }
    }
}
