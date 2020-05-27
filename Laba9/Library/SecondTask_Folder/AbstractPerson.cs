using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    abstract public class Person
    {
        public Person() { }
        
        protected string nameStringVariable; //Общие поля для авто и владельца - номер и имя(модель)
        protected string numberStringVariable;


        public string Name
        {
            get
            {
                return nameStringVariable;
            }
        }
        public string Number
        {
            get
            {
                return numberStringVariable;
            }
        }
        public virtual void SetNumber(string NumberValue)
        {
            numberStringVariable = NumberValue;
        }
        public virtual void SetName(string NameValue)
        {
            nameStringVariable = NameValue;
        }
    }

   
}
