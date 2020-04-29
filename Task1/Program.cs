using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input String:");
            string s;
            s = "255.254.255.256.";
            if (s.IsIP())
                Console.WriteLine(s + "\nS is ip\n");
            else
                Console.WriteLine(s + "\nS is not ip\n");

            s = "e02fd0e4-00fd-090A-ca30-0d00a0038ba0.";
            if (s.IsGUID())
                Console.WriteLine(s+"\nS is GUID\n");
            else
                Console.WriteLine(s + "\nS is not GUID\n");

            s = "http://www.example.c.o.m";
            if (s.IsURL())
                Console.WriteLine(s + "\nS is URL\n");
            else
                Console.WriteLine(s + "\nS is not URL\n");

            s = "http://a.com.";
            if (s.IsURL())
                Console.WriteLine(s + "\nS is URL\n");
            else
                Console.WriteLine(s + "\nS is not URL\n");

            s = "29/02/2004";
            if (s.IsCorrectDate())
                Console.WriteLine(s + "\nS is correct date\n");
            else
                Console.WriteLine(s + "\nS is correct not date\n");

            s = "23.782455435344645654645546р.";
            if (s.IsPrice())
                Console.WriteLine(s + "\nS is correct price\n");
            else
                Console.WriteLine(s + "\nS is correct not price\n");

            s = "C00l_Pass";
            if (s.IsGoodPassword())
                Console.WriteLine(s + "\nS is good password");
        }



    }
}
