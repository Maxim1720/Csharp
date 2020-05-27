using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ThirdTask_Folder
{
    public interface IPowerable
    {
        
        void TurnOn();
        void TurnOff();

        void ChargeUp(int ChargePerCentValue);

        bool Charged { get; set; }

        int ChargeLevel { get; set; }


    }
}
