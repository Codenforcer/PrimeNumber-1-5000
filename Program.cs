// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, n, count;

            for (i = 1; i < 5001; i++) 
            {
                count = 0;
                if (i > 1)
                {
                    for(n = 2; n < i; n++)
                    {
                        if (i % n == 0)
                        {
                            count = 1;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.Write(i + "  ");
                    }
                }
            }
        }
    }
}














 