using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012317
{
    class Cat:Animal
    {
        
        private string breed;
        private string furLength;

        protected bool deClawed;

        public int Legs
        {
            get { return this.Legs; }
            set { this.Legs = value; }
        }


       public Cat(string breed, string furLength, bool deClawed, string color):base(4,3,5,"grey")
           
        {
            this.breed = breed;
            this.furLength = furLength;
            this.deClawed = deClawed;
            this.color = color;
            isGoodToEat = true;
        }
        public void Speak()
        {
            Console.WriteLine("Meow");
        }
        public override void PrintAnimalInfo()
        {
            Console.WriteLine("I am a cat");
            base.PrintAnimalInfo();
            Console.WriteLine("Fur lenght is: " + " " + furLength);
            Console.WriteLine("The Breed is:  " + breed + "cat");
            Console.WriteLine("Declawed: " + true);
        }
    }
}
