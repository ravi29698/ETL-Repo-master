using System;

namespace FarmSystem.Test1
{    
    public class Sheep : Animal
    {
        public Sheep()
        {
            NOOfLegs = 4; //Set specific property values for Sheep
        }

        public override void Enter()
        {
            Console.WriteLine("Sheep has entered the farm");
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Sheep says baa!");
        }
        public override void Release()
        {
            Console.WriteLine("Sheep has left the farm");
        }
    }
}