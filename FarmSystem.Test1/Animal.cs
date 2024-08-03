using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
    // Define an abstract class Animal with encapsulated properties and abstract methods
    public abstract class Animal
    {

        public string id { get; set; }
        public int NOOfLegs { get; set; }

        public Animal() 
        {
            id = Guid.NewGuid().ToString(); //Automatically assign a unique ID
        }

        public abstract void Enter();
        public abstract void MakeNoise();
        public abstract void Release();
    }
}
