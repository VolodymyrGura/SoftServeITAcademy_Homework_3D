﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServeITAcademy_Homework_3D
{
  public  class Program
    {
      public static void Main(string[] args)
        {
            // Task 1
            int i;
            double a, b, suma = 0;
            b = 1;
            for ( i = 1; i <= 30; i++)
            {
                if (i % 2 == 0)
                {
                    a = i / 2;
                }
                else
                {
                    a = i;
                }

                suma = (a - b) * (a - b);
            }

            Console.WriteLine("Suma= {0}", suma);

            // Task 2
            Console.Write("Enter N=");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (i = 0; i < n; i++)
            {
               sum += i;
               Console.Write(" {0}  {1}\n ",i, sum);
            }

            Console.ReadKey();
        }
    }
}
