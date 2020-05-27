using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9.FirstTask_Folder.Classes
{
    [Serializable]
    abstract class Unit
    {
        public enum UpdatingSettings
        {
            HP, Attack, Armor, Distance, Price
        }
        public Unit()
        {
            UnitCount++;
        }
        ~Unit()
        {
            UnitCount--;
        }
        protected static uint UnitCount = 0;
        public virtual int HP { get; protected set; }
        public virtual string Attack { get; protected set; }
        public virtual int Armor { get; protected set; }
        public virtual int Distance { get; protected set; }
        public virtual int Price { get; protected set; }

        public virtual void UpdateFields(int NewValue, UpdatingSettings UpSet)
        {
            switch (UpSet)
            {
                case UpdatingSettings.Armor:
                    Armor = NewValue;
                    break;
                case UpdatingSettings.Distance:
                    Distance = NewValue;
                    break;
                case UpdatingSettings.HP:
                    HP = NewValue;
                    break;
                case UpdatingSettings.Price:
                    Price = NewValue;
                    break;
            }

        }
        public virtual void UpdateAttack(string NewValue)
        {
            Attack = NewValue;
        }


    }  //Абстрактный общий класс игровых юнитов

    [Serializable]
    class AxeThrower /* TrollAxethrower class*/: Unit  
    { 
        //public new int HP { get; set; }
        public AxeThrower()
        {
            AxeThrower.UnitCount++;
            HP = 40;
            Attack = "3-9";
            Armor = 2;
            Distance = 4;
            Price = 500;
        }

        public override void UpdateFields(int NewValue, UpdatingSettings UpSet)
        {
            if (UpSet.Equals(UpdatingSettings.Armor) && NewValue <= 2 && NewValue > 0)
            {
                //base.UpdateFields(NewValue, UpSet);
                Armor = NewValue;
            }
            else if (UpSet.Equals(UpdatingSettings.Distance) && NewValue <= 4 && NewValue > 0)
            {
                Distance = NewValue;
                //base.UpdateFields(NewValue, UpSet);
            }
            else if (UpSet.Equals(UpdatingSettings.HP) && NewValue <= 40 && NewValue > 0)
            {
                HP = NewValue;
                //base.UpdateFields(NewValue, UpSet);
            }
            else if (UpSet.Equals(UpdatingSettings.Price) && NewValue <= 500 && NewValue > 0)
            {
                Price = NewValue;
               // base.UpdateFields(NewValue, UpSet);
            }
            else
            {
                throw new Exception("Incorrect characteristics");
            }
        }

        ~AxeThrower()
        {
            UnitCount--;
        }

        public override string ToString()
        {
            return "AxeThrower";
        }
    } 

    [Serializable]
    class Berserker/* Berserker class - child Axethrower class*/ : AxeThrower
    {
        public Berserker()
        {
            Berserker.UnitCount++;
            HP = 50;
            Attack = "3-11";
            Armor = 2;
            Distance = 4;
            Price = 500;
        }

        ~Berserker()
        {
            UnitCount--;
        }
        public override string ToString()
        {
            return "Berserker";
        }



        public override void UpdateFields(int NewValue, UpdatingSettings UpSet)//Переопределенный метод для установки характеристик Берсерков
        {
            if (UpSet.Equals(UpdatingSettings.Armor) && NewValue <= 2 && NewValue > 0)
            {
                Armor = NewValue;  //Никаких родительских вызовов, - свой метод!!
            }
            else if (UpSet.Equals(UpdatingSettings.Distance) && NewValue <= 4 && NewValue > 0)
            {
                Distance = NewValue;
            }
            else if (UpSet.Equals(UpdatingSettings.HP) && NewValue <= 50 && NewValue > 0)
            {
                HP = NewValue;
            }
            else if (UpSet.Equals(UpdatingSettings.Price) && NewValue <= 500 && NewValue > 0)
            {
                Price = NewValue;
            }
            else
            {
                throw new Exception("Incorrect characteristics");
            }
        }
    }

    [Serializable]
    class Dragon : Unit
    {
        public Dragon()
        {
            Dragon.UnitCount++;
            HP = 100;
            Attack = "8-16";
            Armor = 0;
            Distance = 4;
            Price = 2500;
        }
        ~Dragon()
        {
            UnitCount--;
        }
        public override string ToString()
        {
            return "Dragon";
        }

        public override void UpdateFields(int NewValue, UpdatingSettings UpSet)
        {
            if (UpSet.Equals(UpdatingSettings.Armor) && NewValue > 0)
            {
                base.UpdateFields(NewValue, UpSet);
            }
            else if (UpSet.Equals(UpdatingSettings.Distance) && NewValue <= 8 && NewValue > 0)
            {
                base.UpdateFields(NewValue, UpSet);
            }
            else if (UpSet.Equals(UpdatingSettings.HP) && NewValue > 0 && NewValue <= 100)
            {
                base.UpdateFields(NewValue, UpSet);
            }
            else if (UpSet.Equals(UpdatingSettings.Price) && NewValue <= 5000 && NewValue > 0)
            {
                base.UpdateFields(NewValue, UpSet);
            }
            else
            {
                throw new Exception("Incorrect characteristics");
            }
        }

    }
}