namespace Log4NetExample
{
    using System;
    using log4net;
    using log4net.Config;

    public class Log4NetExample
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Log4NetExample));

        public static void Main()
        {
            XmlConfigurator.Configure();
            Log.Debug("Starting application");
            for (int i = 0; i < 50; i++)
            {
                Log.InfoFormat("Current time is [{0}]", DateTime.Now.ToString("yyyy.MM.dd-hh.mm.ss~fff"));
            }

            Log.Debug("Ending application");
        }
    }
}
