using System;

namespace homeWork4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int userGold;
            int userCrystal;
            int userGoldLeft;
            int crystalPrice = 10;

            Console.WriteLine("Перед собой вы видите лавку торговца");
            Console.WriteLine("Вы решили отдохнуть после долгой дороги и прикупить себе немного кристаллов");
            Console.WriteLine("С надеждой вы заглянули в свой пыльный кошелёк.");
            Console.Write("- Привет, путник! - с вами здоровается торговец. - Гляжу устал. Не желаешь купить несколько кристаллов? Всего по " + crystalPrice + " золотых за штуку. Сколько золота у тебя есть?: ");
            userGold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Поразмыслив немного вы решили купить кристаллов, но сколько?: ");
            userCrystal = Convert.ToInt32(Console.ReadLine());
            userGoldLeft = userGold - (userCrystal * crystalPrice);
            Console.WriteLine("Через некоторое время вы вышли из лавки, слегка опустошив свой кошелёк и прибавив в коллекцию новых кристаллов.");
            Console.WriteLine("Теперь у вас " + userGoldLeft + " золота и " + userCrystal + " кристаллов. И весь мир у ваших ног!");

         } 
    }
}   
