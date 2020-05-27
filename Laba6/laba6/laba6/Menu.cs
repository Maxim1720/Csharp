using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    class MenuCLass
    {
        readonly int BoundSize = 50;

        public void MenuDraw()
        {
            string UpDownBound = new string('-', BoundSize);
            char Wall = '|';

            Console.WriteLine(UpDownBound);
            for (int i = 0; i < BoundSize; i++) { 
                Console.Write(Wall);
                for(int j = 0; j < BoundSize; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(Wall);
            }
            Console.WriteLine(UpDownBound);
            Console.ReadKey();

        }
    }
}
