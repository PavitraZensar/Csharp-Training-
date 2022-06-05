using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHandson
{
    delegate void EmployeeDelegate(string s); //declaration of a delegate 
    delegate void SecondDelegate();
    class Delegate1
    {
        public void accept(string s)
        {
            Console.WriteLine("Hello " + " " + s);
        }
        public static void Show(string s)
        {
            Console.WriteLine(s);
        }

        public void NoParameterMethod()
        {
            Console.WriteLine("Reached No parameter Method");
        }
        public string Message()
        {
            return "Hi";
        }



    }





    internal class Program
    {
        delegate int salaryChange(int s);
        class Delegate2
        {
            static int sal = 100000;
            public static int Addsal(int p)
            {
                sal += p;
                return sal;
            }

            public static int Multiplysal(int q)
            {
                sal *= q;
                return sal;
            }
            public static int getsal()
            {
                return sal;
            }

            static void Main()
            {
                //create delegate instances 
                salaryChange nc1 = new salaryChange(Addsal);
                salaryChange nc2 = new salaryChange(Multiplysal);
                //calling the methods using the delegate objects
                Console.WriteLine("Value of salary before delegate call : {0}", getsal());
                nc1(25000);
                Console.WriteLine("Value of salary after delegate nc1 call : {0}", getsal());
                nc2.Invoke(5);
                Console.WriteLine("Value of salary after delegate nc2 call : {0}", getsal());
                Console.Read();




                Delegate1 del1 = new Delegate1();
                Console.WriteLine(del1.Message());
                EmployeeDelegate empd1 = new EmployeeDelegate(Show);
                EmployeeDelegate empd2 = new EmployeeDelegate(del1.accept);
                SecondDelegate sd = new SecondDelegate(del1.NoParameterMethod);

                empd1("Pavitra");
                empd2.Invoke("Padma");
                sd();
                Console.Read();
            }
        }
    }

}
































