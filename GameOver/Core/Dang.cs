using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOver
{
    public class Dang
    {
        private Person Person { get; set; }
        public int Level { get; private set; } = 1;

        public Dang(Person person)
        {
            Person = person;
        }

        private bool Fight(Enemy enemy)
        {
            int enemyHp = enemy.Hp;
            int playerHp = Person.Hp;
            do
            {
                enemyHp -= Person.Strong;
                playerHp -= enemy.Strong;
                Console.WriteLine("Здоровье врага: " + enemyHp);
                Console.WriteLine("Ваше здоровье: " + playerHp);
                Console.ReadLine();
            }
            while (enemyHp > 0 && playerHp > 0);
            return playerHp == 0;
        }
        private void IncremetLevel()
        {
            this.Level += 1;
        }
        public void Start()
        {
            bool isPLayerDead = false;
            do
            {
                Console.WriteLine($"Глубина подземелия {Level}");
                Enemy[] enemies = new Enemy[]
                {
                    new Enemy(Level),
                    new Enemy(Level + 1),
                    new Enemy(Level + 2),
                    new Enemy(Level + 3),
                    new Enemy(Level + 4)
                };
                Random rnd = new Random();
                Enemy selectedEnemy = enemies[rnd.Next(enemies.Length)];
                isPLayerDead = Fight(selectedEnemy);
                if (!isPLayerDead)
                {
                    Person.Gold += selectedEnemy.Gold;
                    IncremetLevel();
                    if(Level%5 == 0)
                    {
                        Shop shop = new Shop();
                        shop.Visit(Person);
                    }                    
                }
            } while (!isPLayerDead);
        }
    }
}


