using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Bank
    {
        public Bank(string name , string surname , int code , int cvv , decimal balance )
        {
            Name = name;
            Surname = surname;
            Code = code;
            CVV = cvv;
            Balance = balance;
                                   
        }
        public string Name { get; protected set; }
        public string Surname { get; protected set; }
        public int Code { get; protected set; }
        public int CVV { get; protected set; }
        public decimal Balance { get;protected set; }
       
        public virtual void Deposit(Decimal amount )
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
            Console.WriteLine("Your balance is "+ Balance);
        }
        public virtual void withDraw(Decimal amount )
        {
            if(Balance>=amount)
            {
                decimal commission = 0;
                Balance -= amount;
                Balance -= (amount * commission) / 100;

            }
            else
            {
                Console.WriteLine("You have not enought balance!");
            }
            Console.WriteLine("Your balance is " + Balance);
        }
        
    }
}
