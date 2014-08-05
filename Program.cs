using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    public class Animal
    {
        public virtual void Greet()
        {
            Console.WriteLine("Hello, I'm some sort of animal!");
        }
    }

    public class Dog : Animal
    {
        public override void Greet()
        {
            base.Greet();
            Console.WriteLine("Yes I am - a dog!");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Greet();
            Dog dog = new Dog();
            dog.Greet();
            Console.ReadKey();

        }
    }
}
