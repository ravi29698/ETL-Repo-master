using FarmSystem.Test2;
using System;
using System.Collections.Generic;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        private Queue<Animal> animalQueue = new Queue<Animal>();

        // Event to be triggered when the farm is empty
        public event EventHandler FarmEmpty;

        //TEST 1
        public void Enter(Animal animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            animalQueue.Enqueue(animal); // Add animal to the queue
            animal.Enter(); // Display enter message
        }

        public void Release()
        {
            if (animalQueue.Count > 0)
            {
                Animal animal = animalQueue.Dequeue(); // Remove the animal from the queue
                animal.Release(); // Display release message
            }

            OnFarmEmpty(); // Invoke the event after all animals are released
        }

        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            if (animalQueue.Count > 0)
            {
                foreach (Animal animal in animalQueue)
                {
                    animal.MakeNoise(); // Call MakeNoise on each animal
                }
            }
            else
            {
                Console.WriteLine("There are no animals in the farm");
            }
            
        }

        //TEST 3
        public void MilkAnimals()
        {
            //Findout if any milkable animals exists
            bool milkableAnimalExists = false;
            foreach (Animal animal in animalQueue)
            {
                // Check if the animal implements IMilkableAnimal
                if (animal is IMilkableAnimal milkableAnimal)
                {
                    milkableAnimalExists = true;
                    milkableAnimal.ProduceMilk(); // Milk the animal if it is milkable
                }
            }
            if (!milkableAnimalExists)
            {
                Console.WriteLine("Cannot identify the farm animals which can be milked");
            }           
            
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            //Console.WriteLine("There are still animals in the farm, farm is not free");
            while (animalQueue.Count > 0)
            {
                Animal animal = animalQueue.Dequeue();
                animal.Release();
            }

            OnFarmEmpty(); // Invoke the event after all animals are released
        }

        // Method to invoke the FarmEmpty event
        protected virtual void OnFarmEmpty()
        {
            FarmEmpty?.Invoke(this, EventArgs.Empty);
        }

    }
}