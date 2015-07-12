namespace Task03.RefactorLoop
{
    using System;

    public class RefactorLoop
    {
        public static void Main()
        {
            bool isFound = false;
            int[] array = new int[100];
            array[40] = 40;
            int expectedValue = 40;

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(array[i]);
                if (i % 10 == 0 && array[i] == expectedValue)
                {
                    isFound = true;
                }
            }

            if (isFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
