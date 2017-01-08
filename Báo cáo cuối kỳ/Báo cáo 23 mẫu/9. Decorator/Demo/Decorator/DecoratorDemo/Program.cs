using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorDemo.Decorator;
using DecoratorDemo.Food;

namespace DecoratorDemo
{
    class Program
    {
        private static int choice;
        static void Main(string[] args)
        {
            do
            {
                System.Console.Write("========= IFood Menu ============ \n");
                System.Console.Write("            1. Vegetarian.        \n");
                System.Console.Write("            2. Non-Vegetarian.    \n");
                System.Console.Write("            3. Chineese.          \n");
                System.Console.Write("            3. Chineese with Spicy.   \n");
                System.Console.Write("            4. Exit                   \n");
                System.Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            VegFood vf = new VegFood();
                            System.Console.WriteLine(vf.PrepareFood());
                            System.Console.WriteLine(vf.FoodPrice());
                            break;
                        }
                    case 2:
                        {
                            IFood f1 = new NonVegFood(new VegFood());
                            System.Console.WriteLine(f1.PrepareFood());
                            System.Console.WriteLine(f1.FoodPrice());
                            break;
                        }
                    case 3:
                        {
                            IFood f2 = new ChineseFood((IFood)new VegFood());
                            System.Console.WriteLine(f2.PrepareFood());
                            System.Console.WriteLine(f2.FoodPrice());
                            break;
                        }
                    case 5:
                        {
                            IFood f3 = new FoodWithSpicy((IFood)new ChineseFood(new VegFood()));
                            System.Console.WriteLine(f3.PrepareFood());
                            System.Console.WriteLine(f3.FoodPrice());
                            break;
                        }

                    default:
                        {
                            System.Console.WriteLine("Other than these no IFood available");
                            return;
                        }
                }

            } while (choice != 4);
        }
    }
}
