using GameOver.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOver
{
    public class Shop
    {
        private Item[] Warehouse { get; }


        public Shop()
        {
            Warehouse = new Item[]
            {
                new Item("Кожаная Броня", 10, 5, 50),
                new Item("Кожаные Ботинки",5, 5, 30),
                new Item("Старый затупленый клинок", 5, 20, 75),
                new Item("Наплечные пластина", 10, 0, 40),
                new Item("Пластины на ноги", 10, 0, 40),
                new Item("Нагрудная пластина", 20, 0, 50),
                new Item("Меч месного мастера", 0, 50, 150),
                new Item("Желзные перчатки", 25, 10, 50),
                new Item("Угрожающий рогатый мечь", 5, 10, 60),
                new Item("Старый лащёный доспех", 50, 10, 170),
                new Item("Щит", 30, 20, 75),
                new Item("Меч", 10, 50, 175),
                new Item("Шлем Кровавого Лорда", 75, 20, 250),
                new Item("Броня Гвардии Теней", 85, 60, 300),
                new Item("Клинок Бури", 50, 100, 450),
                new Item("Арандит", 150, 750, 1500),
                new Item("Буря мечей", 50, 800, 1500),
                new Item("Эсенсыя Бога", 4500, 4500, 6000)
            };
        }
        public void Visit(Person person)
        {
            Console.WriteLine($"Количество золота в карманах: {person.Gold}");
            if (Warehouse.Length > 0)
            {
                for (int i = 0; i < Warehouse.Length; i++)
                {
                    if (person.myStack.Contains(i))
                    {
                        continue;
                    }
                    Console.WriteLine($"{i} - {Warehouse[i].Name}");
                }
            }
            string choiseString = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(choiseString))
            {
                int choise = int.Parse(choiseString);
                if (person.Gold >= Warehouse[choise].Price && !person.myStack.Contains(choise))
                {
                    person.Hp += Warehouse[choise].HpBoost;
                    person.Strong += Warehouse[choise].StrengthBoost;
                    person.Gold -= Warehouse[choise].Price;
                    person.myStack.Push(choise);
                }
            }
        }
    }
}



