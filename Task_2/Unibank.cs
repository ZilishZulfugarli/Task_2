using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_2
{
    internal class Unibank : Main
    {




        public Unibank(string name, string surname, string cardnumber, int cvv,  int pin, double balance) : base(name, surname, cardnumber, cvv, pin )
        {
            Name = name;
            Surname = surname;
            CardNumber = cardnumber;
            CVV = cvv;
            Balance = balance;
            Pin = pin;
           

        }

        public override string Name { get; set; }

        public override string Surname { get; set; }

        public override string CardNumber { get; set; }

        public override int CVV { get; set; }

        public double Balance { get;  set; }

        public override int Pin { get; set; }

        

        
         public void DecreaseBalance (double amount)
        { if (amount <= 0) return;
            Balance -= amount + (amount * 0.015);
        }
        public void IncreaseBalance(double amount)
        {
            if (amount <= 0) return;
            Balance = Balance + amount;
        }

















    }
}
