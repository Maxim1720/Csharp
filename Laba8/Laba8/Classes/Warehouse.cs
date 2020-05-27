using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Laba8.Classes
{
    class Warehouse
    {
        //Product[] kit = new Product[17];
        public List<Product> kit = new List<Product>();
        public Product this[int i] => kit[i];
        public int Count = 17;
         public Warehouse()
        {
            Random rand = new Random();
            Product item;
            for(int i = 0; i < Count; i++)
            {
                item = new Product();
                kit.Add(item);
                //kit[i] = new Product();
                kit[i].Num = (uint)i + 1;
                kit[i].SetName((Product.Names)i);
                kit[i].SetCode((uint)rand.Next(1000,9999));
                kit[i].SetCount((uint)rand.Next(50, 150));
                kit[i].SetPrice((uint)rand.Next(10,999));
                kit[i].Kek();
            }
        }




    }
}
