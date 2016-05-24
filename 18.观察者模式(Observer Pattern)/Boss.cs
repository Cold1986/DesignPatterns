using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    public delegate void EventHandler();

    public class Boss : ISubject
    {
        public event EventHandler Update;

        private string action;
        public void Notify()
        {
            Update();
        }
        

        public string SubjectState
        {
            get
            {
                return action;
            }
            set
            {
                action = value;
            }
        }
    }

    public class Secretary : ISubject
    {
        //声明一事件Update，类型为委托EventHandler  
        public event EventHandler Update;

        private string action;

        public void Notify()
        {
            Update();
        }
        public string SubjectState
        {
            get { return action; }
            set { action = value; }
        }  
    }

}
