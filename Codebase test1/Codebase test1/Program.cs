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
    }
    class Passenger
    {
        string name;
        string DateofTravel;
        int Age;
        Passenger(string name, string DateofTravel, int Age)
        {
            this.name = name;
            this.DateofTravel = DateofTravel;
            this.Age = Age;
        }

        public void TicketBooking(int no_of_tickets)
        {
            if (no_of_tickets > 5)
            {
                throw (new TicketsException("No more than 5 tickets"));
            }
            else
            {
                Console.WriteLine("Tickets successfully: {0}", no_of_tickets);

            }
        }

        public static void Main()
        {
            int no_tickets;
            no_tickets = Convert.ToInt32(Console.Read());
            Console.WriteLine(no_tickets);
            Passenger pass = new Passenger("Seeta", "5-05-2022", 21);
            pass.TicketBooking(no_tickets);

        }
    }
}







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
            passenger(string name, string Dateoftravel, int age)
        {
            this.name=name;
            this.Dateoftravel=Dateoftravel;
            this.age=age;
        
        public void TicketBooking(int no_of_tickets)
        {
                    try
                    {


                        if (no_of_tickets > 5)
                        {
                            throw (newTicketException("Cannot print more than 5tickets");
                        }
                        else
                        {
                            Console.WriteLine("Tickets Booked Successfully is {0}", no_of_tickets);
                        }
                    }

                    catch (Exception)
                    {
                        Console.WriteLine("inputmissmatch exception");
                    }



            }
            static void Main(String[] args)
            {
                int no_tickets;
                no_tickets = Convert.ToInt32(Console.Read());
                Console.WriteLine(no_tickets);
                passenger passenger = new passenger("Seeta", 21, 12/12/2002);
                pass.TicketBooking(no_tickets);
            }
        }
    }




























