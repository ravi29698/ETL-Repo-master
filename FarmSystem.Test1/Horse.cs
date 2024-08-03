using System;

namespace FarmSystem.Test1
{    
    public class Horse : Animal
    {
        public Horse()
        {
            NOOfLegs = 4; //Set specific property values for Horse
        }

        public override void Enter()
        {
            Console.WriteLine("Horse has entered the farm");
        }
        public override void MakeNoise()
        {
            Console.WriteLine("Horse says Neigh!");
        }

        public override void Release()
        {
            Console.WriteLine("Horse has left the farm");
        }
    }
}