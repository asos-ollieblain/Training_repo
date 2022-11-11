﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Training_1
{
    internal class Guy
    {
        public string Name;
        public int Cash;

        public void WriteMyInfo()
        {
            Console.WriteLine($"{Name} has {Cash} noop");
        }
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"{Name} says {amount} isn't a valid amount");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine($"{Name} says I don't have enough cash to give you {amount}");
                return 0;
            }
            Cash -= amount;
            return amount;

        }
        public void ReceiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"{Name} says {amount} isn't an amount I'll take");
            }
            else
            {
                Cash += amount;
            }
       
        
        
        
        }

        
    }
}
