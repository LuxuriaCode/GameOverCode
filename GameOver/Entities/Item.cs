using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOver.Entities
{
    public class Item
    {
        public string Name { get; set; }
        public int HpBoost { get; set; }
        public int StrengthBoost { get; set; } 
        public int Price { get; set; }

        public Item(string name, int hpBoost, int strengthBoost, int price)
        {
            Name = name;
            HpBoost = hpBoost;
            StrengthBoost = strengthBoost;
            Price = price;
        }

    }
}
