using NLog;
using System;
namespace LogDmeo
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        
        static void Main(string[] args)
        {
            logger.Info("Enter");
            logger.Debug("Før test1");
            test1(5, 5);
            logger.Debug("efter test1");
            logger.Debug("før test2");
            test2();
            logger.Debug("Efter test2");
            logger.Info("Afslut");
        }

        static void test1(int i, int x)
        {
            logger.Trace("Param : ", i, x);
            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(1000);
            logger.Trace("Exit");
        }

        static void test2()
        {
            try
            {
                Console.WriteLine("test2");
                throw new ApplicationException("fejl");
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
    }
}