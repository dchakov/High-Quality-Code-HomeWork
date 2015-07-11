using System;

class Program
{
    static void Main(string[] args)
    {
        int numberM = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        int rezult = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if ((char)text[i] == '@')
            {
                break;
            }
            if ((char)text[i] >= 48 & (char)text[i] <= 57)
            {
                rezult *= (char)text[i] - 48;
            }
            if ((char)text[i] >= 97 & (char)text[i] <= 122)
            {
                rezult += ((char)text[i] - 97);
            }
            if ((char)text[i] >= 65 & (char)text[i] <= 90)
            {
                rezult += ((char)text[i] - 65);
            }
            if (!((char)text[i] >= 48 & (char)text[i] <= 57) & !((char)text[i] >= 97 & (char)text[i] <= 122) & !((char)text[i] == '@') & !((char)text[i] >= 65 & (char)text[i] <= 90))
            {
                rezult = rezult % numberM;
            }
        }
        Console.WriteLine(rezult);
    }
}
