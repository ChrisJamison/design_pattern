using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorDemo.Food;

namespace DecoratorDemo.Decorator
{
    class FoodWithSpicy : FoodDecorator
    {
        public FoodWithSpicy(IFood newFood)
            : base(newFood)
        {
        }

        public override string PrepareFood()
        {
            return base.PrepareFood() 
                + "With Hot Spicy.. ";
        }

        public override double FoodPrice()
        {
            return base.FoodPrice() + 10;
        }
    }
}
