using DecoratorDemo.Food;

namespace DecoratorDemo.Decorator
{
    class ChineseFood: FoodDecorator
    {
        public ChineseFood(IFood newFood)
            : base(newFood) 
        { 
        }

        public override string PrepareFood()
        {
            return _newFood.PrepareFood() 
                + " With Fried Rice and Manchurian ";
        }

        public override double FoodPrice()
        {
            return _newFood.FoodPrice() + 65.0;
        }  
    }
}
