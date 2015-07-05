namespace BoolToString
{
    public class BoolConverterMain
    {
        public static void Main()
        {
            BoolConverter instance = new BoolConverter();
            instance.ConvertBoolToString(true);
            instance.ConvertBoolToString(false);
        }
    }
}
