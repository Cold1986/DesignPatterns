using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    /// <summary>
    /// Food类，即产品类
    /// </summary>
    public class Food
    {
        Hashtable food = new Hashtable();

        /// <summary>
        /// 添加食品
        /// </summary>
        /// <param name="strName">食品名称</param>
        /// <param name="Price">价格</param>
        public void Add(string strName, string Price)
        {
            food.Add(strName, Price);
        }

        public void Show()
        {
            IDictionaryEnumerator myEnumerator = food.GetEnumerator();
            Console.WriteLine("Food List:");
            Console.WriteLine("---------------");
            string strFoodList = "";
            while (myEnumerator.MoveNext())
            {
                strFoodList = strFoodList + "\n\n" + myEnumerator.Key.ToString();
                strFoodList = strFoodList + ":\t" + myEnumerator.Value.ToString();
            }
            Console.WriteLine(strFoodList);
            Console.WriteLine("\n---------------------");

        }

    }
}
