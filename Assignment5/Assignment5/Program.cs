using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
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
	}
  
