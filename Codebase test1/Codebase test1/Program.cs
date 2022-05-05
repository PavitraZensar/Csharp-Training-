using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebase_test1
{
   
    public class TicketsException : Exception
    {
        public TicketsException(string message) : base(message)
        {
        }
    public class passenger
    {
       string name;
        string Dateoftravel;
        int age;
        passenger(string name, string Dateoftravel, int age;)
        {
            this.name=name;
            this.Dateoftravel=dateoftravel;
            this.age=age;
        public void TicketBooking(int no_of_tickets)
        {
             
            try
            {


                if (no_of_tickets > 5)
                {
                    Console.WriteLine("TicketException Cannot print more than 5tickets");
                }
                else
                {
                    Console.WriteLine("Tickets Booked Successfully");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("inputmissmatch exception");
            }



        }
        static void Main(String[] args)
        {
            int no_of_tickets;
            no_tickets = Convert.ToInt32(Console.Read());
            Console.WriteLine(no_of_tickets);
            passenger passenger = new passenger("Seeta", 21);
            pass.TicketBooking(no_of_tickets);
        }
    }
}
        



























