using System;
using System.Linq;

namespace Task1 {
    public class CheckIn {
        Bot bot = new Bot();
        Helpers helper = new Helpers();
        
        bool _userHaveBagage;
        bool _userHaveHandBagage;
        int _userPlace;

        public CheckIn() {
            this._userHaveBagage = true;
            this._userHaveHandBagage = true;
            this._userPlace = 0;
        }

        public void Run (bool preOrderCheckin = false, string userFullName = "", string userPassportNum = "") {
            if (preOrderCheckin) {
                Console.WriteLine("Здравствуйте " + userFullName);
                _userPlace = helper.GetrandomNum(1, 60);
            } else {
                userFullName = bot.Ask("Назовате полное Имя Фамилию и Отчество");
                userPassportNum = bot.Ask("Номер паспорта");
            }

            _userHaveBagage = bot.AskBool("Есть ли у Вас багаж ?");

            if (_userHaveBagage) {
                int bagageWeight = helper.GetrandomNum(5, 30);
                int iteration = 1;
                bool bagagePaing = false;

                while (bagageWeight > 25) {
                    if (iteration == 1) {
                        bot.Say("Вес багажа больше 25 кг, нужно допдлатить или что то выложить");
                        bagagePaing = bot.AskBool("Будите опличавать?");
                    } else {
                        bot.Say("Все еще многова-то, нужно еще что-нибудь выложить");
                        helper.Wait();
                    }

                    if (bagagePaing) {
                        bagageWeight = 25;
                    } else {
                        bot.Say("Выкладывайте");
                        bagageWeight = helper.GetrandomNum(5, 30);
                    }

                    iteration++;
                }

                bot.Say("Вес не превышает 25 кг, все в порядке");
            }

            _userHaveHandBagage = bot.AskBool("Есть ли у Вас ручная кладь ?");

            if (_userHaveHandBagage) {
                int handBagageWeight = helper.GetrandomNum(1, 10);
                int iteration = 1;

                while (handBagageWeight > 5) {                    
                    if (iteration == 1) {
                        bot.Say("Вес ручной клади больще 5 кг, нужно что-то убрать");
                        helper.Wait();
                    } else {
                        bot.Say("Все еще многова-то, нужно еще что-нибудь убрать");
                        helper.Wait();
                    }

                    bot.Say("Выкладывайте");
                    handBagageWeight = helper.GetrandomNum(1, 10);

                    iteration++;
                }

                bot.Say("Вес не превышает 5 кг, все в порядке");
            }

            if (preOrderCheckin) {
                bot.Say(userFullName + " вот ваш билет, номер места " + _userPlace + ", проходите на досмотр и томоженный контроль");
                helper.Wait();
            } else {
                int placeCount = helper.GetrandomNum(1, 15);
                int[] places = new int[placeCount];
                int randomNum = 0;

                for (int i = 0; i < placeCount; i++) {
                    while (places.Contains(randomNum)) {
                        randomNum = helper.GetrandomNum(1, 60);
                    }

                    places[i] = randomNum;
                }

                bool wrongPlace = true;

                while (wrongPlace) {
                    _userPlace = Convert.ToInt32(bot.Ask("Выберите место, вот возможные " + string.Join(", ", places)));

                    if (places.Contains(_userPlace)) {
                        wrongPlace = false;
                    }
                }

                bot.Say(userFullName + " вот ваш билет, номер места " + _userPlace + ", проходите на досмотр и томоженный контроль");
                helper.Wait();
            }
        }
    }
}