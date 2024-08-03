using FarmSystem.Test2;
using System;

namespace FarmSystem.Test1
{    
    // Implement Cow class that inherits from Animal
    public class Cow : Animal, IMilkableAnimal
    {
        public Cow() 
        {
            NOOfLegs = 4; // Set specific property values for Cow
        }
        public override void Enter()
        {
            Console.WriteLine("Cow has entered the farm");
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Cow says Moo!");
        }
        public void ProduceMilk()
        {
            Console.WriteLine("Cow was milked!");
        }

        public override void Release()
        {
            Console.WriteLine("Cow has left the farm");
        }
    }
}