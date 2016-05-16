using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodManager foodManager = new FoodManager();
            Builder instance;

            instance = (Builder)Assembly.Load("3.建造者模式（Builder Pattern）").CreateInstance("建造者模式." + "GoldBuilder");
            foodManager.Construct(instance);

            Food food = instance.GetFood();
            food.Show();

            Console.ReadLine();
        }
    }
}
