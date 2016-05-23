using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    public class NBAObserver
    {
        private string name;
        private ISubject sub;
        public NBAObserver(string name, ISubject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        /// <summary>
        /// 关闭NBA直播
        /// </summary>
        public void CloseNBADirectSeeding()
        {
            Console.WriteLine("{0} {1} 关闭NBA直播，继续工作！", sub.SubjectState, name);
        }
    }
}
