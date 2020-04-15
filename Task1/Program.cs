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
            string s = Console.ReadLine();
            if (IsIP(s))
                Console.WriteLine("This string is IP");
           
            if (IsGUID(s))
                Console.WriteLine("This string is GUID");
            
            if (IsURL(s))
                Console.WriteLine("This string is URL");
           
            if (IsCorrectDate(s))
                Console.WriteLine("This string is Date");

            if (IsPrice(s))
                Console.WriteLine("This string is Price");

            if (IsGoodPassword(s))
                Console.WriteLine("This password is strong");

        }

        static private bool IsIP(string s)
        {
            Regex reg = new Regex(@"\d{1,3}.?\d{1,3}.?\d{1,3}.?\d{1,3},? \d{1,3}.?\d{1,3}.?\d{1,3}.?\d{1,3}.?");
            return reg.IsMatch(s);
        }

        static private bool IsGUID(string s)
        {
            Regex reg = new Regex(@"\S{8}-?\S{4}-\S{4}-\S{12}");
            return reg.IsMatch(s);
        }

        static private bool IsURL(string s)
        {
            Regex reg = new Regex(@"(https?:\/\/)?(w{3}\.)?([A-Za-z1-9]){2,}\.[A-Za-z1-9]+([:]?\w{4})?((\/[A-Za-z1-9]*)*)\/?(#[A-Za-z1-9]*)?(\w*=\w*)?");
            return reg.IsMatch(s);
        }

        static private bool IsCorrectDate(string s)
        {
            Regex reg = new Regex(@"(((0?[1-9])|([12][0-8]))\/(0?2)|(((0?[1-9])|([12][0-9])|(30))\/((0?[468])|(12)|(10))|((0?[1-9])|([12][0-9])|(3[01]))\/((0?[13579])|11)))\/([1][6-9][0-9][0-9]|[2-9][0-9][0-9][0-9])|((((0?[1-9])|([12][0-9]))\/(0?2)|(((0?[1-9])|([12][0-9])|(30))\/((0?[468])|(12)|(10))|((0?[1-9])|([12][0-9])|(3[01]))\/((0?[13579])|11)))\/(((2[0-9])|(1[5-9]))((0[48])|([13579][26])|([28][0468]))))");
            return reg.IsMatch(s);
        }
        static private bool IsPrice(string s)
        {
            Regex reg = new Regex(@"\d{1,}(\.\d{0,2})? ?р(уб)?\.?");
            return reg.IsMatch(s);
        }

        static private bool IsGoodPassword(string s)
        {
            Regex reg = new Regex(@"((?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?!.* ).{8,})");
            return reg.IsMatch(s);
        }

    }
}
