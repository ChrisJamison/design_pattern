using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo.Food
{
    class VegFood: IFood
    {
        public String PrepareFood()
        {
            return "Veg Food";
        }

        public double FoodPrice()
        {
            return 50.0;
        }  
    }
}
