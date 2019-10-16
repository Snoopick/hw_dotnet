using System;

namespace Task1 {
    public class Security {
        Bot bot = new Bot();
        Helpers helper = new Helpers();
        private int _storyMode = 0;

        public void Run() {
            if (this.SecurityStage()) {
                this.PassportControl();
            }
        }

        public bool SecurityStage () {
            _storyMode = helper.GetrandomNum(1, 2);
            bot.Say("Вы пришли на томоженный контроль");

            if (_storyMode == 1) {
                bot.Say("Выложите все из корманов и ручную кладь на транспортную ленту");
                helper.Wait();

                bot.Say("Пройтиде рамку металодетектора");
                helper.Wait();

                string answer = bot.Ask("'Стоит человек с грозным лицом' Что в корманах? (ответы: ничего, напишите что угодно)");
                if (!answer.Equals("ничего")) {
                    bot.Say("Вас задержали на личный досмотр, Вы пропустили свой рейс. Начните все заново!");
                    return false;
                }

                bot.Say("Заберите вещи и пройдите на пасспортный контроль");
            } else {
                bot.Say("Альтернативное проходжение");
                bot.Say("О, " + Program.userFullName + " сново в путь :)");
                bot.Say("Ну процедуру Вы уже значете, выложите все из корманов и ручную кладь на транспортную ленту");
                helper.Wait();

                bot.Say("Пройтиде рамку металодетектора");
                helper.Wait();

                bot.Say("'Стоит человек с грозным лицом, но при виде Вас рассплывается в улыбке'");
                string answer = bot.Ask("на этот раз ничего не пытаетесь провезти (сарказм)? (ответы: (нет, ничего), напишите что угодно)");

                if (!answer.Equals("ничего") && !answer.Equals("нет")) {
                    bot.Say("А Вы все шутите :)\r\nА то мы можем доложить");
                }

                bot.Say("Можете забрать вещи и пройти на пасспортный контроль");
            }

            bot.Say("Вы забрали свои вещи и пошли к пасспортному контролю");

            return true;
        }

        public void PassportControl() {
            if (_storyMode == 1) {
                bot.Say("Добрый день, Ваш паспорт");
                helper.Wait();

                bot.Say("Работник пасспортного контроля пару раз взглянул на Вас, нахмурился, что-то потыкал, вздохнул, поставил штамп и отдал Вам посспорт");
                bot.Say("Проходите в зал ожидания");
                helper.Wait();
            } else {
                bot.Say("Добрый день, " + Program.userFullName + ", Ваш паспорт");
                helper.Wait();

                bot.Say("Как всегда все впорядке");
                bot.Say("Проходите в зал ожидания");
                helper.Wait();
            }
        }
    }
}