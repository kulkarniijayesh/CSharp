//Extension Method to split the string given using string.Split() , Regex.Split()

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hi     TAhis is a sAtring,Split,,,Demo";
            str.SplitMe();
            Console.ReadLine();

        }
    }

    static class ExtensionClass
    {
        public static void SplitMe(this string str)
        {
            char[] SplitOn = new char[] { ' ', ',' };
            //string[] Words = Regex.Split(str,"\n\r");
            //string[] Words = str.Split('A');
            
            string[] Words = str.Split(SplitOn, StringSplitOptions.RemoveEmptyEntries);
            foreach (var Word in Words)
            {
                Console.WriteLine(Word);
            }
        }
    }

}
