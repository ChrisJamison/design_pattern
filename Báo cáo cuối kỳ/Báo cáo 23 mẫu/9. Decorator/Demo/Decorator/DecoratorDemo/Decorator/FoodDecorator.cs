using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorDemo.Food;

namespace DecoratorDemo.Decorator
{
    public abstract class FoodDecorator: IFood
    {
        protected IFood _newFood;

        protected FoodDecorator(IFood newFood)
        {
            this._newFood = newFood;
        }

        public virtual string PrepareFood()
        {
            return _newFood.PrepareFood();
        }

        public virtual double FoodPrice()
        {
            return _newFood.FoodPrice();
        }
    }
}
