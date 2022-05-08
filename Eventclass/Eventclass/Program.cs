using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventclass
{
    /* public delegate void MyDelegate(string str);
       class EventsEg2
       {
           public event MyDelegate MyEvent;

           public EventsEg2()
           {
               this.MyEvent += new MyDelegate(this.WelcomeUser);
               this.MyEvent += new MyDelegate(this.DisplayName);
           }

           public void WelcomeUser(string username)
           {
               Console.WriteLine("Welcome" + " " + username);
           }

           public void DisplayName(string str)
           {
               Console.WriteLine(str);
           }

           static void Main()
           {
               EventsEg2 ec2 = new EventsEg2();
               ec2.MyEvent("Seeta");
               Console.Read();
           }
       }
   }*/



    //Eg

    class EventClass
    {
        private int value = 2;

        public delegate void numbermanipulator(int x);
        public event numbermanipulator changenum;

        public virtual void onNumChange(int x)
        {
            Console.WriteLine($"Event Raised ..and the value from {value} is changed to {x}");
        }

        public EventClass(int n)
        {
            this.changenum += new numbermanipulator(this.onNumChange);
            setValue(n);
        }

        public void setValue(int x)
        {
            if (value != x)
            {

                changenum(x);
                value = x;
            }
            else
            {
                Console.WriteLine("No changes in the value");
            }
        }
    }
    class EventsEg
    {
        static void Main(string[] args)
        {
            EventClass ec = new EventClass(24);
            ec.setValue(12);
            ec.setValue(18);
            ec.setValue(36);
            Console.Read();
        }
    }
}

