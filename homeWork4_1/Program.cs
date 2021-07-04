using System;

namespace homeWork4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityGold_Hero;
            int crystal_buyHero;
            int price_forOneCrystal = 10;
            
            Console.WriteLine("Добро пожаловать в магазин кристаллов!");
            Console.WriteLine("Как ни странно, здесь Вы можете купить кристаллы");
            Console.Write("Скажите, сколько золота у Вас есть?:");
            quantityGold_Hero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Мои кристаллы стоят " + price_forOneCrystal + " золотых за 1 штуку");
            Console.Write("Сколько кристаллов Вы хотите купить?: ");
            crystal_buyHero = Convert.ToInt32(Console.ReadLine());

            int quantityCrystal_Hero = crystal_buyHero;
            int quantityGold_Hero_Left = quantityGold_Hero - (crystal_buyHero * price_forOneCrystal);

            Console.Write("Спасибо за покупку. У вас теперь есть " + quantityCrystal_Hero + " кристаллов и осталось " + quantityGold_Hero_Left + " золотых");
         } 
    }
}   
            
        
   






        