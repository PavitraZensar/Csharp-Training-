using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    interface IStudent
    {
        void DisplayDetails(string Name, int Id);
    }
    class DayScholar : IStudent
    {
        public void DisplayDetails(string Name, int Id)
        {
            
            Console.WriteLine("Name of the Student is: {0}", Name);
            Console.WriteLine("Student id is: {0}", Id);
        }
    }
    class Hosteller : IStudent
    {
        public void DisplayDetails(string Name, int Id)
        {
            
            Console.WriteLine("Name of the Student is: {0}", Name);
            Console.WriteLine("Student id is: {0}", Id);
        }
    }
    class InterfaceEg
    {
        static void Main(string[] args)
        {

            IStudent obj = new DayScholar();
            obj.DisplayDetails("Rama", 24);


            IStudent obj1 = new Hosteller();
            obj1.DisplayDetails("Seeta", 36);
            Console.ReadLine();

        }
    }

}
