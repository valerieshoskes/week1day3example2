﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1day3example2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int totalSugar = 7;
            int currentSugar = 2;
            Console.WriteLine("We need {0} cups of sugar", (totalSugar - currentSugar));
            */

            int individualPayment = 13;
            int billSplitBetween = 4;

            Console.WriteLine("The total bill was {0}", (individualPayment * billSplitBetween));

        }
    }
}
