using System;

namespace TaskWithString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Add long word - homework07";

            Console.WriteLine(text);
            DeleteLongWord(text);
            SwapLongWithShortWord(text);
            LettersAndPunct(text);
            Decrease(text);
        }

        static void DeleteLongWord(string text)
        {
            string[] withoutLongW = text.Split(' ');

            int temp = 0;
            int max = withoutLongW[0].Length;

            for (int i = 0; i < withoutLongW.Length; i++)
            {
                if (max < withoutLongW[i].Length)
                {
                    max = withoutLongW[i].Length;
                    temp = i;
                }
            }

            Console.Write("String without long word: ");
            for (int i = 0; i < withoutLongW.Length; i++)
            {
                if (i != temp)
                    Console.Write("{0} ", withoutLongW[i]);
            }
        }

        static void SwapLongWithShortWord(string text)
        {
            string[] arrayText = text.Split(' ');
            int tempMax = 0;
            int tempMin = 0;
            int max = arrayText[0].Length;

            for (int i = 0; i < arrayText.Length; i++)
            {
                if (max < arrayText[i].Length)
                {
                    max = arrayText[i].Length;
                    tempMax = i;
                }

                if (max > arrayText[i].Length)
                {
                    max = arrayText[i].Length;
                    tempMin = i;
                }
            }

            string buf = arrayText[tempMax];
            arrayText[tempMax] = arrayText[tempMin];
            arrayText[tempMin] = buf;

            string res = arrayText[0];
            for (int i = 1; i < arrayText.Length; i++)
                res += " " + arrayText[i];

            Console.WriteLine("\nSwap long word with short word: " + res);
        }

        static void LettersAndPunct(string text)
        {
            char[] arrayText = text.ToCharArray();

            int letter = 0;
            int punctuation = 0;

            foreach (char item in arrayText)
            {
                if (char.IsLetter(item))
                    letter++;
                if (char.IsPunctuation(item))
                    punctuation++;
            }

            Console.WriteLine("Number of letters: {0}\nNumber of punctuation characters: {1}", letter, punctuation);
        }

        static void Decrease(string text)
        {
            string[] arrayText = text.Split(' ');

            for (int i = 0; i < arrayText.Length - 1; i++)
            {
                for (int j = i + 1; j < arrayText.Length; j++)
                {
                    if (arrayText[i].Length < arrayText[j].Length)
                    {
                        string buf = string.Empty;
                        buf = arrayText[i];
                        arrayText[i] = arrayText[j];
                        arrayText[j] = buf;
                    }
                }
            }

            Console.Write("Decreasing string: ");
            foreach (var item in arrayText)
                Console.Write(item + " ");
        }
    }
}
