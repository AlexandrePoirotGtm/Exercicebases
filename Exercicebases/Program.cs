﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicebases
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            AfficheFor(a, b);
            AfficheWhile(a, b);
            AfficheDoWhile(a, b);

        }
        static void AfficheFor(int a, int b)
        {
            if (a < b)
                for (int i = a+1; i < b; i++)
                {
                    Console.WriteLine("For : " + i);
                }
            else
                for (int i = a-1; i > b; i--)
                {
                    Console.WriteLine("For : " + i);
                }
        }
        static void AfficheWhile(int a, int b)
        {
            int ab = a;
            if (a < b)
                while (ab < b-1)
                {
                    ab++;
                    Console.WriteLine("While : " + ab);
                    //ab++;
                }
            else
                while (ab > b+1)
                {
                    ab--;
                    Console.WriteLine("While : " + ab);
                }
        }
        static void AfficheDoWhile(int a, int b)
        {
            int ab = a;
            if (a < b)
                do
                {
                    ab++;
                    Console.WriteLine("Do While : " + ab);
                } while (ab < b-1);
            else
                do
                {
                    ab--;
                    Console.WriteLine("Do While : " + ab);
                } while (ab > b+1);
        }
    }
}
