using System;
using Animals.library;

namespace Animals.library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var dog = new Dog();
            dog.GoTo("door");
            dog.MakeNoise();
        }
    }
}
