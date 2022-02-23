//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace GameOver
//{
//    public class Fight
//    {
//        private Dang Dang { get; }
//        private Enemy Enemy { get; }
//        private Person Person { get; }
//        public Fight (Dang dang, Enemy enemy, Person person)
//        {
//            Dang = dang;
//            Enemy = enemy;
//            Person = person;
//        }

//        public int Cicle
//        {
//            get
//            {
//                int ResultPerson = 0;
//                int ResultEnemy = 0;
//                do
//                {
//                    ResultPerson = Enemy.Hp - Person.Strong;
//                    ResultEnemy = Person.Hp - Enemy.Strong;
//                }
//                while (ResultPerson <= 0 || ResultEnemy <= 0);

//                if (ResultPerson == 0 || ResultPerson < 0)
//                {
//                    return 0;
//                }
//                else
//                {
//                    Dang.IncremetLevel();
//                    return Enemy.Gold;
//                }
//            }
//        }
//    }
//}
