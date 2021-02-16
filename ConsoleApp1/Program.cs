using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class MyClass
    {
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            var input = "asd{id}zxc{id1}qwe$({id3}+2)sek{id4}{999}$({id3}/2)$({id3}*2)$({id3}-2){id1+}";

            string math = @"\$\((.*?)\)";

            string[] words = Regex.Split(input, @"\W*");
            string[] words2 = Regex.Split(input, @"\$\((.*?)\)|\{(.*?)\}");

            foreach (var w in words2)
            {
                
                if (Regex.IsMatch(w, @"[-*+/%]+"))      //[/*-+%]+ ciekawostka
                {
                    Console.WriteLine(w + "  math");
                }
                else if (Regex.IsMatch(w, @"[0-9]+"))       //|![/*-+%]+  && !Regex.IsMatch(w, @"[/*-+%]+")
                {
                    Console.WriteLine(w + "   id");
                }
                else //if(!String.IsNullOrEmpty(w))
                    Console.WriteLine(w+ "       @");
            }

            

        }

    }
}

