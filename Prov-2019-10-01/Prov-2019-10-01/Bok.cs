using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_2019_10_01
{
    class Bok
    {
        public int price = 100;

        //private string name;
        private List<string> name = new List<string>() { "b1", "b2", "b3" };

        private int rarity = 0;

        private string kategori;

        private int value;


        //static 
        //public Random generator = new Random();
        //int rarity2 = generator.Next(10, 20);

        public void book ()
        {
            Random generator = new Random();
            int rarity2 = generator.Next(1, 3);
            int book = price * rarity2;

            


        }
        
        



    }
}
