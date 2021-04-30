using System;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawPyramid(GetByte());
        }

        static void DrawPyramid(byte level)
        {
            int count = 1;
            byte j;

            for (int i = level; i != 0; i--)
            {
                for (j = 1; j < i; j++)
                {
                    Console.Write(count + " ");
                }

                Console.WriteLine(count);

                Console.Write(new string(' ', level - i + 1));

                if (++count == 10)
                {
                    count = 0;
                }
            }
        }

        static byte GetByte()
        {
            Console.WriteLine("Please input a number from 1 to 100: ");

            byte result = default;
            bool isByte = false;
            while (!isByte)
            {
                if (byte.TryParse(Console.ReadLine(), out result) && result >= 1 && result <= 100)
                {
                    isByte = true;
                }
                else
                {
                    Console.WriteLine("Please input correct value. Try again. (1 - 100)");
                }
            }
            return result;
        }
    }
}
