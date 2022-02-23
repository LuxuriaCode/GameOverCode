//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace GameOver
//{
//    public class Game
//    {
//        private Dang Dang { get; }
//        private Enemy Enemy { get; }
//        private Person Person { get; }
//        private Fight Fight { get; }
//        public Game (Dang dang, Enemy enemy, Person person, Fight fight)
//        {
//            Dang = dang;
//            Enemy = enemy;
//            Person = person;
//            Fight = fight;
//        }
//        public int Start()
//        {
//            Console.WriteLine($"Здоровье Героя: {Person.Hp} Сила Героя: {Person.Strong} Золото: {Person.Gold}");
//            if (Dang.Level < 5)
//            {
//                return 0;
//            }
//            else
//            {
//                Console.WriteLine("Хорошая битва, может пора в таверну?");
//                Console.WriteLine("Напишите 1 если 'ДА' и  0 если 'НЕТ':  ");
//                string? input = Console.ReadLine();
//                int Roud = int.Parse(input);
//                if (Roud < 2)
//                {
//                    return Roud;
//                }
//                else
//                {
//                    Console.WriteLine("Вы ввели что-то не то, невежам рановато в таверну, иди дальше");
//                    return 0;
//                }
//            }
//        }
//        public int MIdle()
//        {
//            Console.WriteLine("Похоже здесь противник!");
//            Console.WriteLine($"Здоровье Чудища {Enemy.Hp} Сила Чудища {Enemy.Strong}");
//            if (Fight.Cicle > 0)
//            {
//                Console.WriteLine("Победа!");
//                return 1;
//            }
//            else
//            {
//                Console.WriteLine("Поражение");
//                return 0;
//            }
//        }

//    }
//}
