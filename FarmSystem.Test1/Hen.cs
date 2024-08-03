using System;

namespace FarmSystem.Test1
{    
    public class Hen : Animal
    {
        public Hen() 
        { 
            NOOfLegs = 2; //Set specific property values for Hen
        }

        public override void Enter()
        {
            Console.WriteLine("Hen has entered the farm");
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Hen says CLUCKAAAAAWWWWK!");
        }

        public override void Release()
        {
            Console.WriteLine("Hen has left the farm");
        }
    }
}
