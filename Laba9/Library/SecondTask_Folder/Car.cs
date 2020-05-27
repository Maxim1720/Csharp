using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Car : Person
    {
        public Car() { }

        public void SetColor(string CarColorValue)
        {
            Color = CarColorValue;
        }
        public void SetModel(string CarModelValue)
        {
            Model = CarModelValue;
        }
        /*public void SetBrand(string CarBrandValue)
        {
            Brand = CarBrandValue;
        }*/
        public override void SetName(string NameValue)
        {
            Brand = NameValue;
        }
        public void SetCarOwner(CarOwner CarOwnerValue)
        {
            Owner = CarOwnerValue;
        }

        public string Brand { get; private set; }
        public CarOwner Owner { get; private set; }
        public string Model { get; private set; }
        public string Color { get; private set; }




    }
}
