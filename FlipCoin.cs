﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class FlipCoin
    {
        public static void DisplayPercentage()
        {
            Console.WriteLine("Please Enter the value for number of flips");

            int Head = 0;
            int Tail = 0;
            int HeadCount = 0;
            int TailCount = 0;

            double HeadPercentage;
            double TailPercentage;

            int flipCoin = Convert.ToInt32(Console.ReadLine());
            if (flipCoin >= 0) { 
            for(int i=0;i<=flipCoin;i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.WriteLine("The Random Function is " + number);
                    if (number == 1)
                    {
                        HeadCount++;
                    }
                    else if(number==0)
                    {
                        TailCount++;
                    }
                }
                Console.WriteLine("The Head Count is " + HeadCount);
                Console.WriteLine("The Tail Count is " + TailCount);

                HeadPercentage = HeadCount * 100 / flipCoin;
                TailPercentage = TailCount * 100 / flipCoin;

                Console.WriteLine("The Head Percentage : {0},{1}{2}", HeadPercentage, 2, 6);
                Console.WriteLine("The Tail Percentage : "+ TailPercentage+"%"+2+34);
            }
        }
    }
}
