using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss huhansan = new Boss();//老板胡汉三

            StockObserver tongshi1 = new StockObserver("魏关姹", huhansan);//看股票的同事
            NBAObserver tongshi2 = new NBAObserver("易管查", huhansan);//看NBA的同事

            huhansan.Update += new EventHandler(tongshi1.CloseStockMarket);
            huhansan.Update += new EventHandler(tongshi2.CloseNBADirectSeeding);

            huhansan.SubjectState = "我胡汉三回来了";

            huhansan.Notify();

            Console.ReadLine();
        }
    }
}
