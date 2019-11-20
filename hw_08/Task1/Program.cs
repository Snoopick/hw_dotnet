using System;

namespace Task1 {
    class Program {
        public static string userFullName = string.Empty;
        public static string userPassportNum = string.Empty;
        public static bool preOrderCheckin = false;

        static void Main(string[] args) {
            CheckIn checkin = new CheckIn();
            Security security = new Security();
            Bot bot = new Bot();

            preOrderCheckin = bot.AskBool("Добрый день, делали ли Вы регистрацию онлайн ?");

            if (preOrderCheckin) {
                userFullName = bot.Ask("Назовите полное Имя Фамилию и Отчество");
                userPassportNum = bot.Ask("Номер паспорта");
            }

            checkin.Run(preOrderCheckin, userFullName, userPassportNum);
            security.Run();
        }
    }
}
