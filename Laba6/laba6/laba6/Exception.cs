using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace laba6
{
    class WrongPackSizeException : System.Exception
    {
        public WrongPackSizeException() {
            Console.WriteLine("------\nРазмер пакета не входит в границы(32B-32KB)\n------");
        }
       
        public WrongPackSizeException(string message) : base(message) {
            Console.WriteLine(message);
        }
        public WrongPackSizeException(string message, Exception inner) : base(message, inner) { }
        protected WrongPackSizeException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
    class NegativeInUI : System.Exception
    {
        public NegativeInUI()
        {
            Console.WriteLine("------\nОтрицательное число не может быть размером\n------");
        }
        public NegativeInUI(string message) : base(message) { }
        public NegativeInUI(string message, Exception inner) : base(message, inner) { }
        protected NegativeInUI(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
