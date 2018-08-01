using System;
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
        static void AfficheFor(int a,int b)
        {
            if(a<b)
            for (int i = a;i <= b;i++)
            {
                Console.WriteLine("For : "+i);
            }
            else
                for (int i = a; i >= b; i--)
                {
                    Console.WriteLine("For : " + i);
                }
        }
        static void AfficheWhile(int a, int b)
        {
            int ab = a;
            if (a < b)
                while (ab <= b)
                {
                    Console.WriteLine("While : " + ab);
                    ab++;
                }
            else
                while (ab >= b)
                {
                    Console.WriteLine("While : " + ab);
                    ab--;
                }
        }

        static void AfficheDoWhile(int a,int b)
        {
            int ab = a;
            if (a < b)
                do
            {
                Console.WriteLine("Do While : " + ab);
                ab++;
            } while (ab <= b);
            else
                do
                {
                    Console.WriteLine("Do While : " + ab);
                    ab--;
                } while (ab >= b);
        }
    }
}
