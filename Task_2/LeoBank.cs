using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class LeoBank : Main
    {
        public LeoBank(string name, string surname, string cardnumber, int cvv, int pin, double balance) : base(name, surname, cardnumber, cvv, pin)
        {
            Name = name;
            Surname = surname;
            CardNumber = cardnumber;
            CVV = cvv;
            Pin = pin;
            Balance = balance;
        }
        public override string Name { get; set; }

        public override string Surname { get; set; }

        public override string CardNumber { get; set; }

        public override int CVV { get; set; }

        public double Balance { get; set; }

        public override int Pin { get; set; }




        public void DecreaseBalance(double amount)
        {
            if (amount < 0) return;
            Balance -= amount;
        }
        public void IncreaseBalance(double amount)
        {
            if (amount <= 0) return;
            Balance += ;
        }
    }
}
