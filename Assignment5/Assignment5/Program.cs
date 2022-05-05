using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
   public class WithdrawnException : ApplicationException
    {
        public WithdrawnException(string message) : base(message)
        {

        }
    }
    public class Bank
    {
        
        int Balance;
	int Amount = 35000;
        string Acc_Name;
        string Acc_Number;

        public Bank()
        {
            Console.WriteLine("Enter the Account Number : ");
            Acc_Number = Console.ReadLine();
            Console.WriteLine("Enter the Account holder Name :");
            Acc_Name = Console.ReadLine();

            Console.WriteLine($"The Account details is : Account Number {Acc_Number}, Acount Name {Acc_Name}, Balance is {Balance}");

        }


        public void DepositAmount()
        {
            Console.WriteLine("Enter the Amount you want deposit : ");
            int DepAmount = Convert.ToInt32(Console.ReadLine());

            if (DepAmount == 0)
            {
                Console.WriteLine("Minimum deposit amount is 500 ");

            }
            else
            {
                Balance = Amount + DepAmount;
                Console.WriteLine("Your Account Balance after deposited amount : " + Balance);
            }
        }

        public void Amount_Withdrawn()
        {

            Console.WriteLine("Enter the Amount you want to withdraw : ");
            int Withdrawn_Amount = Convert.ToInt32(Console.ReadLine());


            if (Withdrawn_Amount > Balance)
            {
                throw (new WithdrawnException("Insufficent balance"));
            }
            else
            {
                Balance = Balance - Withdrawn_Amount;
                Console.WriteLine("Your Account Balance after withdrawing the amount is :" + Balance);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            try
            {
                bank.DepositAmount();
                bank.Amount_Withdrawn();

            }
            catch (WithdrawnException WE)
            {
                Console.WriteLine(WE.Message);
            }
            catch (FormatException FE)
            {
                Console.WriteLine($"Enter only numbers ", FE);
            }
            Console.Read();
        }
    }
}

