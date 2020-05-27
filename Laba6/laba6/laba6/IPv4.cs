using System;

namespace laba6
{
    class IPv4
    {
        ulong MsgSize=0;
        ulong PckSize=0;

        /// <summary>
        /// Конструктор ввода размеров в Байтах
        /// </summary>
        /// <param name="MsgSize"></param>
        /// <param name="PckSize"></param>
        public IPv4(ulong MsgSize, ulong PckSize)
        {

            this.MsgSize = MsgSize;

            if (PckSize >= 32 && PckSize <= 32000)
            {
                this.PckSize = PckSize;
            }
            else
            {
                throw new WrongPackSizeException();
            }


        }
        /// <summary>
        /// Конструктор ввода размеров в единицах измерения(KB,MB,GB)
        /// </summary>
        /// <param name="MsgSize"></param>
        /// <param name="PckSize"></param>
        public IPv4(string MsgSize, string PckSize)
        {
            
                this.MsgSize = Convert(MsgSize);
            if (Convert(PckSize) >= 32 && Convert(PckSize) <= 32000)
            {
                this.PckSize = Convert(PckSize);
            }
            else
            {
                throw new WrongPackSizeException();
            }

            

        }
        public IPv4() { }


        public ulong GetMsgSize()
        {
            return MsgSize;
        }
        public ulong GetPckSize()
        {
            return PckSize;
        }
        public void SetMsgSize(string MessageSize)
        {

            if (NegativeSize(MessageSize))
            {
                throw new NegativeInUI();
            }
            else
            {
                this.MsgSize = Convert(MessageSize);
            }

        }

        public void SetMsgSize(ulong MsgSize)
        {
            this.MsgSize = MsgSize;

        }
        public void SetPckSize(ulong PckSize)
        {

            if (PckSize >= 32 && PckSize <= 32000)
                this.PckSize = PckSize;
            else
                throw new WrongPackSizeException();

        }
        public void SetPckSize(string PckSize)
        {

            if (NegativeSize(PckSize))
            {
                throw new NegativeInUI();
            }
            else
            {
                this.MsgSize = Convert(PckSize);
            }

        }


        public ulong GetPckAmount()
        {
            if (MsgSize > 0 && PckSize > 0)
            {
                if (PckSize >= MsgSize)
                {
                    return 1;
                }
                else if (MsgSize > PckSize)
                {
                    if (MsgSize % PckSize == 0)
                    {
                        return MsgSize / PckSize;
                    }
                    else
                    {
                        return MsgSize / PckSize + 1;
                    }
                }
            }
            return 0;
        }

        public void PckReduce(string size)
        {
            if (this.PckSize == 0)
            {
                throw new WrongPackSizeException("---------\nРазмер пакета не может быть изменен, поскольку он не задан\n---------");
            }
            else if (this.PckSize <= 32)
            {
                throw new WrongPackSizeException("---------\nУстановлен минимальный размер пакета\n---------");
            }
            
            ulong Size = Convert(size);
            if (this.PckSize - Size >= 32 && this.PckSize - Size <= 32000)
            {
                this.PckSize -= Size;
            }
            else
            {
                throw new WrongPackSizeException();
            }

        }
        public void PckReduce(ulong size)
        {
            if (this.PckSize == 0)
            {
                throw new WrongPackSizeException("---------\nРазмер пакета не может быть изменен, поскольку он не задан\n---------");
            }
            if (this.PckSize - size >= 32 && this.PckSize - size <= 32000)
                this.PckSize -= size;
            else
            {
                throw new WrongPackSizeException();
            }
        }

        public void PckIncrease(string size)
        {
            if (this.PckSize == 0)
            {
                throw new WrongPackSizeException("---------\nРазмер пакета не может быть изменен, поскольку он не задан\n---------");
            }

            ulong Size = Convert(size);
            if (this.PckSize + Size >= 32 && this.PckSize + Size <= 32000)
            {
                this.PckSize += Size;
            }
            else
            {
                throw new WrongPackSizeException();
            }
        }
        public void PckIncrease(ulong size)
        {
            if (this.PckSize == 0)
            {
                throw new WrongPackSizeException("---------\nРазмер пакета не может быть изменен, поскольку он не задан\n---------");
            }

            if (this.PckSize + size >= 32 && this.PckSize + size <= 32000)
            {
                this.PckSize += size;
            }
            else
            {
                throw new WrongPackSizeException();
            }
        }

        private bool NegativeSize(string size)
        {
            size = size.ToLower();
            size = size.Trim(' ', '?', '!');
            if(size[0] == '-')
            {
                return true;
            }
            return false;
        }
        
        private ulong Convert(string size)
        {


            if (NegativeSize(size))
            {
                throw new NegativeInUI();
            }
            else if (size == "")
            {
                throw new Exception();
            }

            size = size.ToLower();
            size = size.Trim(' ', '?', '!');

            ulong n = 0;
            uint k = 1;
            string num = "";

           
            
            for (int i = 0; i < size.Length; i++)
            {
                
                if (size[i] >= '0' && size[i] <= '9')
                {
                    num += size[i];
                }
                if (size[i] == 'k' && size[i + 1] == 'b')
                {
                    k = (uint)Math.Pow(10, 3);
                    break;
                }
                else if (size[i] == 'm' && size[i + 1] == 'b')
                {
                    k = (uint)Math.Pow(10, 6);
                    break;
                }
                else if (size[i] == 'g' && size[i + 1] == 'b')
                {
                    k = (uint)Math.Pow(10, 8);
                    break;
                }

            }
            n = (uint.Parse(num));
            n *= k;
            return n;
        }


    }

}
