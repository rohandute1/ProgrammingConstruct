using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
    }

    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} is barking.");
        }
    }

    class Puppy : Dog
    {
        public Puppy(string name) : base(name)
        {
        }

        public void Play()
        {
            Console.WriteLine($"{Name} is playing.");
        }
    }

    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public void Meow()
        {
            Console.WriteLine($"{Name} is meowing.");
        }
    }
}
