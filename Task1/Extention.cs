using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task1
{
    public static class StringExtention
    {

        public static bool IsIP(this string s)
        {
            Regex reg = new Regex(@"(((25[0-5]|2[0-4]\d|[01]?\d\d?)\.){3}(25[0-5]|2[0-4]\d|[01]?\d\d?))$");
            return reg.IsMatch(s);
        }

        public static bool IsGUID(this string s)
        {
            Regex reg = new Regex(@"\S{8}-?\S{4}-\S{4}-\S{12}");
            return reg.IsMatch(s);
        }

        public static bool IsURL(this string s)
        {
            Regex reg = new Regex(@"^((https?):\/\/)?(www.)?(([A-Za-z][A-Za-z_-]{0,30}[A-Za-z])(.[a-z]{1,3})){1}(:\d{3,5})?(\/[a-zA-Z]*)*(\?(\w*=\w*)&?(\w*=\w*)*)?$");
            return reg.IsMatch(s);
        }

        public static bool IsCorrectDate(this string s)
        {
            string[] split = s.Split('/');
            Regex reg;
            if (int.Parse(split[2]) % 100 != 0 || int.Parse(split[2]) % 400 == 0) //leap year
                reg = new Regex(@"(((0?[1-9])|([12][0-8]))\/(0?2)|(((0?[1-9])|([12][0-9])|(30))\/((0?[468])|(12)|(10))|((0?[1-9])|([12][0-9])|(3[01]))\/((0?[13579])|11)))\/([1][6-9][0-9][0-9]|[2-9][0-9][0-9][0-9])|((((0?[1-9])|([12][0-9]))\/(0?2)|(((0?[1-9])|([12][0-9])|(30))\/((0?[468])|(12)|(10))|((0?[1-9])|([12][0-9])|(3[01]))\/((0?[13579])|11)))\/(((2[0-9])|(1[5-9]))((0[48])|([13579][26])|([28][0468]))))");
            else //non leap year
                reg = new Regex(@"^(((0?[1-9])|([12][0-8]))\/(0?2)|(((0?[1-9])|([12][0-9])|(30))\/((0?[468])|(12)|(10))|((0?[1-9])|([12][0-9])|(3[01]))\/((0?[13579])|11)))\/([1][6-9][0-9][0-9]|[2-9][0-9][0-9][0-9])|((((0?[1-9])|([12][0-8]))\/(0?2)|(((0?[1-9])|([12][0-9])|(30))\/((0?[468])|(12)|(10))|((0?[1-9])|([12][0-9])|(3[01]))\/((0?[13579])|11)))\/(((2[0-9])|(1[5-9]))((0[48])|([13579][26])|([28][0468]))))$");
            return reg.IsMatch(s);
        }
        public static bool IsPrice(this string s)
        {
            Regex reg = new Regex(@"^\d{1,}(\.\d{0,2})? ?р(уб)?\.?$");
            return reg.IsMatch(s);
        }

        public static bool IsGoodPassword(this string s)
        {
            Regex reg = new Regex(@"((?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?!.* ).{8,})");
            return reg.IsMatch(s);
        }
    }
}
