using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012317
{
    class Animal
    {
        private int legs;
        private int size;
        private int weight;
        protected string color;
        protected bool isGoodToEat;

        public Animal()
        {

        }

        public Animal(int legs, string color)
        {
            this.legs = legs;
            this.size = size;

        }
        public Animal(int legs, int size, int weight)
        {
            this.legs = legs;
            this.size = size;
            this.weight = weight;

        }
        public Animal(int legs, int size, int weight, string color)
        {
            this.legs = legs;
            this.size = size;
            this.weight = weight;
            this.color = color;


        }
        public virtual void PrintAnimalInfo()
        {
            Console.WriteLine("This animal has: " + legs + "# of legs");
            Console.WriteLine("It's size is: " + size);
            Console.WriteLine("It weighs " + weight);
            Console.WriteLine("And is the color " + color);

        }
        protected void WhoAmI()
        {
            Console.WriteLine("I am an animal");
        }
        
    }
}

