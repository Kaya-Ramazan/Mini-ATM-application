using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mini ATM application
            //We get a value from the user and we act according to the value we get. (Switch - Case) We will use it.
            // 1 - Balance Display
            // 2 - Withdrawal
            // 3 - Deposit
            // 4 - Logout from account
            // If a value other than 1-2-3-4 is entered, it will give an ERROR

            int Account = 3000;

            Console.WriteLine("Your Welcome ...");
            Console.WriteLine("Chose Services: ");
            Console.WriteLine(" 1 - Your Account Amount:  ");
            Console.WriteLine(" 2 - Withdrawal: ");
            Console.WriteLine(" 3 - Deposit: ");
            Console.WriteLine(" 4 - Logout from account");

            string Options = Console.ReadLine();

            switch(Options) 
            {
                case "1":

                    Console.WriteLine("Your Account : " + Account);
                    Console.ReadLine();
                    break;

                case"2":

                    Console.WriteLine("Enter the Amount you want to withdraw: ");
                    int WithdrawAmount = Convert.ToInt32(Console.ReadLine());

                    if(WithdrawAmount> Account)
                    {
                        Console.WriteLine("You cannot withdraw more than your balance.");
                        Console.ReadLine();

                    }
                    else 
                    {
                        Console.WriteLine("Your remaining balance: " + (Account - WithdrawAmount));
                        Console.ReadLine();
                    }
                    break;

                case "3":

                    Console.WriteLine("Please Enter the Amount you want to deposit: ");
                    int Deposit = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("New Account : " + (Account + Deposit));
                    Console.ReadLine();
                    break;

                case "4":

                    Console.WriteLine("You Log out your amaount, Have a Nice Day ");
                    Console.ReadLine();
                    break;

                default:

                    Console.WriteLine("You entered the wrong value. Please try again : ");
                    Console.ReadLine();
                    break;


            
            }


        }
    }
}
