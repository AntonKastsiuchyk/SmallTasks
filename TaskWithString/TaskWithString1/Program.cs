using System;

namespace TaskWithString1
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "asdf123asd12wr*we32we23";
            Console.WriteLine("My string : " + txt);

            string[] twoStrings = txt.Split('*', '-', '+', '/');

            string num1 = string.Empty;
            string num2 = string.Empty;

            foreach (char number in twoStrings[0])
            {
                if (char.IsNumber(number))
                {
                    num1 += number;
                }
            }

            foreach (char number in twoStrings[1])
            {
                if (char.IsNumber(number))
                {
                    num2 += number;
                }
            }

            switch (true)
            {
                case bool plus when plus == txt.Contains('+'):
                    Console.WriteLine("Result is: " + (int.Parse(num1) + int.Parse(num2)));
                    break;
                case bool minus when minus == txt.Contains('-'):
                    Console.WriteLine("Result is: " + (int.Parse(num1) - int.Parse(num2)));
                    break;
                case bool multiply when multiply == txt.Contains('*'):
                    Console.WriteLine("Result is: " + (int.Parse(num1) * int.Parse(num2)));
                    break;
                case bool separate when separate == txt.Contains('/'):
                    Console.WriteLine("Result is: " + (int.Parse(num1) / int.Parse(num2)));
                    break;
                default:
                    Console.WriteLine("I don't undestand what is it");
                    break;
            }
        }
    }
}
