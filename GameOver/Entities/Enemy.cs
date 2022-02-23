using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOver
{
    public class Enemy
    {
        private int Level { get; }

        public Enemy(int level)
        {
            Level = level;
        }
        public int Hp
        {
            get
            {
                return 6 + Level;
            }
        }
        public int Strong
        {
            get
            {
                return 2 + Level * 2;
            }
        }
        public int Gold
        {
            get
            {
                return 5 + Level;
            }
        }
    }
}
