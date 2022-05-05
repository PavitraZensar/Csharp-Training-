using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebase_test1
{
    internal class Program
    {`
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
        public void TicketBooking(int tickets)
        {
            no_of_tickets.Tickets = tickets;   
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
                Console.WriteLine("Enter number of tickets in number not in words inputmissmatch exception");
            }



        }
        static void Main(String[] args)
        {
            passenger passenger = new passenger("Seeta", 21);
            Console.WriteLine("Enter the number of tuckets to be booked");
            passenger.TicketBooking(int.Parse(Console.ReadLine());
            Console.ReadKey();

        }
    }
}
        



























