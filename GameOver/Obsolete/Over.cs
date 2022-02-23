//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace GameOver
//{
//    public class Over
//    {
//        private Game Game { get; }
//        private Shop Shop { get; }
//        public Over (Shop shop, Game game)
//        {
//            Shop = shop;
//            Game = game;
//        }
        
//        public int Static()
//        {
            
//            Game.Start();
//            int Roud = this.Game.Start();
//            if (Roud == 0)
//            {
//                Game.MIdle();
//                int ThisFightResult = this.Game.MIdle();
//                if (ThisFightResult == 0)
//                {
//                    Console.WriteLine("Попробуем начать сначала");
//                    return 0;
//                }
//                else
//                {
//                    return 1;
//                }
//            }
//            else
//            {
//                Shop.Tavetna();
//                return 0;
//            }
            
    
//        }
//    }
//}
