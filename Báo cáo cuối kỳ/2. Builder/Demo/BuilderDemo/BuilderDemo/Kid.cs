using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public class Kid
    {
        public string Name { get; set; }

        //construct process to build an animal object, 
        //after this process completed, a object 
        //will be consider as a ready to use object.
        public void MakeAnimal(AnimalBuilder aAnimalBuilder)
        {
            aAnimalBuilder.BuildAnimalHeader();
            aAnimalBuilder.BuildAnimalBody();
            aAnimalBuilder.BuildAnimalLeg();
            aAnimalBuilder.BuildAnimalArm();
            aAnimalBuilder.BuildAnimalTail();
        }
    }
}
