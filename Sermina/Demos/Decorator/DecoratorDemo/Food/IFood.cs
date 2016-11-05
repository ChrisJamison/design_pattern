using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo.Food
{
    public interface IFood
    {
        String PrepareFood();
        double FoodPrice();  
    }
}
