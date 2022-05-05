using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebase_test1
{
    public class passenger
    {
        public string Name { get; set; };
        public int Age { get; set; };

        Tickets no_of_tickets { get; set; };
        public Passenger(string Name, int Age,)
        {
            Name = Name;
            Age = Age;

            no_of_tickets = new tickets;
        }
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
        





























    /* class passenger
    {
        string Name;
        int Age;
        Dateof Date of travel;
        int no_of_tickets;



        int car_no;
        string car_name;
        String car_type;
        readonly double cost = 500000;
        public Car(int car_no; string car_name; String car_type;)
            {
               this.car_no = car_no;
               this.car_name = car_name;
               this.car_type = car_tpe;
               this.cost = Cost;
               Console.WriteLine("the car_no is {car_no}, car_name is {car_name}, car_type is {car_type}, car_cost is {car_cost}");
            }

}
    Name, Age,DateofTravel,no_of_tickets
}*/
