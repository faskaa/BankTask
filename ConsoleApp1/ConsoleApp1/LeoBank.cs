using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LeoBank : Bank
    {
        public LeoBank(string name, string surname, int code, int cvv, decimal balance) :
            base(name, surname, code, cvv, balance)
        {
            
        }
        public override void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                decimal commission = 0;
                Balance += amount;
                Balance -= (amount * commission) / 100;

            }
            else
            {
                Console.WriteLine("You can't enter less than 0 ");
            }
            Console.WriteLine("Your balance is " + Balance);


        }
        public override void withDraw(Decimal amount)
        {
            if (Balance >= amount)
            {
                decimal commission = 0m;
                Balance -= amount;
                Balance -= (amount * commission) / 100;
                if (Balance < 0)
                {
                    Balance += amount;
                    Balance += (amount * commission) / 100;
                    Console.WriteLine("You have not enought balance");

                }



            }
            else
            {
                Console.WriteLine("You have not enought balance!");
            }
            Console.WriteLine("Your balance is " + Balance);
        }
    }
}
