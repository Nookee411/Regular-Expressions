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
            s = "127.0.0.1, 255.255.255.0.";
            if (s.IsIP())
                Console.WriteLine(s+ "\nS is ip\n");
            s = "e02fd0e4-00fd-090A-ca30-0d00a0038ba0.";
            if (s.IsGUID())
                Console.WriteLine(s+"\nS is GUID\n");
            s = "e02fd0e400fd090Aca300d00a0038ba0.";
            if (s.IsGUID())
                Console.WriteLine(s+"\nS is GUID\n");
            s = "http://www.example.com";
            if (s.IsURL())
                Console.WriteLine(s + "\nS is URL");
            s = "http://a.com.";
            if (s.IsURL())
                Console.WriteLine(s + "\nS is URL");
            s = "29/02/2000";
            if (s.IsCorrectDate())
                Console.WriteLine(s + "\nS is correct date");
            s = "23.78";
            if (s.IsPrice())
                Console.WriteLine(s + "\nS is correct price");
            s = "C00l_Pass";
            if (s.IsGoodPassword())
                Console.WriteLine(s + "\nS is good password");
        }



    }
}
