namespace DecoratorDemo.Decorator
{
    using DecoratorDemo.Food;
    public class NonVegFood : FoodDecorator {

        public NonVegFood(IFood newFood): base(newFood)
        {
        }

        public override string PrepareFood()
        {
            return _newFood.PrepareFood() 
                + " With Roasted Chiken and Chiken Curry ";
        }

        public override double FoodPrice()
        {
            return _newFood.FoodPrice() + 150.0;
        }  
    }
}
