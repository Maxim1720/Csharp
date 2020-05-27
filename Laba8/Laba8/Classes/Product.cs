using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Laba8.Classes
{
    class Product
    {
        public enum Names : short
        {
            Помидоры,
            Огурцы,
            Бананы,
            Авокадо,
            Апельсиновый_сок,
            Томатный_сок,
            Груши,
            Яблоки,
            Апельсины,
            Мандарины,
            Грецкие_орехи,
            Чипсы_Lays,
            Молоко,
            Яйца,
            Гречка,
            Овсянка,
            Мясо,
            Рыба
        };
        public uint Num { get; set; }
        public Names Name { get; private set; }
        public uint Code { get; private set; }
        public uint Count { get; private set; }
        public long Price { get; private set; }


        public Product(Names name, uint code, uint count, long price)
        {
            this.Name = name;
            this.Code = code;
            this.Count = count;
            this.Price = price;
        }
        public Product() { }


        public void SetName(Names name) { this.Name = name; }
        public void SetCode(uint code) { this.Code = code; }
        public void SetCount(uint count) { this.Count = count; }
        public void SetPrice(long price) { this.Price = price; }
        public ArrayList arr {get; private set;}
        
       public void Kek()
        {
            arr = new ArrayList();
            arr.Add(Num);
            arr.Add(Name);
            arr.Add(Code);
            arr.Add(Count);
            arr.Add(Price);
        }

    }
}
