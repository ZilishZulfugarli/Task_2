using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal abstract class Main
    {

        public Main (string name, string surname , string cardnumber, int cvv, int pin)
        {
            Name = name;
            Surname = surname;
            CardNumber = cardnumber;
            CVV = cvv;
            Pin = pin;
            
            
        }
        public abstract string Name { get;  set; }

        public abstract string Surname { get;  set; }

        public abstract string CardNumber { get;  set; }
         
        public abstract int CVV { get;  set; }

        public  int Balance { get;  private set; }

        public  abstract int Pin { get; set; }
        


       







    }
}
