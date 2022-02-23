using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOver
{

    public class Person
    {
        public Person()
        {
            Hp = 100;
            Strong = 10;
        }
        public int Hp { get; set; }
        public int Strong { get; set; }
        public int Gold { get; set; }

        public Stack<int> myStack = new Stack<int>(); 
    }
}