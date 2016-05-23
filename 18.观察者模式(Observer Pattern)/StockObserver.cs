using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    /// <summary>
    /// 看股票的同事
    /// </summary>
    public class StockObserver
    {
        private string name;
        private ISubject sub;
        public StockObserver(string name, ISubject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void CloseStockMarket()
        {
            Console.WriteLine("{0} {1} 关闭股票行情，继续工作！", sub.SubjectState, name);
        }
    }
}
