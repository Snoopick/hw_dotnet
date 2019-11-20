using log4net;
using log4net.Config;

namespace hw_09 {
    class Logger {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static ILog Log {
            get { return log; }
        }

        public static void InitLogger() {
            log.Info("Application is working"); // не работает!!! :(
        }
    }
}