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

        private bool deClawed;


       public Cat(string breed, string furLength, bool deClawed):base(4,3,3)
        {
            this.breed = breed;
            this.furLength = furLength;
            this.deClawed = deClawed;
        }

    }
}
