using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using log4net;
using log4net.Config;

namespace LoggerPlaypen
{
    class Program
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            XmlConfigurator.Configure();

            var displayMessage = "Hello, user!";

            _log.Info(displayMessage);

            Console.WriteLine(displayMessage);

        }
    }
}
