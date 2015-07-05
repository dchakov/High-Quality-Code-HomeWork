namespace BoolToString
{
    using System;

    public class BoolConverter
    {
        private const int MaxCount = 6;

        public void ConvertBoolToString(bool variable)
        {
            string stringVariable = variable.ToString();
            Console.WriteLine(stringVariable);
        }
    }
}
