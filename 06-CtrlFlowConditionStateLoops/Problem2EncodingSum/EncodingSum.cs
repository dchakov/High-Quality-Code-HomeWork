namespace Exam.CSharp.EncodingSum
{
    using System;

    public class EncodingSum
    {
        public static void Main()
        {
            int moduleNumber = int.Parse(Console.ReadLine());
            string inputText = Console.ReadLine();
            int rezult = 0;

            for (int i = 0; i < inputText.Length; i++)
            {
                char currentChar = (char)inputText[i];

                if (currentChar == '@')
                {
                    break;
                }
                else if (char.IsDigit(currentChar))
                {
                    rezult *= currentChar - '0';
                }
                else if (currentChar >= 97 && currentChar <= 122)
                {
                    rezult += currentChar - 'a';
                }
                else if (currentChar >= 65 && currentChar <= 90)
                {
                    rezult += currentChar - 'A';
                }
                else
                {
                    rezult = rezult % moduleNumber;
                }
            }

            Console.WriteLine(rezult);
        }
    }
}
