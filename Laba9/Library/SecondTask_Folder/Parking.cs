using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Parking
    {
        List<Car> cars;
        ArrayList arr;

        public Car this[int index]
        {
            get
            {
                return cars[index];
            }
        }
        public Parking()
        {
            cars = new List<Car>();
        }
        public int Count { get { return cars.Count; } }

        public void ParkNewCar(Car CarValue)
        {
            cars.Add(CarValue);
        }
        public void LeaveCar(int index)
        {
            cars.Remove(cars[index]);
        }
        
        public ArrayList GetProps(int index)
        {
            arr = new ArrayList();

            arr.Add(cars[index].Model);
            arr.Add(cars[index].Brand);
            arr.Add(cars[index].Color);
            arr.Add(cars[index].Number);
            arr.Add(cars[index].Owner.Name);
            arr.Add(cars[index].Owner.Number);

            return arr;
        }
    }
}
