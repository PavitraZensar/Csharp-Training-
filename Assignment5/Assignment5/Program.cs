using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
<<<<<<< HEAD

    public class WithdrawnException : ApplicationException
    {
        public WithdrawnException(string msg) : base(msg)
=======
   public class WithdrawnException : ApplicationException
    {
        public WithdrawnException(string message) : base(message)
>>>>>>> 622dc9dac7cb921258954a04fcab06d7cb77d52e
        {

        }
    }
    public class Bank
<<<<<<< HEAD
    {
        int Amount = 35000;
        int Balance;
        string Acc_Name;
        string Acc_Number;

        public Bank()
        {
            Console.WriteLine("Enter the Account Number : ");
            Acc_Number = Console.ReadLine();
            Console.WriteLine("Enter the Account holder Name :");
            Acc_Name = Console.ReadLine();

            Console.WriteLine($"The Account details is : Account Number {Acc_Number}, Account Name {Acc_Name}, Balance is {Balance}");

        }


        public void DepositAmount()
        {
            Console.WriteLine("Enter the Amount to be deposited : ");
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
                Console.WriteLine("Your Account Balance is After With Draw the amount :" + Balance);
            }
        }
    }
    internal class Program
    {
=======
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
>>>>>>> 622dc9dac7cb921258954a04fcab06d7cb77d52e
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

<<<<<<< HEAD

/* internal class Program
 {
         class Bank
         {

             String acc_name = "Pavitra";
             String acc_num;
             int money = 35000;
             static String bank_name = "ICICI Bank";
             static public int NewBalance;



             public void DepositMoney()
             {

                 Console.WriteLine("\nEnter the amount you want to deposit:");
                 int depMoney = int.Parse(Console.ReadLine());
                 NewBalance = money + depMoney;
                 if (depMoney == 0)
                 {
                     Console.WriteLine("Minimum deposit should be 500 ");
                 }
                 else
                 {
                     Console.WriteLine("New balance of " + acc_name + " after deposit is " + NewBalance);
                 }

             }
             public void WithdrawMoney()
             {
                 try
                 {
                     Console.WriteLine("Welcome! " + acc_name + " your account balance: " + NewBalance);
                     Console.WriteLine("\nEnter the amount you want to withdraw from your account:");
                     int withdraw = int.Parse(Console.ReadLine());
                     NewBalance = NewBalance - withdraw;
                     if (withdraw > NewBalance)
                     {
                         Console.WriteLine("Entered amount is Insufficient balance");
                     }
                     else
                     {
                         Console.WriteLine("updated balance of " + acc_name + " after withdrawal is " + NewBalance);
                     }

                 }
                 catch (Exception)
                 {
                     Console.WriteLine("Enter balance in number not in words inputmissmatch exception ");
                 }
             }
             public void Balance()
             {
                 Console.WriteLine("Welcome to the " + bank_name + "bank ");
                 Console.WriteLine("Enter your account number: ");
                 acc_num = Console.ReadLine();
                 Console.WriteLine("Welcome! " + acc_name + " your account balance: " + money);

             }
         }
         static void Main()
         {
             Bank bank = new Bank();
             bank.Balance();
             bank.DepositMoney();
             bank.WithdrawMoney();
             Console.ReadLine();
         }
     }
 }*/

=======
>>>>>>> 622dc9dac7cb921258954a04fcab06d7cb77d52e
