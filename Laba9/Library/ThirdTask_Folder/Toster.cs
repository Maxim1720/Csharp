using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ThirdTask_Folder
{
    public class Toster : IPowerable
    {
        public bool Charged { get; set; }
        public int ChargeLevel { get; set; }

        public void TurnOn()
        {
            SwitchedOn = true;
        }
        public void TurnOff()
        {
            SwitchedOn = false;
        }
        public void ChargeUp(int ChargePerCentValue)
        {
            if (ChargeLevel+ChargePerCentValue < 100)
            {
                ChargeLevel += ChargePerCentValue;
            }
            else
            {
                ChargeLevel = 100;
            }
        }


        public bool SwitchedOn { get; private set; }
    }

    public class Iphone : Toster
    { }
    
}
