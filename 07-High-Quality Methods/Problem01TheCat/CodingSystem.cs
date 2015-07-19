namespace Problem01TheCat
{
    using System;
    using System.Text;

    internal class CodingSystem
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');
            StringBuilder decodedResult = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = ConvertDecimalToOtherNumeralSystem(ConvertBaseToToDecimalSystem(words[i], 21), 26);
                decodedResult.Append(currentWord);
                if (i != words.Length - 1)
                {
                    decodedResult.Append(' ');
                }

                currentWord = string.Empty;
            }

            Console.WriteLine(decodedResult.ToString());
        }

        public static ulong ConvertBaseToToDecimalSystem(string number, int numeralSystem)
        {
            ulong decimalNumber = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int digit = 0;
                if (number[i] >= 'a' && number[i] <= 'u')
                {
                    digit = number[i] - 97;
                }

                decimalNumber += (ulong)digit * MathPow(numeralSystem, number.Length - i - 1);
            }

            return decimalNumber;
        }

        public static string ConvertDecimalToOtherNumeralSystem(ulong decimalNumber, int numeralBase)
        {
            string result = string.Empty;

            while (decimalNumber > 0)
            {
                ulong digit = decimalNumber % (ulong)numeralBase;
                result = (char)(digit + 97) + result;
                decimalNumber /= (ulong)numeralBase;
            }

            return result;
        }

        public static ulong MathPow(int num, int pow)
        {
            ulong answer = 1;
            for (int i = 0; i < pow; i++)
            {
                answer *= (ulong)num;
            }

            return answer;
        }
    }
}