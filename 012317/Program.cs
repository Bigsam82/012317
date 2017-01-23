using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012317
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal animal1 = new Animal(4, 12, 500, "white");
            Animal animal2 = new Animal(6, 1, 1);
            
            
            animal1.PrintAnimalInfo();
            animal2.PrintAnimalInfo();

            Cat cat1 = new Cat("grumpy", "long", false, "blue");
            cat1.PrintAnimalInfo();
            cat1.Speak();

            Fish fish1 = new Fish(5, true, true, "salt");
            fish1.Swim();
           
            
        }


      
    }
}
